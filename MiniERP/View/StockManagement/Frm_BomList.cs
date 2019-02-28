using MiniERP.Model.DAO;
using MiniERP.View.LogisticsManagement;
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
    public partial class Frm_BomList : Form
    {
        private List<BOM> boms; // DataGridView에 출력될 Bom의 내용을 저장할 리스트 입니다.

        private bool boxchk = true;

        public Frm_BomList()
        {
            InitializeComponent();
        }

        private void Frm_BomList_Click(object sender, EventArgs e)
        {
            txtItemCode.Clear();
        }

        private void Frm_BomList_Load(object sender, EventArgs e)
        {
            Display(new BOM());
        }

        /// <summary>
        /// DataGridView의 내용을 지우고 Bom테이블의 내용을 다시 읽어와서 DataGridView에 채워넣습니다.
        /// </summary>
        /// <param name="bom"></param>
        private void Display(BOM bom)
        {
            boms = new BomDAO().GetBoms(bom);
            for (int i = 0; i < dataGridView1.Columns.Count - 1; i++)
            {
                dataGridView1.Columns[i].Width = (dataGridView1.Size.Width - 40) / dataGridView1.Columns.Count - 1;
            }
            dataGridView1.Rows.Clear();
            foreach (var item in boms)
            {
                dataGridView1.Rows.Add(item.Item_code, item.Item_name, "조회");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Column3"].Index)
            {
                Frm_BomDetail fbd = new Frm_BomDetail(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value.ToString());
                fbd.ShowDialog();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Frm_BomInesrt fbi = new Frm_BomInesrt();
            fbi.ShowDialog();
            Display(new BOM());
        }

        private void btnSearch_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택한 행의 내용을 삭제하시겠습니까?", "선택 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    new BomDAO().DeleteBom(dataGridView1.SelectedRows[0].Cells["Column1"].Value.ToString());
                    MessageBox.Show("삭제되었습니다.", "삭제 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Display(new BOM());
                }
                catch (Exception)
                {
                    MessageBox.Show("해당 물품은 다른 제품을 생산할 때 필요한 아이템입니다.\n상위 물품을 먼저 삭제해주세요.", "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnItemSearch_Click(object sender, EventArgs e)
        {
            Frm_ItemSelect fis = new Frm_ItemSelect();
            if (fis.ShowDialog() == DialogResult.OK)
            {
                txtItemCode.Text = fis.SelectItem.Item_code;
            }
        }

        private void btnPartSearch_Click(object sender, EventArgs e)
        {
            Frm_ItemSelect fis = new Frm_ItemSelect();
            if (fis.ShowDialog() == DialogResult.OK)
            {
                txtPartCode.Text = fis.SelectItem.Item_code;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            pnl_serchbox.Visible = false;
            Display(new BOM
            {
                Item_code = txtItemCode.Text,
                Part_code = txtPartCode.Text
            });
        }

        private void txtCodeOrName_Click(object sender, EventArgs e)
        {
            txtCodeOrName.Text = "";
        }

        private void txtCodeOrName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                boms = new BomDAO().GetBomSimple(txtCodeOrName.Text);
                for (int i = 0; i < dataGridView1.Columns.Count - 1; i++)
                {
                    dataGridView1.Columns[i].Width = (dataGridView1.Size.Width - 40) / dataGridView1.Columns.Count - 1;
                }
                dataGridView1.Rows.Clear();
                foreach (var item in boms)
                {
                    dataGridView1.Rows.Add(item.Item_code, item.Item_name, "조회");
                }
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Frm_BomUpdate fbu = new Frm_BomUpdate(new BOM()
            {
                Item_code = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),
                Item_name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()
            });
            fbu.ShowDialog();
            if (fbu.DialogResult1 == DialogResult.Yes)
            {
                Display(new BOM());
            }
        }
    }
}
