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
    public partial class Frm_WarehouseUpdate : Form
    {
        private string code; // 창고(공장)코드
        private string name; // 창고(공장)명
        private string standard; // 구분 - 창고or공장
        private DialogResult dialogResult = DialogResult.None; // 수정하기 버튼을 누른 후 예를 눌렀는지 아니오를 눌렀는지 판별하기 위한 변수입니다.

        public DialogResult DialogResult1 { get => dialogResult; set => dialogResult = value; }

        public Frm_WarehouseUpdate()
        {
            InitializeComponent();
        }

        public Frm_WarehouseUpdate(string code, string name, string standard) : this()
        {
            this.code = code;
            this.name = name;
            this.standard = standard;
        }

        private void Frm_WarehouseUpdate_Load(object sender, EventArgs e)
        {
            lblCode.Text = code;
            txtName.Text = name;
            if (standard == "창고")
            {
                rdoWarehouse.Checked = true;
            }
            else
            {
                rdoFactory.Checked = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string selectStandard = "";
            if (rdoWarehouse.Checked)
            {
                selectStandard = "창고";
            }
            else
            {
                selectStandard = "공장";
            }
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("창고(공장)명을 입력해주세요.", "창고(공장)명 공백", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else
            {
                if (MessageBox.Show("수정하시겠습니까?", "수정 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        new WarehouseDAO().UpdateWarehouse(new Warehouse()
                        {
                            Warehouse_code = lblCode.Text,
                            Warehouse_name = txtName.Text,
                            Warehouse_standard = selectStandard
                        });
                        MessageBox.Show("수정되었습니다.", "수정 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dialogResult = DialogResult.Yes;
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("수정에 실패했습니다.", "수정 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
