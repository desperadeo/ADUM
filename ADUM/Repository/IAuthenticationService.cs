using ADUM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADUM.Repository
{
    public interface IAuthenticationService
    {
        AppUser Login(string username, string password);
    }
}
