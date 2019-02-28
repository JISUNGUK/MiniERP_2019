using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniERP.Model.DAO;
using MiniERP.VO;

namespace MiniERP.View.StockManagement
{
    public partial class Frm_BomUpdate : Form
    {
        private List<BOM> boms; // DataGridView에 출력할 파츠의 코드, 이름, 소요량을 저장할 리스트입니다.
        private BOM bom; // 부모폼으로부터 받아오는 bom객체입니다.
        private DialogResult dialogResult = DialogResult.None; // 수정버튼을 누른 뒤 '예'를 눌렀는지 '아니오'를 눌렀는지 판별하기위한 변수입니다.

        public DialogResult DialogResult1 { get => dialogResult; set => dialogResult = value; }

        public Frm_BomUpdate()
        {
            InitializeComponent();
        }

        public Frm_BomUpdate(BOM bom) : this()
        {
            this.bom = bom;
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

        private void Frm_BomUpdate_Load(object sender, EventArgs e)
        {
            txtCode.Text = bom.Item_code + "(" + bom.Item_name + ")";
            boms = new BomDAO().GetBomDetail(bom.Item_code);
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = (dataGridView1.Size.Width - 40) / dataGridView1.Columns.Count - 1;
            }
            foreach (var item in boms)
            {
                dataGridView1.Rows.Add(false, item.Part_code, item.Part_name, item.Part_count);
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

        private void btn_ItemAdd_Click(object sender, EventArgs e)
        {
            Frm_ItemSelect frm = new Frm_ItemSelect();
            if (frm.ShowDialog() != DialogResult.Cancel)
            {
                Item item = frm.SelectItem;
                SetGridView(item);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("파츠를 1개 이상 등록해주세요.", "파츠가 등록되지 않았습니다.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool result = true; // 파츠의 개수가 0으로 된 행이 있는지 판별하기 위한 bool변수입니다.
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (Convert.ToInt32(item.Cells[3].Value) == 0)
                    {
                        MessageBox.Show("필요수량이 0인 항목이 있습니다.\n확인하시고 필요없다면 삭제해주세요.", "필요수량 확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        result = false;
                        return;
                    }
                }
                if (result && MessageBox.Show("BOM을 수정하시겠습니까?", "BOM 수정", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string itemCode = bom.Item_code;
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
                        MessageBox.Show("BOM을 수정했습니다.", "수정 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult1 = DialogResult.Yes;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("수정에 실패했습니다.", "수정 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
