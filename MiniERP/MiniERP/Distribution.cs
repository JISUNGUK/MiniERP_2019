using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    /// <summary>
    /// Distribution 테이블
    /// </summary>
    class Distribution
    {
        private string distribution_code;
        private string before_warehouse;
        private string after_warehouse;
        private string item_code;

        public string Distribution_code { get => distribution_code; set => distribution_code = value; }
        public string Before_warehouse { get => before_warehouse; set => before_warehouse = value; }
        public string After_warehouse { get => after_warehouse; set => after_warehouse = value; }
        public string Item_code { get => item_code; set => item_code = value; }
    }
}
