using System;
using System.Collections.Generic;
using System.Text;

namespace BasicRPGStore
{
    class Axe : Item
    {
        private int damage;

        public int Damage { get => damage; set => damage = value; }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Util.Prompt($"Damage={damage}");
        }
    }
}
