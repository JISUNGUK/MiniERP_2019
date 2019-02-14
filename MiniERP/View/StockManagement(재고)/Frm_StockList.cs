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
        List<Warehouse> warehouses; // 모든 창고(공장)이 저장되어있는 리스트입니다.
        List<Warehouse> selectWarehouses; // 검색 조건에 맞는 창고(공장)이 저장되어있는 리스트입니다.

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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectWarehouses = new List<Warehouse>();

            foreach (var item in warehouses)
            {
                if ((chkWarehouse.Checked == true) && (chkFactory.Checked == false))
                {
                    if (item.Warehouse_code.Contains(txtCode.Text) && item.Warehouse_name.Contains(txtName.Text) && item.Warehouse_standard.Contains(chkWarehouse.Text))
                    {
                        selectWarehouses.Add(item);
                    }
                }
                else if ((chkWarehouse.Checked == false) && (chkFactory.Checked == true))
                {
                    if (item.Warehouse_code.Contains(txtCode.Text) && item.Warehouse_name.Contains(txtName.Text) && item.Warehouse_standard.Contains(chkFactory.Text))
                    {
                        selectWarehouses.Add(item);
                    }
                }
                else if((chkWarehouse.Checked == true) && (chkFactory.Checked == true))
                {
                    if (item.Warehouse_code.Contains(txtCode.Text) && item.Warehouse_name.Contains(txtName.Text) && (item.Warehouse_standard.Contains(chkWarehouse.Text) || item.Warehouse_standard.Contains(chkFactory.Text)))
                    {
                        selectWarehouses.Add(item);
                    }
                }
            }
            pnl_serchbox.Visible = false;
            dataGridView1.DataSource = selectWarehouses;
        }

        private void txtCodeOrName_Click(object sender, EventArgs e)
        {
            txtCodeOrName.Text = "";
        }

        private void txtCodeOrName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                selectWarehouses = new List<Warehouse>();
                foreach (var item in warehouses)
                {
                    if (item.Warehouse_code.Contains(txtCodeOrName.Text) || item.Warehouse_name.Contains(txtCodeOrName.Text))
                    {
                        selectWarehouses.Add(item);
                    }
                }
            }
            dataGridView1.DataSource = selectWarehouses;
        }
    }
}
