using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    class BronzeShield : IDefendBehaviour
    {
        public void Defend()
        {
            Console.WriteLine("Using bronze shield to defend...");
        }

    }
    class SilverShield : IDefendBehaviour
    {
        public void Defend()
        {
            Console.WriteLine("Using silver shield to defend...");
        }

    }
    class GoldenShield : IDefendBehaviour
    {
        public void Defend()
        {
            Console.WriteLine("Using golden shield to defend...");
        }

    }
}
