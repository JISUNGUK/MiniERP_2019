using MiniERP.Model.DAO;
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

namespace MiniERP.View
{
    public partial class Frm_ClerkSelect : Form
    {
        private List<Clerk> clerks;
        private Clerk clerk;

        public Clerk Clerk { get => clerk; set => clerk = value; }

        public Frm_ClerkSelect()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 현재 class의 리스트를 이용해 DataGridView에 내용을 출력합니다.
        /// </summary>
        private void Display()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] dataColumns = new DataColumn[3]
            {
                new DataColumn("사원코드"),
                new DataColumn("사원명"),
                new DataColumn("직급")
            };
            dataTable.Columns.AddRange(dataColumns);
            foreach (var item in clerks)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["사원코드"] = item.Clerk_code;
                dataRow["사원명"] = item.Clerk_name;
                dataRow["직급"] = item.Clerk_job;
                dataTable.Rows.Add(dataRow);
            }
            dataGridView1.DataSource = dataTable;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = dataGridView1.Size.Width / dataGridView1.Columns.Count;
            }
        }

        private void Frm_ClerkSelect_Load(object sender, EventArgs e)
        {
            clerks = new ClerkDAO().GetClerk(new Clerk());
            Display();
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Clerk clerk = new Clerk()
            {
                Clerk_name = txtName.Text
            };

            clerks = new ClerkDAO().GetClerk(clerk);
            Display();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            foreach (var item in clerks)
            {
                if (item.Clerk_code == dataGridView1.SelectedRows[0].Cells["사원코드"].Value.ToString())
                {
                    Clerk = new Clerk()
                    {
                        Clerk_code = item.Clerk_code,
                        Clerk_name = item.Clerk_name,
                        Clerk_job = item.Clerk_job,
                        Clerk_password = item.Clerk_password
                    };
                    break;
                }
            }
            this.Close();
        }
    }
}
