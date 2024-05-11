using Task_Login_Signup.DTOs;
using Task_Login_Singup.Data;
using Task_Login_Singup.DTOs;

namespace Task_Login_Singup.Services
{
    public interface IAuthenticationService
    {
        Task<Response<string>> Register(string UserName, string Email, string Password, string PhoneNumber, string FirstName, string LastName, string Gender, DateTime DateOfBirth);

        Task<Response<Object>> Login(string Email, string Password);

    }
}
