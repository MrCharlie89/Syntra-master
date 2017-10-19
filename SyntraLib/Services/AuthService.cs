using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra.Services
{
    public class AuthService
    {
        /// <summary>
        /// this checks the given credentials
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool Authenticate(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new Exception("De gebruikersnaam mag niet leeg zijn");

            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Het wachtwoord mag niet leeg zijn");

            return (username == "admin" && password == "admin");
        }
    }
}
