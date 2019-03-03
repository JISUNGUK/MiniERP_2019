using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.VO
{
    public class Trade
    {
        private string trade_code;
        private string business_code;
        private string business_name;
        private string warehouse_code;
        private string warehouse_name;
        private int total_fee;
        private string trade_status;
        private string trade_standard;
        private DateTime end_date;
        private string end_date_str;
        private string clerk_code;
        private string clerk_name;
        private string item_summary;

        public string Trade_code { get => trade_code; set => trade_code = value; }
        public string Business_code { get => business_code; set => business_code = value; }
        public string Business_name { get => business_name; set => business_name = value; }
        public string Warehouse_code { get => warehouse_code; set => warehouse_code = value; }
        public string Warehouse_name { get => warehouse_name; set => warehouse_name = value; }
        public int Total_fee { get => total_fee; set => total_fee = value; }
        public string Trade_status { get => trade_status; set => trade_status = value; }
        public string Trade_standard { get => trade_standard; set => trade_standard = value; }
        public DateTime End_date { get => end_date; set => end_date = value; }
        public string Clerk_code { get => clerk_code; set => clerk_code = value; }
        public string Clerk_name { get => clerk_name; set => clerk_name = value; }
        public string Item_summary { get => item_summary; set => item_summary = value; }
        public string End_date_str { get => end_date_str; set => end_date_str = value; }
    }
    
}
