using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaoop2.Classes
{
    [Serializable]
   public class Bear:Mammals
    {
        private Salmon pPriorityFood;
        public Salmon PriorityFood
        {
            get { return pPriorityFood; }
            set { pPriorityFood = value; }
        }
        private Honey pSecondaryFood;
        public Honey SecondaryFood
        {
            get { return pSecondaryFood; }
            set { pSecondaryFood = value; }
        }
        private  int pFat;
        public int Fat
        {
            get { return pFat; }
            set { pFat = value; }
        }
        public bool Hibernation()
        {
           // return true;
            if (pFat>30) return true;
            else return false;
        }
        public Bear() : base("")
        {
            pFat = 0;
            pPriorityFood = new Salmon("");
            pSecondaryFood = new Honey("");
        }
        public Bear(string name) : base(name)
        {
            pFat = 0;
            pPriorityFood = new Salmon("");
            pSecondaryFood = new Honey("");
        }
        public override string ToString() { return Name; }
    }
}
