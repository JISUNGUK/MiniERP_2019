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

namespace MiniERP.View
{
    public partial class Frm_WarehouseSelect : Form
    {
        private List<Warehouse> warehouses;
        private Warehouse warehouse;

        public Warehouse Warehouse { get => warehouse; set => warehouse = value; }

        public Frm_WarehouseSelect()
        {
            InitializeComponent();
        }

        private void Frm_WarehouseSelect_Load(object sender, EventArgs e)
        {
            warehouses = new WarehouseDAO().GetWarehouses(new Warehouse());

            DataTable dataTable = new DataTable();
            DataColumn[] dataColumns = new DataColumn[3]
            {
                new DataColumn("구분"),
                new DataColumn("창고코드"),
                new DataColumn("창고명")
            };
            dataTable.Columns.AddRange(dataColumns);

            foreach (var item in warehouses)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["구분"] = item.Warehouse_standard;
                dataRow["창고코드"] = item.Warehouse_code;
                dataRow["창고명"] = item.Warehouse_name;
                dataTable.Rows.Add(dataRow);
            }
            dataGridView1.DataSource = dataTable;
            // DataGridView에 표시되는 컬럼의 넓이를 설정합니다.
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = dataGridView1.Size.Width / dataTable.Columns.Count;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            warehouse = new Warehouse
            {
                Warehouse_code = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                Warehouse_name = dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                Warehouse_standard = dataGridView1.SelectedRows[0].Cells[0].Value.ToString()
            };
            this.Close();
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            warehouse = new Warehouse()
            {
                Warehouse_name = txtName.Text
            };
            warehouses = new WarehouseDAO().GetWarehouses(warehouse);

            DataTable dataTable = new DataTable();
            DataColumn[] dataColumns = new DataColumn[3]
            {
                new DataColumn("구분"),
                new DataColumn("창고코드"),
                new DataColumn("창고명")
            };
            dataTable.Columns.AddRange(dataColumns);

            foreach (var item in warehouses)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["구분"] = item.Warehouse_standard;
                dataRow["창고코드"] = item.Warehouse_code;
                dataRow["창고명"] = item.Warehouse_name;
                dataTable.Rows.Add(dataRow);
            }
            dataGridView1.DataSource = dataTable;
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = dataGridView1.Size.Width / dataTable.Columns.Count;
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }
    }
}
