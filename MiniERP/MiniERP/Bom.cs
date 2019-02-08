using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    /// <summary>
    /// Bom 테이블
    /// </summary>
    class Bom
    {
        private string item_code;
        private string part_code;
        private int part_count;

        public string Item_code { get => item_code; set => item_code = value; }
        public string Part_code { get => part_code; set => part_code = value; }
        public int Part_count { get => part_count; set => part_count = value; }
    }
}
