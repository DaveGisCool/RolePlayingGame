using System;
using System.Collections.Generic;

namespace RolePlayingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to World of Dev.Buildcraft!\n");

            List<GameCharacter> gameCharacters = new List<GameCharacter>();

            gameCharacters.Add(new Warrior("Tnarg the Barbarian", 16, 9, "Axe"));
            gameCharacters.Add(new Warrior("Kincaid the Fighter", 15, 16, "Longsword"));
            gameCharacters.Add(new Warrior("Grant the Viking", 15, 16, "Spear"));
            gameCharacters.Add(new Wizard("Lady Witherell the Wizard", 11, 18, 10, 5));
            gameCharacters.Add(new Wizard("Pearl the Magician", 12, 17, 9, 4));

            foreach (GameCharacter fodder in gameCharacters)
            {
                fodder.Play();
            }
        }
    }
}