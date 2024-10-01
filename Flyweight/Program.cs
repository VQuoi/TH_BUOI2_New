using System;
using System.Collections.Generic;

namespace Flyweight.RealWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();

            CharacterFactory factory = new CharacterFactory();

            int pointSize = 10;

            foreach (char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }

            Console.ReadKey();
        }
    }
}
