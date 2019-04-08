using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    class CharacterB : GameCharacter
    {
        public CharacterB(string name)
        {
            this.name = name;

            AttackBehaviour = new NormalAttack();
            DefendBehaviour = new SilverShield();
        }
    }
}
