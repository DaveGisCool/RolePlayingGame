using System;
using System.Collections.Generic;
using System.Text;

namespace RolePlayingGame
{
    class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }
        public Warrior(string charName, int strong, int smart, string weaponName) : base(charName, strong, smart)
        {
            WeaponType = weaponName;
        }
        public override void Play()
        {
            base.Play();
            Console.Write($"{Name} (int {Intelligence}, strength {Strength}) {WeaponType}\n");
        }
    }
}
