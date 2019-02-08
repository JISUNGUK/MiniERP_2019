using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP
{
    public partial class Frm_LogisticsList : Form
    {
        public Frm_LogisticsList()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_LogisticsInsert frm_LogisticsInsert = new Frm_LogisticsInsert();
            frm_LogisticsInsert.Show();
        }
    }
}
