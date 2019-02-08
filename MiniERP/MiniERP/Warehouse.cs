using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    /// <summary>
    /// Warehouse 테이블
    /// </summary>
    class Warehouse
    {
        private string warehouse_code;
        private string warehouse_name;
        private string warehouse_standard;

        public string Warehouse_code { get => warehouse_code; set => warehouse_code = value; }
        public string Warehouse_name { get => warehouse_name; set => warehouse_name = value; }
        public string Warehouse_standard { get => warehouse_standard; set => warehouse_standard = value; }
    }
}
