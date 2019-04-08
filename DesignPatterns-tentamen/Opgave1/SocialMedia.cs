using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    abstract class SocialMedia
    {
        public abstract void Login();

        public abstract void PostMessage(string message);

        public abstract void Logout();
    }
}
