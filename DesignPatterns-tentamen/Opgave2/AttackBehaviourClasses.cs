using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    class WeakAttack : IAttackBehaviour
    {
        public void Attack()
        {
            Console.WriteLine("Weak attack...");
        }
    }

    class NormalAttack : IAttackBehaviour
    {
        public void Attack()
        {
            Console.WriteLine("Normal attack...");
        }
    }

    class StrongAttack : IAttackBehaviour
    {
        public void Attack()
        {
            Console.WriteLine("Strong attack...");
        }
    }

}
