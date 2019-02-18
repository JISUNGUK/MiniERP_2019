using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.VO
{
    class SampleOrder
    {
        private string order_Code;

        public string Order_Code
        {
            get { return order_Code; }
            set { order_Code = value; }
        }

        private string item_Name;

        public string Item_Name
        {
            get { return item_Name; }
            set { item_Name = value; }
        }
        
        private string item_Code;

        public string Item_Code
        {
            get { return item_Code; }
            set { item_Code = value; }
        }

        private int item_Count;

        public int Item_Count
        {
            get { return item_Count; }
            set { item_Count = value; }
        }

        private int item_Wrote_Fee;

        public int Item_Wrote_Fee
        {
            get { return item_Wrote_Fee; }
            set { item_Wrote_Fee = value; }
        }





    }
}
