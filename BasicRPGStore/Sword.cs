using System;
using System.Collections.Generic;
using System.Text;

namespace BasicRPGStore
{
    class Sword : Item
    {
        private int damage;
        private int undeadBonus;

        public int Damage { get => damage; set => damage = value; }
        public int UndeadBonus { get => undeadBonus; set => undeadBonus = value; }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Util.Prompt($"Damage={damage}, Undead Bonus={undeadBonus}");
        }
    }
}