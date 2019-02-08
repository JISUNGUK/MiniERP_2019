using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    /// <summary>
    /// 견적서 테이블
    /// </summary>
    class SampleOrder
    {
        private string sample_Code;

        public string Sample_Code
        {
            get { return Sample_Code; }
            set { Sample_Code = value; }
        }

        private string item_Code;

        public string Item_Code
        {
            get { return item_Code; }
            set { item_Code = value; }
        }

        private string business_Code;

        public string Business_Code
        {
            get { return business_Code; }
            set { business_Code = value; }
        }

        private int item_Count;

        public int Item_Count
        {
            get { return item_Count; }
            set { item_Count = value; }
        }


    }
}
