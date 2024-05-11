
using padel_champ.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Xceed.Wpf.Toolkit;



namespace padel_champ.Services
{

    public class ErrorInfo
    {
        public string status { get; set; }
        public bool isError { get; set; }
        public string message { get; set; }
        public List<string> errors { get; set; }
        public object payload { get; set; }
    }
    public class LoginSeevices : ILoginRepository
    {
      

        public LoginSeevices()
        {
            
        }
        

        public async Task<string> Login(string Email,string password)
        {
            try
            {
                var client = new HttpClient();
                string baseUrl = "http://10.0.2.2:5102/api/auth/login/" + Email + "/" + password;              
            client.BaseAddress= new Uri(baseUrl);
                HttpResponseMessage response = await client.GetAsync("");
                if (response.IsSuccessStatusCode)
                {
                    // string r = response.Content.ReadAsStringAsync().Result;
                    //      await  Shell.Current.GoToAsync("//MainPage");
                  //  Navigation.PushAsync(new MainPage());

                    return "true";
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    ErrorInfo errorInfo = JsonConvert.DeserializeObject<ErrorInfo>(error);

                    string errorMessage = errorInfo.errors[0];
                    return errorMessage;
                }
            }
            catch (Exception ex)
            {

                // Handle exception
                return "false";
            }
        }
    }
}
