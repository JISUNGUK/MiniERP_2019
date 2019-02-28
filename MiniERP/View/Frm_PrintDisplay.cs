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
namespace MiniERP.View
{
    public partial class Frm_PrintDisplay : Form
    {
        Barcode_Module barcode = new Barcode_Module();
        List<Item> items = new List<Item>();
        Item selectItem;
        
        public Frm_PrintDisplay()
        {
            InitializeComponent();
        }

        private void Frm_PrintDisplay_Load(object sender, EventArgs e)
        {
            items = new ItemDAO().GetItems("");
            Display();
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
                dataGridView1.Columns[i].Width = dataGridView1.Size.Width / dataGridView1.Columns.Count-1;
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (var item in items)
            {
                if (item.Item_code == dataGridView1.SelectedRows[0].Cells["아이템코드"].Value.ToString())
                {
                    pictureBox1.Image = null;
                    pictureBox1.Image = barcode.MakeBarcode(item.Item_code, true, new Size(300, 30));
                    break;
                }
                
            }
        }
        

        private void btn_Search_Click(object sender, EventArgs e)
        {
            items = new ItemDAO().GetItems(txt_Search.Text);
            Display();
        }

        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Search_Click(null, null);
            }
        }
    }
}
