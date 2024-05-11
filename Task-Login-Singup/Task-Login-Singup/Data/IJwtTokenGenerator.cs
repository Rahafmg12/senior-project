using System.Security.Claims;

namespace Task_Login_Singup.Data
{
    public interface IJwtTokenGenerator
    {
        public string GenerateToken(List<Claim> claims, IConfiguration config);
    }
}
