using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    /// <summary>
    /// Trade 테이블
    /// </summary>
    class Trade
    {
        private string trade_code;
        private string clerk_code;
        private string order_code;
        private DateTime end_date;
        private int total_fee;
        private string trade_status;

        public string Trade_code { get => trade_code; set => trade_code = value; }
        public string Clerk_code { get => clerk_code; set => clerk_code = value; }
        public string Order_code { get => order_code; set => order_code = value; }
        public DateTime End_date { get => end_date; set => end_date = value; }
        public int Total_fee { get => total_fee; set => total_fee = value; }
        public string Trade_status { get => trade_status; set => trade_status = value; }
    }
}
