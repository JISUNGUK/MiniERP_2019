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

/* 구현: 조성호
 * 반품 입고창고 선택 폼
 * 완료일: 2019-03-01
 */
namespace MiniERP.View.TradeManagement
{
    public partial class Frm_ReturnWarehouseSelect : Form
    {
        public Frm_ReturnWarehouseSelect()
        {
            InitializeComponent();
        }
        private Warehouse warehouse;
        public Warehouse Warehouse { get => warehouse;}

        private List<Warehouse> warehouses;
        private void Frm_ReturnWarehouseSelect_Load(object sender, EventArgs e)
        {
            SetComboData();
        }

        private void SetComboData()
        {

            WarehouseDAO dao = new WarehouseDAO();
            warehouses = dao.GetWarehouses(new Warehouse());
            foreach (var item in warehouses)
            {
                cmb_Warehouse.Items.Add(item.Warehouse_name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if(cmb_Warehouse.SelectedIndex != -1)
            {
                foreach (var item in warehouses)
                {
                    if(item.Warehouse_name != cmb_Warehouse.SelectedItem.ToString())
                    {
                        continue;
                    }
                    else
                    {
                        warehouse = item;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("입고창고를 입력하셔야합니다.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
