using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using labaoop2.Classes;
namespace labaoop2
{
    [XmlInclude(typeof(Animal)), XmlInclude(typeof(Ant)), XmlInclude(typeof(AntEater)),
        XmlInclude(typeof(Bear)), XmlInclude(typeof(Bee)), XmlInclude(typeof(Fish)), XmlInclude(typeof(Honey)), XmlInclude(typeof(Insect)),
        XmlInclude(typeof(Mammals)), XmlInclude(typeof(Salmon))]
    
    [Serializable]
    public class MyClassCollection
    {
        [XmlArray("Collection"), XmlArrayItem("Item")]
        public List<object> Collection { get; set; }
    }
}
