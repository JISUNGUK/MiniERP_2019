using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniERP.Model;
using MiniERP.Model.DAO;
using MiniERP.VO;

namespace MiniERP.View.StockManagement
{
    public partial class Frm_WarehouseMovement : Form
    {
        public Frm_WarehouseMovement()
        {
            InitializeComponent();
        }

        List<Warehouse> warehouses = new List<Warehouse>();
        private void Frm_WarehouseMovement_Load(object sender, EventArgs e)
        {
            dt_moveDate.MinDate = DateTime.Now;
            SettingCombo();
        }

        private void SettingCombo()
        {
            WarehouseDAO warehouseDAO = new WarehouseDAO();
            warehouses = warehouseDAO.GetWarehouses(new Warehouse());
            foreach (var item in warehouses)
            {
                cmb_before.Items.Add(item.Warehouse_name);
            }
        }

        private void cmb_before_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv_afterStock.Items.Clear();
            lv_beforeStock.Items.Clear();
        }

        private void cmb_after_DropDown(object sender, EventArgs e)
        {
            cmb_after.Items.Clear();
            foreach (var item in cmb_before.Items)
            {
                if (item.ToString() != cmb_before.SelectedItem.ToString())
                {
                    cmb_after.Items.Add(item.ToString());
                }
            }
        }
    }
}
