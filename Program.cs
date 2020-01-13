using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alastor
{
    class Program
    {
        private static void Main()
        {
            Parents goblinParents = new GoblinParents("Human");
            Enemy goblin = goblinParents.HaveABaby();

            goblin.TakeHit(4);
            goblin.TakeHit(29);

            Console.ReadLine();
        }
    }
}
