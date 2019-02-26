using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.VO
{
    class Manufacture
    {
        private string Manufactor_code;
        private string item_code;
        private string item_name;
        private int Manufactor_count;

        public string Manufactor_code1 { get => Manufactor_code; set => Manufactor_code = value; }
        public string Item_code { get => item_code; set => item_code = value; }
        public string Item_name { get => item_name; set => item_name = value; }
        public int Manufactor_count1 { get => Manufactor_count; set => Manufactor_count = value; }
    }
}
