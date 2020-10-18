using System;
using System.Collections.Generic;
using System.Text;

namespace BasicRPGStore
{
    class Arrow : Item
    {
        private int damage;
        private int range;

        public int Damage { get => damage; set => damage = value; }
        public int Range { get => range; set => range = value; }
        public override void PrintDetails()
        {
            base.PrintDetails();
            Util.Prompt($"Damage={damage}, Range={range}");
        }
    }
}
