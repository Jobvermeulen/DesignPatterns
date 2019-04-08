using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    class CharacterA : GameCharacter
    {
        public CharacterA(string name)
        {
            this.name = name;

            AttackBehaviour = new WeakAttack();
            DefendBehaviour = new BronzeShield();
        }

    }
}
