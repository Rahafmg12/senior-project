using Microsoft.AspNetCore.Identity;
using Task_Login_Signup.DTOs;

namespace Task_Login_Singup.Models
{
    public class ApplicationUser : IdentityUser
    {

        public string? FirstName { get; set; }

        public string? LastName { get; set; }
        
        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
