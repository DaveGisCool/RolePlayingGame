using System;
using System.Collections.Generic;
using System.Text;

namespace RolePlayingGame
{
    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }
        public MagicUsingCharacter(string charName, int strong, int smart, int zaps) : base(charName, strong, smart)
        {
            MagicalEnergy = zaps;
        }
        public override void Play()
        {
            base.Play();
        }
    }
}
