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
using MiniERP.VO;
using MiniERP.View.StockManagement;

namespace MiniERP.View
{
    public partial class Frm_ItemSelect : Form
    {
        private List<Item> items;
        private Item selectItem;

        internal Item SelectItem { get => selectItem; set => selectItem = value; }

        public Frm_ItemSelect()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 현재 클래스의 List를 이용해 DataGridView에 내용을 출력합니다.
        /// </summary>
        private void Display()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] dataColumns = new DataColumn[4]
            {
                new DataColumn("아이템코드"),
                new DataColumn("아이템명"),
                new DataColumn("규격"),
                new DataColumn("단위")
            };
            dataTable.Columns.AddRange(dataColumns);
            foreach (var item in items)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["아이템코드"] = item.Item_code;
                dataRow["아이템명"] = item.Item_name;
                dataRow["규격"] = item.Item_standard;
                dataRow["단위"] = item.Item_unit;
                dataTable.Rows.Add(dataRow);
            }

            dataGridView1.DataSource = dataTable;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = dataGridView1.Size.Width / dataGridView1.Columns.Count;
            }
        }

        private void Frm_ItemSelect_Load(object sender, EventArgs e)
        {
            items = new ItemDAO().GetItems("");
            Display();
        }

        private void txtCodeOrName_Click(object sender, EventArgs e)
        {
            txtCodeOrName.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            items = new ItemDAO().GetItems(txtCodeOrName.Text);
            Display();
        }

        private void txtCodeOrName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            foreach (var item in items)
            {
                if (item.Item_code == dataGridView1.SelectedRows[0].Cells["아이템코드"].Value.ToString())
                {
                    selectItem = new Item()
                    {
                        Item_code = item.Item_code,
                        Item_name = item.Item_name,
                        Item_standard = item.Item_standard,
                        Item_unit = item.Item_unit,
                        Item_class = item.Item_class,
                        Item_fee = item.Item_fee,
                        Stock_count = item.Stock_count,
                        Item_group = item.Item_group,
                        Item_comment = item.Item_comment
                    };
                    break;
                }
            }
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택한 아이템을 삭제하시겠습니까?", "아이템 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    new ItemDAO().DeleteItem(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    MessageBox.Show("선택된 아이템이 삭제되었습니다.", "삭제 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    items = new ItemDAO().GetItems("");
                    Display();
                }
                catch (Exception)
                {
                    MessageBox.Show("선택된 아이템의 재고가 있습니다.\n삭제할 수 없습니다.", "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Frm_ItemInfo fii = new Frm_ItemInfo(new ItemDAO().GetItemByCode(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            fii.ShowDialog();
        }
    }
}
