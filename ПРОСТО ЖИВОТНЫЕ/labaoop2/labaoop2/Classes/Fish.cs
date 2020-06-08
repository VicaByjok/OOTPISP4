using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaoop2.Classes
{
    [Serializable]
   public class Fish:Animal
    {
        private  string pSquama;
        public string Squama
        {
            get { return pSquama; }
            set { pSquama = value; }
        }
        private  int pDepth;
        public int Depth
        {
            get { return pDepth; }
            set { pDepth = value; }
        }
        public Fish() : base("")
        {
            pSquama = "";
            pDepth = 0;
        }
        public Fish(string name) :base(name)
        {
            pSquama = "";
            pDepth = 0;
        }
        public bool Swim()
        {
           // return true;
            if ( pDepth< 6000 && pSquama != "Без чешуи") return true;
            else return false;
        }
       // public override string ToString() { return Name; }
    }
}
