using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MiniErp_Client_jsu
{
    class Machine
    {
        private string name = "머신1";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string ip = "192.168.0.240";

        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }


        
    }
}
