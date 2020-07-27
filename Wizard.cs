using System;
using System.Collections.Generic;
using System.Text;

namespace RolePlayingGame
{
    class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }
        public Wizard(string charName, int strong, int smart, int zaps, int wordies) : base(charName, strong, smart, zaps)
        {
            SpellNumber = wordies;
        }
        public override void Play()
        {
            base.Play();
            Console.Write($"{Name} (int {Intelligence}, strength {Strength}, magic {MagicalEnergy}) {SpellNumber} spells\n");
        }
    }
}
