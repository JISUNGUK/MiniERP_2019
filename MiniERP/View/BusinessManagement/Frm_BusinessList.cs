using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.View.BusinessManagement
{
    public partial class Frm_BusinessList : Form
    {
        public Frm_BusinessList()
        {
            InitializeComponent();
        }

        private void btn_BusinessSelect_Click(object sender, EventArgs e)
        {
            Frm_BusinessSelect Frm_businessSelect = new Frm_BusinessSelect();
            Frm_businessSelect.ShowDialog();              
        }
    }
}
