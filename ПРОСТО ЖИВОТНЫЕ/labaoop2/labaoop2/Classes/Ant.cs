using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaoop2.Classes
{
    [Serializable]
   public class Ant:Insect
    {
        public string Kind { get; set; }

        public string Caste { get; set; }
        public bool BuildAnthill()
        {
           // return true;
           if (Caste == "Рабочие") return true;
            else return false;
        }
        public Ant():base("")
        {
            Kind = "";
            Caste = "";
        }
        public Ant(string name) : base(name)
        {
            Kind = "";
            Caste = "";
        }
        public override string ToString() { return Name; }
    }
}
