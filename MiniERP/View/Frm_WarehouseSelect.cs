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
using MiniERP;

namespace MiniERP.View
{
    public partial class Frm_WarehouseSelect : Form
    {
        private List<Warehouse> warehouses; // 모든 창고(공장) 목록을 저장할 리스트입니다.
        private Warehouse warehouse; // 선택한 창고(공장)을 저장할 객체입니다.

        public Warehouse Warehouse { get => warehouse; set => warehouse = value; }

        public Frm_WarehouseSelect()
        {
            InitializeComponent();
        }
        public Frm_WarehouseSelect(Warehouse warehouse) : this()
        {
            this.warehouse = warehouse;
        }

        private void Frm_WarehouseSelect_Load(object sender, EventArgs e)
        {
            if (warehouse == null)
            {
                warehouses = new WarehouseDAO().GetWarehouses(new Warehouse());
            }
            else
            {
                warehouses = new WarehouseDAO().GetWarehouses(warehouse);
            }
            Display();
        }

        /// <summary>
        /// 현재 class의 리스트를 이용해 DataGridView에 내용을 출력합니다.
        /// </summary>
        private void Display()
        {
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

            Display();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }
    }
}
