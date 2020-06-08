using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaoop2.Classes
{
    [Serializable]
   public class Animal
    {
        public string Name { get; set; }
        private int pSize;
        public int Size
        {
            get { return pSize; }
            set { pSize = value; }
        }
        private string pHabitat;
        public string Habitat
        {
            get { return pHabitat; }
            set { pHabitat = value; }
        }
        private bool pGender;
        public bool Gender
        {
            get { return pGender; }
            set { pGender = value; }
        }
        public bool Live()
        {                      
            if (pSize>1 && pHabitat!="Вулкан") return true;
           else return false;
        }
        public Animal()
        {
            Name = "";
            Size = 0;
            Habitat = "";
            Gender = false;
        }
        public Animal(string name) {
            Name = name;
            Size = 0;
            Habitat = "";
            Gender = false;
        }
        public override string ToString() { return Name; }
    }
}
