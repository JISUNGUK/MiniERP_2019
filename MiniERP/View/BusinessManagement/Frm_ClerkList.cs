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
        List<Clerk> selectClerks; // 검색 조건에 맞는 사원이 저장되어있는 리스트입니다.
        private bool serchbox = true;

        /// <summary>
        /// DataGridView의 내용을 최신화합니다.
        /// </summary>
        private void ReflashData()
        {
            clerks.Clear();
            dataGridView1.DataSource = null;
            clerks = new ClerkDAO().GetClerk(new Clerk());
            Display(clerks);
        }

        /// <summary>
        /// 매개변수로 받은 List를 이용해 DataGridView에 내용을 출력합니다.
        /// </summary>
        /// <param name="clerkList">DataGridView에 출력될 내용을 저장하고 있는 List입니다.</param>
        private void Display(List<Clerk> clerkList)
        {
            DataTable dataTable = new DataTable();
            DataColumn[] dataColumns = new DataColumn[3];
            dataColumns[0] = new DataColumn("사원코드");
            dataColumns[1] = new DataColumn("사원명");
            dataColumns[2] = new DataColumn("직급");
            dataTable.Columns.AddRange(dataColumns);

            foreach (var item in clerkList)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = item.Clerk_code;
                dataRow[1] = item.Clerk_name;
                dataRow[2] = item.Clerk_job;
                dataTable.Rows.Add(dataRow);
            }

            dataGridView1.DataSource = dataTable;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = dataGridView1.Size.Width / dataGridView1.Columns.Count;
            }
        }

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
            ReflashData();
        }

        private void Frm_ClerkList_Load(object sender, EventArgs e)
        {
            clerks = new ClerkDAO().GetClerk(new Clerk());

            Display(clerks);
        }

        private void txtCodeOrName_Click(object sender, EventArgs e)
        {
            txtCodeOrName.Text = "";
        }

        private void txtCodeOrName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Clerk clerk = new Clerk
                {
                    Clerk_code = null,
                    Clerk_name = txtCodeOrName.Text,
                    Clerk_job = null,
                    Clerk_password = null,
                };
                selectClerks = new ClerkDAO().GetClerk(clerk);

                Display(selectClerks);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            if (MessageBox.Show("선택한 사원을 삭제하시겠습니까?","사원 삭제", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                try
                {
                    new ClerkDAO().DeleteClerk(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    MessageBox.Show("해당 사원이 삭제되었습니다.", "삭제 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReflashData();
                }
                catch (Exception)
                {
                    MessageBox.Show("해당 사원이 담당중인 거래가 있습니다.", "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Clerk clerk = new Clerk
            {
                Clerk_code = null,
                Clerk_name = txtName.Text,
                Clerk_job = cmbJob.Text,
                Clerk_password = null
            };
            selectClerks = new ClerkDAO().GetClerk(clerk);
            pnl_serchbox.Visible = false;
            Display(selectClerks);
        }

        private void btnSearchClerk_Click(object sender, EventArgs e)
        {
            Frm_ClerkSelect fcs = new Frm_ClerkSelect();
            if (fcs.ShowDialog() == DialogResult.OK)
            {
                txtName.Text = fcs.Clerk.Clerk_name;
                cmbJob.Text = fcs.Clerk.Clerk_job;
            }
        }
    }
}
