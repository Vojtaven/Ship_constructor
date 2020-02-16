using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_constructor
{
    static class Ship
    {
        private static List<IModul> modules { get; }

        public static int[] Calculate()
        {
            int totalM = 0, totalE = 0, blocks = 0;
            foreach (var modul in modules)
            {
                totalM += modul.m;
                totalE += modul.e;
                blocks++;
            }
            return new int[] { blocks, totalM, totalE };
        }

        public static void AddModule(IModul modul)
        {
            modules.Add(modul);
        }
    }
}
