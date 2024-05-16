using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    internal class LoggedInUser(string email, string password)
    {
        public string Email { get; set; } = email;
        private string Password { get; set; } = password;
    }
}
