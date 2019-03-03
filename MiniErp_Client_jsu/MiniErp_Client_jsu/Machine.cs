using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MiniErp_Client_jsu
{
    class Machine
    {
        private string name = AppConfiguration.GetAppConfig("name");

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string ip = AppConfiguration.GetAppConfig("ip");

        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }

        public Machine()
        {
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //KeyValueConfigurationCollection keyValue = config.AppSettings.Settings;

            //keyValue.Add("name", name);
            //config.Save();
        }
        
    }
}
