using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.VO
{
    class Distribution
    {
        private string distribution_code;
        private string before_warehouse_code;
        private string before_warehouse_name;
        private string after_warehouse_code;
        private string after_warehouse_name;
        private string item_code;
        private string item_name;
        private int distribution_count;
        private string distribution_status;
        private DateTime move_date;

        public string Distribution_code { get => distribution_code; set => distribution_code = value; }
        public string Before_warehouse_code { get => before_warehouse_code; set => before_warehouse_code = value; }
        public string Before_warehouse_name { get => before_warehouse_name; set => before_warehouse_name = value; }
        public string After_warehouse_code { get => after_warehouse_code; set => after_warehouse_code = value; }
        public string After_warehouse_name { get => after_warehouse_name; set => after_warehouse_name = value; }
        public string Item_code { get => item_code; set => item_code = value; }
        public string Item_name { get => item_name; set => item_name = value; }
        public int Distribution_count { get => distribution_count; set => distribution_count = value; }
        public string Distribution_status { get => distribution_status; set => distribution_status = value; }
        public DateTime Move_date { get => move_date; set => move_date = value; }
    }
}
