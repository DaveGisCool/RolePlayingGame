using System;
using System.Collections.Generic;
using System.Text;

namespace RolePlayingGame
{
    class GameCharacter
    {
        public string Name { get; protected set; }
        public int Strength { get; protected set; }
        public int Intelligence { get; protected set; }
        public GameCharacter(string charName, int strong, int smart)
        {
            Name = charName;
            Strength = strong;
            Intelligence = smart;
        }
        public virtual void Play()
        {
        }
    }
}
