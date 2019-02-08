using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    /// <summary>
    /// 주문 테이블
    /// </summary>
    class Order
    {
        private string order_Code;

        public string Order_Code
        {
            get { return order_Code; }
            set { order_Code = value; }
        }

        private string sample_Code;

        public string Sample_Code
        {
            get { return sample_Code; }
            set { sample_Code = value; }
        }

        private int total_Fee;

        public int Total_Fee
        {
            get { return total_Fee; }
            set { total_Fee = value; }
        }

    }
}
