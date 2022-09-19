using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggClient.Managers
{
    internal class KeyMessage
    {
        public string key;
        public string ipForWhitelist;

        public KeyMessage(string key, string hostName)
        {
            this.key = key;
            ipForWhitelist = hostName;
        }
    }
}
