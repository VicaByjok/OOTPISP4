using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaoop2.Classes
{
    [Serializable]
   public class Mammals:Animal
    {
        private  string pColor;
        public string Color
        {
            get { return pColor; }
            set { pColor = value; }
        }
        private  int pLifeTime;
        public int LifeTime
        {
            get { return pLifeTime; }
            set { pLifeTime = value; }
        }
        public Mammals() : base("")
        {
            pColor = "";
            pLifeTime = 0;
        }
        public Mammals(string name) : base(name)
        {
            pColor = "";
            pLifeTime = 0;
        }
        public bool Reproduce()
        {
            //return true;
           if (pLifeTime < 60 && pColor != "Ужасный цвет лёшиных формочек") return true;
            else return false;
        }
        public override string ToString() { return Name; }
    }
}
