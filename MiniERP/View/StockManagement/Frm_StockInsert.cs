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
        public Frm_StockInsert()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("창고코드를 입력해주세요.", "창고코드를 입력하지 않았습니다.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Focus();
            }
            else if (new WarehouseDAO().CheckWarehouseData(txtCode.Text))
            {
                MessageBox.Show("이미 존재하는 창고코드입니다.\n다른 창고코드를 입력해주세요.", "창고코드 중복", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Focus();
            }
            else if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("창고명을 입력해주세요.", "창고명을 입력하지 않았습니다.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else
            {
                string standard = "";
                if (rdoWarehouse.Checked == true)
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

                if (new WarehouseDAO().InsertWarehouse(wh) != 0)
                {
                    MessageBox.Show("새로운 창고(공장)을 등록했습니다.", "등록 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("등록에 실패했습니다.", "등록 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCode.Text = txtName.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
