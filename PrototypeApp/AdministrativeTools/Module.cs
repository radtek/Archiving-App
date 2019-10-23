using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyDocServer
{
    class Module
    {
        private string modName;
        private string modCreateQ;

        public Module(string n , string q)
        {
            modName = n;
            modCreateQ = q;
        }
        public string GetName()
        {
            return modName;
        }
        public string GetCreateQ()
        {
            return modCreateQ;
        }
        
        public void SetName(string n)
        {
            modName = n;
        }

        public void SetCreateQ(string q)
        {
            modCreateQ = q;
        }
    }
}
