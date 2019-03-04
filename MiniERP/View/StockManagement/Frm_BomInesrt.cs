using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniERP.Model.DAO;
using MiniERP.VO;

namespace MiniERP.View.StockManagement
{
    public partial class Frm_BomInesrt : Form
    {
        private DialogResult dialogResult = DialogResult.None; // 등록하기 버튼을 누른 후 예를 눌렀는지 아니오를 눌렀는지 판별하기 위한 변수입니다.

        public DialogResult DialogResult1 { get => dialogResult; set => dialogResult = value; }

        public Frm_BomInesrt()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 추가되는 파츠를 그리드뷰에 더해주는 메서드입니다. 이미 추가되어 있다면 추가되지 않습니다.
        /// </summary>
        /// <param name="item">추가하고자 하는 아이템 객체입니다.</param>
        private void SetGridView(Item item)
        {
            bool check = true;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value.ToString() == item.Item_code)
                {
                    check = false;
                    break;
                }
            }

            if (check)
            {
                dataGridView1.Rows.Add(false, item.Item_code, item.Item_name, 0);
            }
        }

        private void Frm_BomInesrt_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = dataGridView1.Size.Width  / dataGridView1.Columns.Count - 1;
            }
        }

        private void btn_ItemAdd_Click(object sender, EventArgs e)
        {
            Frm_ItemSelect frm = new Frm_ItemSelect();
            if (frm.ShowDialog() != DialogResult.Cancel)
            {
                Item item = frm.SelectItem;
                SetGridView(item);
            }
        }

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            int num = dataGridView1.Rows.Count;
            for (int i = num; i > 0; i--)
            {
                if ((bool)dataGridView1.Rows[i - 1].Cells[0].Value)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i - 1]);
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("품목코드를 입력해주세요.", "품목코드를 입력하지 않았습니다.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("파츠를 1개 이상 등록해주세요.", "파츠가 등록되지 않았습니다.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool result = true; // 파츠의 개수가 0으로 된 행이 있는지 판별하기 위한 bool변수입니다.
                int i = 0;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (int.TryParse(item.Cells[3].Value.ToString(), out i) == true)
                    {
                        if (Convert.ToInt32(item.Cells[3].Value) == 0)
                        {
                            MessageBox.Show("필요수량이 0인 항목이 있습니다.\n확인하시고 필요없다면 삭제해주세요.", "필요수량 확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            result = false;
                            return;
                        } 
                    }
                    else
                    {
                        MessageBox.Show("필요수량에는 숫자만 입력가능합니다.", "입력값을 확인해주세요.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                
                if(result && MessageBox.Show("BOM을 등록하시겠습니까?", "BOM 등록", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string itemCode = txtCode.Text;
                    string partCode = String.Empty; // 파츠의 코드(구분 문자열 : |)
                    string partCount = String.Empty; // 파츠의 개수(구분 문자열 : |)

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        partCode += row.Cells[1].Value.ToString() + "|";
                        partCount += row.Cells[3].Value.ToString() + "|";
                    }
                    partCode = partCode.Substring(0, partCode.Length - 1);
                    partCount = partCount.Substring(0, partCount.Length - 1);

                    if (new BomDAO().InsertBom(itemCode, partCode, partCount) != 0)
                    {
                        MessageBox.Show("새로운 품목의 BOM을 등록했습니다.", "등록 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dialogResult = DialogResult.Yes;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("등록에 실패했습니다.", "등록 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_ItemSelect_Click(object sender, EventArgs e)
        {
            Frm_ItemSelect fis = new Frm_ItemSelect();
            if (fis.ShowDialog() == DialogResult.OK)
            {
                txtCode.Text = fis.SelectItem.Item_code;
            }
        }
    }
}
