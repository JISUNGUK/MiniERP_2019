﻿using MiniERP.Model.DAO;
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
    public partial class Frm_OrderList : Form
    {
        private bool boxchk = true;

        OrderedDAO ordered = new OrderedDAO();

        public Frm_OrderList()
        {
            InitializeComponent();
        }

        private void Frm_OrderList_Load(object sender, EventArgs e)
        {
            // 테스트 모듈
            //OrderedDAO ordered = new OrderedDAO();
            dataGridView1.DataSource = ordered.SelectAllOrdered();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (boxchk)
            {
                pnl_serchbox.Visible = true;
                boxchk = false;
            }
            else
            {
                pnl_serchbox.Visible = false;
                boxchk = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());
            string orderedCode = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            MessageBox.Show(orderedCode);

            dataGridView1.DataSource = ordered.SelectSampleOrdered(orderedCode);
            
            //dataGridView1.DataSource= ordered.SelectSampleOrdered()
        }
    }
}
