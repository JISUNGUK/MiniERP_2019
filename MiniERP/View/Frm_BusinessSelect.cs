using MiniERP.Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.View
{
    public partial class Frm_BusinessSelect : Form
    {
        private List<Business> businesses;
        private Business business;

        public Business Business { get => business; set => business = value; }

        public Frm_BusinessSelect()
        {
            InitializeComponent();
        }

        private void Frm_BusinessSelect_Load(object sender, EventArgs e)
        {
            businesses = new BusinessDAO().GetBusiness(new Business());

            DataTable dataTable = new DataTable();
            DataColumn[] dataColumns = new DataColumn[2]
            {
                new DataColumn("거래처코드"),
                new DataColumn("거래처명")
            };
            dataTable.Columns.AddRange(dataColumns);

            foreach (var item in businesses)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["거래처코드"] = item.Code;
                dataRow["거래처명"] = item.Name;
                dataTable.Rows.Add(dataRow);
            }

            dataGridView1.DataSource = dataTable;
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            business = new Business()
            {
                Name = txtName.Text
            };
            businesses = new BusinessDAO().GetBusiness(business);

            DataTable dataTable = new DataTable();
            DataColumn[] dataColumns = new DataColumn[2]
            {
                new DataColumn("거래처코드"),
                new DataColumn("거래처명")
            };
            dataTable.Columns.AddRange(dataColumns);

            foreach (var item in businesses)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["거래처코드"] = item.Code;
                dataRow["거래처명"] = item.Name;
                dataTable.Rows.Add(dataRow);
            }

            dataGridView1.DataSource = dataTable;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            foreach (var item in businesses)
            {
                if (item.Code == dataGridView1.SelectedRows[0].Cells["거래처코드"].Value.ToString())
                {
                    business = new Business()
                    {
                        Code = item.Code,
                        Name = item.Name,
                        Tel = item.Tel,
                        Addr = item.Addr,
                        Email = item.Email,
                        Presenter = item.Presenter
                    };
                    break;
                }
            }
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
