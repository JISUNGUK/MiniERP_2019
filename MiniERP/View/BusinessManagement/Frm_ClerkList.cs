using MiniERP.Model.DAO;
using MiniERP.View.StockManagement;
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

namespace MiniERP.View.BusinessManagement
{
    public partial class Frm_ClerkList : Form
    {
        List<Clerk> clerks; // Clerk테이블의 모든 내용을 저장할 리스트입니다.
        private bool serchbox = true;
        public Frm_ClerkList()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (serchbox)
            {
                pnl_serchbox.Visible = true;
                serchbox = false;
            }
            else
            {
                pnl_serchbox.Visible = false;
                serchbox = true;
            }
        }

        private void btn_ClerkInsert_Click(object sender, EventArgs e)
        {
            Frm_ClerkInsert clerkInsert = new Frm_ClerkInsert();
            clerkInsert.ShowDialog();
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
        }

        private void Frm_ClerkList_Load(object sender, EventArgs e)
        {
            clerks = new ClerkDAO().GetClerk();

            DataTable dataTable = new DataTable();
            DataColumn[] dataColumns = new DataColumn[3];
            dataColumns[0] = new DataColumn("사원코드");
            dataColumns[1] = new DataColumn("사원명");
            dataColumns[2] = new DataColumn("직급");
            dataTable.Columns.AddRange(dataColumns);

            foreach (var item in clerks)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = item.Clerk_code;
                dataRow[1] = item.Clerk_name;
                dataRow[2] = item.Clerk_job;
                dataTable.Rows.Add(dataRow);
            }

            dataGridView1.DataSource = dataTable;
        }
    }
}
