using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    class Facebook : SocialMedia
    {
        private string username;
        private string password;

        public Facebook(string username, string password)
        {
            this.username = username;
            this.password = password;
            Login();
        }

        public override void Login()
        {
            Console.WriteLine($"logging in ({username}) on Facebook...");
        }

        public override void Logout()
        {
            Console.WriteLine($"logging out from Facebook...");
        }

        public override void PostMessage(string message)
        {
            Console.WriteLine($"posting message '{message}' on Facebook...");
            Logout();
        }
    }
}
