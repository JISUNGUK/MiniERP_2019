using MiniERP.Model.DAO;
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
            DataTable dt = new DataTable();
            DataColumn[] dataColumns = new DataColumn[3]{
                new DataColumn("주문번호"),
                new DataColumn("거래처코드"),
                new DataColumn("거래처")
            };
            dt.Columns.AddRange(dataColumns);

            foreach (VO.Ordered order in ordered.SelectAllOrdered())
            {
                DataRow dataRow = dt.NewRow();
                dataRow["주문번호"] = order.Order_Code;
                dataRow["거래처코드"] = order.Business_Code;
                dataRow["거래처"] = order.Business_name;
                dt.Rows.Add(dataRow);
            }
            dataGridView1.DataSource = dt;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.DataBindings.Clear();
            string orderedCode = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int totalFee = 0;

            DataTable dt = new DataTable();
            DataColumn[] dataColumns = new DataColumn[7]{
                new DataColumn("주문번호"),
                new DataColumn("품목"),
                new DataColumn("품목코드"),
                new DataColumn("갯수"),
                new DataColumn("금액"),
                new DataColumn("단위(unit)"),
                new DataColumn("규격(standard)")
            };
            dt.Columns.AddRange(dataColumns);

            foreach (VO.SampleOrder order in ordered.SelectSampleOrdered(orderedCode))
            {
                DataRow dataRow = dt.NewRow();
                dataRow["주문번호"] = order.Order_Code;
                dataRow["품목"] = order.Item_Name;
                dataRow["품목코드"] = order.Item_Code;
                dataRow["갯수"] = order.Item_Count;
                dataRow["금액"] = order.Item_Wrote_Fee;
                dataRow["단위(unit)"] = order.Item_unit;
                dataRow["규격(standard)"] = order.Item_standard;
                dt.Rows.Add(dataRow);

                totalFee += (int)order.Item_Wrote_Fee;
            }

            dataGridView2.DataSource = dt;
            lbl_totalFee.Text = "총 금액 : " + totalFee;
        }
    }
}
