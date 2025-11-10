using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPA1.Services
{
    public class UserSession
    {
        public string? UserName { get; set; }
        public string? Role { get; set; }
        public string? Email { get; set; }
        public bool IsLoggedIn => !string.IsNullOrEmpty(UserName);

       public void SetUser(string? username, string? role, string? email)
        {
            UserName = username;
            Role = role;
            Email = email;
        }

        public void Logout()
        {
            UserName = null;
            Role = null;
            Email = null;
        }
    }
}
