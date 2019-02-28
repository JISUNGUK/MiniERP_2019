using MiniERP.Model.DAO;
using MiniERP.VO;
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
    public partial class Frm_BomDetail : Form
    {
        private string itemCode;
        private string itemName;
        private List<BOM> boms; // 아이템에 대한 파츠의 코드, 이름, 소요량을 저장할 리스트입니다.

        public Frm_BomDetail()
        {
            InitializeComponent();
        }

        public Frm_BomDetail(string itemCode, string itemName) : this()
        {
            this.itemCode = itemCode;
            this.itemName = itemName;
        }

        private void Frm_BomDetail_Load(object sender, EventArgs e)
        {
            boms = new BomDAO().GetBomDetail(itemCode);
            txtCodeName.Text = itemCode + "(" + itemName + ")";
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = dataGridView1.Size.Width / dataGridView1.Columns.Count;
            }
            foreach (var item in boms)
            {
                dataGridView1.Rows.Add(item.Part_code, item.Part_name, item.Part_count);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["Column3"].Value = boms[i].Part_count * Int32.Parse(mTxtNum.Text);
            }
        }

        private void mTxtNum_Click(object sender, EventArgs e)
        {
            mTxtNum.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mTxtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnApply_Click(null, null);
            }
        }
    }
}
