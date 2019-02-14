using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.VO
{
    /// <summary>
    /// Ordered 테이블 정의
    /// </summary>
    public class Ordered
    {
        private string order_Code;

        public string Order_Code
        {
            get { return order_Code; }
            set { order_Code = value; }
        }
        private string bussBusiness_Code;

        public string Business_Code
        {
            get { return bussBusiness_Code; }
            set { bussBusiness_Code = value; }
        }

    }
}
