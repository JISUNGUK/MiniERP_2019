using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    /// <summary>
    /// Item 테이블
    /// </summary>
    class Item
    {
        private string item_code;
        private string item_name;
        private string item_standard;
        private string item_unit;
        private string item_class;
        private int item_fee;
        private Image item_image;
        private string item_group;
        private string item_comment;

        public string Item_code { get => item_code; set => item_code = value; }
        public string Item_name { get => item_name; set => item_name = value; }
        public string Item_standard { get => item_standard; set => item_standard = value; }
        public string Item_unit { get => item_unit; set => item_unit = value; }
        public string Item_class { get => item_class; set => item_class = value; }
        public int Item_fee { get => item_fee; set => item_fee = value; }
        public Image Item_image { get => item_image; set => item_image = value; }
        public string Item_group { get => item_group; set => item_group = value; }
        public string Item_comment { get => item_comment; set => item_comment = value; }
    }
}
