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
        /// </summary> 
        private void ReflashData()
        {
            warehouses.Clear();
            dataGridView1.DataSource = null;

            warehouses = new WarehouseDAO().GetWarehouses(new Warehouse());
            Display(warehouses);
        }

        /// <summary>
        /// 매개변수로 받은 List를 이용해 DataGridView에 내용을 출력합니다.
        /// </summary>
        /// <param name="listWarehouse">DataGridView에 출력될 내용을 저장하고 있는 List입니다.</param>
        private void Display(List<Warehouse> listWarehouse)
        {
            dataGridView1.DataSource = listWarehouse;
            dataGridView1.Columns[0].HeaderText = "창고코드";
            dataGridView1.Columns[1].HeaderText = "창고명";
            dataGridView1.Columns[2].HeaderText = "창고구분";
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = dataGridView1.Size.Width / dataGridView1.Columns.Count;
            }
        }

        public Frm_StockList()
        {
            InitializeComponent();
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
            rdoAll.Checked = true;
        }

        private void Frm_StockList_Load(object sender, EventArgs e)
        {
            warehouses = new WarehouseDAO().GetWarehouses(new Warehouse());
            Display(warehouses);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택된 창고(공장)을 삭제하시겠습니까?", "선택삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    new WarehouseDAO().DeleteWarehouse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    MessageBox.Show("삭제되었습니다.", "삭제 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReflashData();
                }
                catch (Exception)
                {
                    MessageBox.Show("현재 사용되고 있는 창고(공장)입니다. 삭제할 수 없습니다.", "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string standard = "";
            if (rdoAll.Checked == true)
            {
                standard = "";
            }
            else if(rdoWarehouse.Checked == true)
            {
                standard = "창고";
            }
            else
            {
                standard = "공장";
            }

            Warehouse warehouse = new Warehouse
            {
                Warehouse_code = txtCode.Text,
                Warehouse_name = txtName.Text,
                Warehouse_standard = standard
            };
            selectWarehouses = new WarehouseDAO().GetWarehouses(warehouse);
            pnl_serchbox.Visible = false;
            Display(selectWarehouses);
        }

        private void txtCodeOrName_Click(object sender, EventArgs e)
        {
            txtCodeOrName.Text = "";
        }

        private void txtCodeOrName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Warehouse warehouse = new Warehouse
                {
                    Warehouse_name = txtCodeOrName.Text
                };

                selectWarehouses = new WarehouseDAO().GetWarehouses(warehouse);

                Display(selectWarehouses);
            }
        }

        private void btnSearchWarehouse_Click(object sender, EventArgs e)
        {
            Frm_WarehouseSelect fws = new Frm_WarehouseSelect();
            
            if (fws.ShowDialog() == DialogResult.OK)
            {
                txtCode.Text = fws.Warehouse.Warehouse_code;
                txtName.Text = fws.Warehouse.Warehouse_name;
                if (fws.Warehouse.Warehouse_standard == "창고")
                {
                    rdoWarehouse.Checked = true;
                    rdoFactory.Checked = false;
                }
                else
                {
                    rdoWarehouse.Checked = false;
                    rdoFactory.Checked = true;
                }
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Frm_WarehouseUpdate fwu = new Frm_WarehouseUpdate(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                fwu.ShowDialog();
                if (fwu.DialogResult1 == DialogResult.Yes)
                {
                    ReflashData();
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Frm_StockInsert stockInsert = new Frm_StockInsert();
            stockInsert.ShowDialog();
            ReflashData();
        }
    }
}
