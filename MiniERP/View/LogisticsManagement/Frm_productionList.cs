using MiniERP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.View.LogisticsManagement
{
    public partial class Frm_productionList : Form
    {
        MiniErpDB miniErp = new MiniErpDB();
        private bool chkbox = false;

        public Frm_productionList()
        {
            InitializeComponent();
            produceGrid.Columns.Add("item_code","품목코드");
            produceGrid.Columns.Add("item_name", "품목명");
            produceGrid.Columns.Add("item_standard", "품목규격");
            produceGrid.Columns.Add("M", "책정가");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (chkbox)
            {
                pnl_serchbox.Visible = true;
                chkbox = false;
            }
            else
            {
                pnl_serchbox.Visible = false;
                chkbox = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            produceCode.Clear();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            produceCode.Clear();
        }

        private void searchPlan_Click(object sender, EventArgs e)
        {
            int i = 0;
            produceGrid.DataSource = null;
            foreach (var item in miniErp.GET_MANUFACTURE_PLAN(produceCode.Text))
            {                
                produceGrid.Rows[i].Cells[0].Value = item.Item_code;
                produceGrid.Rows[i].Cells[1].Value = item.Item_name;
                produceGrid.Rows[i].Cells[2].Value = item.Item_standard                    ;
                produceGrid.Rows[i].Cells[3].Value = item.M;
                i++;
            }

        }
    }
}
