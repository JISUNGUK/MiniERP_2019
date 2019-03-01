using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniErp_Client_jsu
{
    class Barcode
    {
        private string barcode_Code;

        public string Barcode_Code
        {
            get { return barcode_Code; }
            set { barcode_Code = value; }
        }

        private int barcode_Count;

        public Barcode(string barcode_Code)
        {
            this.barcode_Code = barcode_Code;
            this.barcode_Count = 1;
        }

        public int Barcode_Count
        {
            get { return barcode_Count; }
            set { barcode_Count = value; }
        }
    }
}
