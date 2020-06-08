using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaoop2.Classes
{
    [Serializable]
   public class Honey
    {
        public string Name { get; set; }
        private string pType_Of_Flowers;
        public string Type_Of_Flowers
        {
            get { return pType_Of_Flowers; }
            set { pType_Of_Flowers = value; }
        }
        private int pDensity;
        public int Density
        {
            get { return pDensity; }
            set { pDensity = value; }
        }
        public Honey()
        {
            Name = "";
            Type_Of_Flowers = "";
            Density = 0;
        }
        public Honey(string name)
        {
            Name = name;
            Type_Of_Flowers = "";
            Density = 0;
        }
        public override string ToString() { return Name; }
    }
}
