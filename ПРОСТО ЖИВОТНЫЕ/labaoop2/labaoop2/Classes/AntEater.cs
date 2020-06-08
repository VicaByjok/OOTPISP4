using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaoop2.Classes
{
    [Serializable]
   public class AntEater:Mammals
    {
        private  Ant pMainFood;
        public Ant MainFood
        {
            get { return pMainFood; }
            set { pMainFood = value; }
        }
        private  int pLength_Of_Tongue;
        public int Length_Of_Tongue
        {
            get { return pLength_Of_Tongue; }
            set { pLength_Of_Tongue = value; }
        }
        public AntEater() : base("")
        {
            pMainFood = new Ant("");
            pLength_Of_Tongue = 0;
        }
        public AntEater(string name) : base(name)
        {
            pMainFood = new Ant("");
            pLength_Of_Tongue = 0;
        }
        public bool EatAnt()
        {
           // return true;
            if (pLength_Of_Tongue>30 && pMainFood!=null) return true;
            else return false;
        }
        public override string ToString() { return Name; }
    }
}
