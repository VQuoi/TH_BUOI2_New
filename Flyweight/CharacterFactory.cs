using System.Collections.Generic;

namespace Flyweight.RealWorld
{
    public class CharacterFactory
    {
        private Dictionary<char, Character> characters = new Dictionary<char, Character>();

        public Character GetCharacter(char key)
        {
            Character character = null;

            if (characters.ContainsKey(key))
            {
                character = characters[key];
            }
            else
            {
                switch (key)
                {
                    case 'A': character = new CharacterA(); break;
                    case 'B': character = new CharacterB(); break;
                    case 'Z': character = new CharacterZ(); break;
                        // You can add more cases for other characters (C, D, E, etc.)
                }
                characters.Add(key, character);
            }
            return character;
        }
    }
}
