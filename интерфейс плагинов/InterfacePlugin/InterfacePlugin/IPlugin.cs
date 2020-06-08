using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePlugin
{
    public interface IPlugin 
    {
        string getExt();
        string getFileBuffName();
        void Archive(string pathoffile, string pathforfile);
        void UnArchive(string pathfile);
    }
}
