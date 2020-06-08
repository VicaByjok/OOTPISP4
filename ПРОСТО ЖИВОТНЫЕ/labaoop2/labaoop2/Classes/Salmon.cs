using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaoop2.Classes
{
    [Serializable]
  public  class Salmon:Fish
    {
        private  int pCalories;
        public int Calories
        {
            get { return pCalories; }
            set { pCalories = value; }
        }
        private  int pMass;
        public int Mass
        {
            get { return pMass; }
            set { pMass = value; }
        }
        public bool Spat()
        {
           // return true;
            if (pMass>1) return true;
            else return false;
        }
        public Salmon() : base("")
        {
            pCalories = 0;
            pMass = 0;
        }
        public Salmon(string name) : base(name)
        {
            pCalories = 0;
            pMass = 0;
        }
        public override string ToString() { return Name; }
    }
}
