using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_constructor
{
    interface IModul
    {
        int m { get; }
        int e { get; }
        int lm { get; }
        int le { get; }
        int l { get; set; }
        string property { get; }
    }
}
