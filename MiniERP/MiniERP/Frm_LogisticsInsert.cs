﻿using System;
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
    public partial class Frm_LogisticsInsert : Form
    {
        public Frm_LogisticsInsert()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_ItemSelect itemSelect = new Frm_ItemSelect();
            itemSelect.Show();
        }
    }
}
