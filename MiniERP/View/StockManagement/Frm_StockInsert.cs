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
    public partial class Frm_StockInsert : Form
    {
        private List<Warehouse> warehouses;

        /// <summary>
        /// 등록하려는 Warehouse_code가 이미 존재하는지 확인합니다.
        /// </summary>
        /// <param name="warehouseCode">저장하려는 warehouse_code입니다.</param>
        /// <returns>등록하려는 Warehouse_code가 이미 존재하면 true, 그렇지 않으면 false를 반환합니다.</returns>
        private bool CheckWarehousecode(string warehouseCode)
        {
            bool result = false;

            foreach (var item in warehouses)
            {
                if (item.Warehouse_code == warehouseCode)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public Frm_StockInsert()
        {
            InitializeComponent();
        }

        public Frm_StockInsert(List<Warehouse> warehouses) : this()
        {
            this.warehouses = warehouses;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("창고코드를 입력하지 않았습니다.");
                txtCode.Focus();
            }
            else if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("창고명을 입력하지 않았습니다.");
                txtName.Focus();
            }
            else
            {
                if (CheckWarehousecode(txtCode.Text))
                {
                    MessageBox.Show("이미 존재하는 창고코드입니다. 다른 창고코드를 입력해주세요.");
                    txtCode.Focus();
                }
                else
                {
                    string standard = "";
                    if (rdoWarehouse.Checked)
                    {
                        standard = rdoWarehouse.Text;
                    }
                    else
                    {
                        standard = rdoFactory.Text;
                    }
                    Warehouse wh = new Warehouse
                    {
                        Warehouse_code = txtCode.Text,
                        Warehouse_name = txtName.Text,
                        Warehouse_standard = standard
                    };

                    if (new WarehouseDAO().InsertWarehouse(wh))
                    {
                        MessageBox.Show("새로운 창고(공장)을 등록했습니다.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("등록에 실패했습니다.");
                    }
                }
            }
        }
    }
}
