using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    /// <summary>
    /// Stock 테이블
    /// </summary>
    class Stock
    {
        private string stock_code;
        private string stock_name;
        private string stock_standard;
        private int stock_count;
        private string warehouse_code;
        private string item_code;

        public string Stock_code { get => stock_code; set => stock_code = value; }
        public string Stock_name { get => stock_name; set => stock_name = value; }
        public string Stock_standard { get => stock_standard; set => stock_standard = value; }
        public int Stock_count { get => stock_count; set => stock_count = value; }
        public string Warehouse_code { get => warehouse_code; set => warehouse_code = value; }
        public string Item_code { get => item_code; set => item_code = value; }
    }
}
