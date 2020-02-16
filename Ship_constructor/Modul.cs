using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_constructor
{
    class Modul
    {
        public int Weight { get; private set; }
        public string Name { get; private set; }
        public int Energy { get; private set; }
        private int massPerLevel;
        public int Level { get; private set; }
        private int energyPerLevel;
        public string Info { get; private set; }

        public Modul(string name,int massPerLevel=1, int energyPerLevel=1, int weight=1,int energy=-1, int level=0) {
            this.Name = name;
            this.Weight = weight;
            this.Energy = energy;
            this.Level = level;
            this.massPerLevel = massPerLevel;
            this.energyPerLevel = energyPerLevel;
            this.Info = generateInfo();
        }

        private string generateInfo() {
           this.Info = this.Name + " - " + this.Level + " lvl";
            return this.Info;
        }
        public int levelUp() {
            this.Level++;
            this.Weight += this.massPerLevel;
            this.Energy += this.energyPerLevel;
            Info = generateInfo();
            return this.Level;
        }

        public int setLevel(int lvl) {
            this.Level = lvl;
            this.Weight += lvl * this.massPerLevel;
            this.Energy += lvl * this.energyPerLevel;
            Info = generateInfo();
            return this.Level;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
