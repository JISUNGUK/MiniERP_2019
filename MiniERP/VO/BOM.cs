using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.VO
{
    class BOM
    {
        private string item_code;
        private string item_name;
        private string part_code;
        private string part_name;
        private int part_count;

        public string Item_code { get => item_code; set => item_code = value; }
        public string Item_name { get => item_name; set => item_name = value; }
        public string Part_code { get => part_code; set => part_code = value; }
        public string Part_name { get => part_name; set => part_name = value; }
        public int Part_count { get => part_count; set => part_count = value; }
    }
}
