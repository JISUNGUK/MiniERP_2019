using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.View.LogisticsManagement
{
    public partial class Frm_ProductionPlanList : Form
    {
        bool chkPanel = false;

        public Frm_ProductionPlanList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!chkPanel)
            {
                splitContainer2.Visible = false;
                chkPanel = true;
            }
            else
            {
                splitContainer2.Visible = true;
                chkPanel = false;
            }
        }

        private void Frm_ProductionPlanList_Load(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_mainChanged(object sender, EventArgs e)
        {
            switch(sender)
            {
                case "상품품목별집계":
                    splitContainer2.Panel1.Controls["pnl_Subject"].Visible = true;
                    splitContainer2.Panel1.Controls["pnl_Trade"].Visible = false;
                    break;

                case "품목별집계":
                    splitContainer2.Panel1.Controls["pnl_Trade"].Visible = true;
                    splitContainer2.Panel1.Controls["pnl_Subject"].Visible = false;
                    break;
            }
        }
    }
}
