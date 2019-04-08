using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader("Popolon");
            GameCharacter popolon = new CharacterA("Popolon");
            popolon.Attack(); popolon.Defend();

            Console.WriteLine();

            PrintHeader("Aphrodite");
            GameCharacter aphrodite = new CharacterB("Aphrodite");
            aphrodite.Attack(); aphrodite.Defend();

            Console.WriteLine();

            PrintHeader("Change behaviour of Aphrodite");
            aphrodite.AttackBehaviour = new StrongAttack();
            aphrodite.DefendBehaviour = new GoldenShield();
            aphrodite.Attack(); aphrodite.Defend();

            Console.WriteLine();

            Console.ReadLine();
        }

        private static void PrintHeader(string name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(name);
            Console.ResetColor();
        }
    }
}
