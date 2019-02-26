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
        private string business_code;

        public string Business_Code
        {
            get { return business_code; }
            set { business_code = value; }
        }


        private string business_name;
        public string Business_name { get => business_name; set => business_name = value; }

    }
}
