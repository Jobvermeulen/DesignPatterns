using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    abstract class GameCharacter
    {
        public string name { get; set; }
        public IAttackBehaviour AttackBehaviour { get; set; }
        public IDefendBehaviour DefendBehaviour { get; set; } 

        public GameCharacter()
        {
        }

        public void Attack()
        {
            AttackBehaviour.Attack();
        }

        public void Defend()
        {
            DefendBehaviour.Defend();
        }
    }
}
