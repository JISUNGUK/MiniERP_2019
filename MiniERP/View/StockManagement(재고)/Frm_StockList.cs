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

namespace MiniERP.View.StockManagement
{
    public partial class Frm_StockList : Form
    {
        List<Warehouse> warehouses;

        private bool boxchk = true;

        /// <summary>
        /// DataGridView의 내용을 최신화합니다.
        /// </summary> 작성자 : 이상권
        private void ReflashData()
        {
            warehouses.Clear();
            dataGridView1.DataSource = null;

            warehouses = new WarehouseDAO().GetWarehouses();
            dataGridView1.DataSource = warehouses;
            dataGridView1.Columns[0].HeaderText = "창고코드";
            dataGridView1.Columns[1].HeaderText = "창고명";
            dataGridView1.Columns[2].HeaderText = "창고구분";
        }

        public Frm_StockList()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_serch_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_StockInsert stockInsert = new Frm_StockInsert(warehouses);
            stockInsert.ShowDialog();
            ReflashData();
        }

        private void Frm_StockList_Load(object sender, EventArgs e)
        {
            warehouses = new WarehouseDAO().GetWarehouses();
            dataGridView1.DataSource = warehouses;
            dataGridView1.Columns[0].HeaderText = "창고코드";
            dataGridView1.Columns[1].HeaderText = "창고명";
            dataGridView1.Columns[2].HeaderText = "창고구분";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택된 창고(공장)을 삭제하시겠습니까?", "선택삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (var item in warehouses)
                {
                    if (item.Warehouse_code == dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
                    {
                        new WarehouseDAO().DeleteWarehouse(item.Warehouse_code);
                        break;
                    }
                }
                ReflashData();
            }
        }
    }
}
