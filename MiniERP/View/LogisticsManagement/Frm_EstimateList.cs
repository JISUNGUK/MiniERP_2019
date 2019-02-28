using MiniERP.Model;
using MiniERP.VO;
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
    public partial class Frm_EstimateList : Form
    {
        private bool chkbox = false;
        MiniErpDB erpdb = new MiniErpDB();
        List<SampleOrder> sampleList=new List<SampleOrder>();
        public Frm_EstimateList()
        {
            InitializeComponent();
        }

        private void btn_serch_Click(object sender, EventArgs e)
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
            ordercode.Clear();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            ordercode.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sampleList.Clear();        
            foreach (var item in erpdb.GET_ORDER(ordercode.Text))
            {
                SampleOrder so = new SampleOrder();
                so.Item_Code = item.item_code;
                so.Item_Count = item.Item_count;
                so.Item_Name = item.Item_name;
                so.Item_Wrote_Fee = item.Item_wrote_fee;
                sampleList.Add(so);
            }
            sampleOrder.DataSource = sampleList;
            sampleOrder.Columns.RemoveAt(0);
            sampleOrder.Columns[0].HeaderText = "품목이름";
            sampleOrder.Columns[1].HeaderText = "품목코드";
            sampleOrder.Columns[2].HeaderText = "품목수량";
            sampleOrder.Columns[3].HeaderText = "당시가격";

        }
    }
}
