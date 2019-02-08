using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    /// <summary>
    /// Manufacture 테이블
    /// </summary>
    class Manufacture
    {
        private string manufacture_code;
        private string item_code;
        private int manufacture_count;

        public string Manufacture_code { get => manufacture_code; set => manufacture_code = value; }
        public string Item_code { get => item_code; set => item_code = value; }
        public int Manufacture_count { get => manufacture_count; set => manufacture_count = value; }
    }
}
