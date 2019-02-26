using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.VO
{
    class Stock
    {
        private string item_code;
        private string stock_name;
        private string warehouse_code;
        private string warehouse_name;
        private int stock_count;
        private string stock_standard;

        public string Item_code { get => item_code; set => item_code = value; }
        public string Stock_name { get => stock_name; set => stock_name = value; }
        public string Warehouse_code { get => warehouse_code; set => warehouse_code = value; }
        public string Warehouse_name { get => warehouse_name; set => warehouse_name = value; }
        public int Stock_count { get => stock_count; set => stock_count = value; }
        public string Stock_standard { get => stock_standard; set => stock_standard = value; }
    }
}
