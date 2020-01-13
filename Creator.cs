using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alastor
{
    abstract class Parents
    {
        public string MotherRace { get; set; }
        public string FatherRace { get; set; }

        public Parents(string motherRace, string fatherRace)
        {
            MotherRace = motherRace;
            FatherRace = fatherRace;
        }

        abstract public Enemy HaveABaby();
    }
}
