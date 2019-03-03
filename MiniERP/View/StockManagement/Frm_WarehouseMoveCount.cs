using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.View.StockManagement
{
    public partial class Frm_WarehouseMoveCount : Form
    {
        public Frm_WarehouseMoveCount(int MaxNum)
        {
            InitializeComponent();
            num_updown.Maximum = MaxNum;
            num_updown.Value = MaxNum;
        }

        int returnNum = 0;
        public int ReturnNum { get => returnNum; }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if(num_updown.Value != 0)
            {
                returnNum = Convert.ToInt32(num_updown.Value);
                this.Close();
            }
            else
            {
                MessageBox.Show("선택된 값이 1 이상이어야합니다.");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
