using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaoop2.Classes
{
    [Serializable]
    public class Bee:Insect
    {

        private bool pDomesticated;
        public bool Domesticated
        {
            get { return pDomesticated; }
            set { pDomesticated = value; }
        }
        private string pCaste;
        public string Caste
        {
            get { return pCaste; }
            set { pCaste = value; }
        }
        public Honey Honey { get; set; }
        public bool Fly()
        {
           // return true;
            if (Wings) return true;
            else return false;
        }
        public Bee() : base("")
        {
            pDomesticated = false;
            pCaste = "";
            Honey = new Honey("");
        }
        public Bee(string name) : base(name)
        {
            pDomesticated = false;
            pCaste = "";
            Honey = new Honey("");
        }
        public override string ToString() { return Name; }
    }
}
