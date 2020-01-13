using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alastor
{
    class GoblinParents : Parents
    {
        public GoblinParents(string fatherRace) : base("Goblin", fatherRace)
        {

        }

        public override Enemy HaveABaby()
        {
            return new Goblin();
        }
    }
}
