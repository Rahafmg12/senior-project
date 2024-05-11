using padel_champ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace padel_champ.Services
{
    public interface ILoginRepository
    {
           Task<string> Login(string Email,string password);
    }
}
