using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaoop2.Classes
{
    [Serializable]
   public class Insect:Animal
    {
        private  bool pWings;
        public  bool Wings
        {
            get { return pWings; }
            set { pWings = value; }
        }
        private int pToxity;
        public int Toxity
        {
            get { return pToxity; }
            set { pToxity = value; }
        }
        public Insect() : base("")
        {
            pWings = false;
            pToxity = 0;
        }
        public Insect(string name) : base(name)
        {
            pWings = false;
            pToxity = 0;
        }
        public override string ToString() { return Name; }
    }
}
