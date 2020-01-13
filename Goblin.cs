using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alastor
{
    class Goblin : Enemy
    {
        public Goblin()
        {
            Console.WriteLine("Goblin has born!");
        }

        public override void TakeHit(int amount)
        {
            Console.WriteLine($"ARGH! {(amount < 10 ? "Pice of cake!" : "It's hurt!")}");
        }

        public void MakeNoice()
        {
            Console.WriteLine("arg-arg-arg.");
        }
    }
}
