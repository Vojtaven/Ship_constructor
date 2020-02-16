using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_constructor.Modules
{
    public class Aux_U00 : IModul
    {
        public int m { get; }
        public int e { get; }
        public int lm { get; }
        public int le { get; }
        public int l { get; set; }
        public string property { get; }

        public Aux_U00(int l)
        {
            lm = 0;
            le = 0;
            m = 1 + lm * l;
            e = (1 + le * l) * -1;
            property = "Jedna posádka";
        }
    }
}
