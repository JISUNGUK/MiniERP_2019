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
        
        
        public Frm_PrintDisplay()
        {
            InitializeComponent();
            saveFileDialog1.FileName = DateTime.Today.ToShortDateString() + "_Barcodes";

            for (int i = 1; i < 43; i++)
            {
                combo_Count.Items.Add(i);
            }            
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
                    pictureBox1.Image = barcode.MakeBarcode(item.Item_code, true, new Size(300, 50));
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
        /// <summary>
        /// 바코드 이미지 내보냅니다.
        /// 출력 경로 지정할 것.
        /// </summary>
        private void btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("바코드를 선택하여 주세요");
                    return;
                }               //  이미지 예외분기
                if (Int32.Parse(combo_Count.Text) > 43)
                {
                    MessageBox.Show("42개 이상불가능합니다.");
                    return;
                }      //  카운트 예외분기
                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                #region 이미지 이어붙이기
                Bitmap A4 = new Bitmap(1240, 1754);    //  a4 용지 크기
                Size size = pictureBox1.Image.Size;
                Image img = pictureBox1.Image;

                Graphics g = Graphics.FromImage(A4);
                int y = 0; int x = 0;
                for (int i = 0; i < Int32.Parse(combo_Count.Text); i++)
                {
                    //  한 줄에 16개씩 찍히도록..
                    if (i == 14)
                    { x += 400; y = 0; }
                    else if (i == 28)
                    { x += 400; y = 0; }
                    else if (i == 42)       //  3줄 ,갯수 42개 끝
                    { x += 400; y = 0; }

                    g.DrawImage(img, x, y, size.Width, size.Height);
                    y += 130;
                }
                
                A4.Save(saveFileDialog1.FileName);
                MessageBox.Show("완료"); 
                #endregion
            }
            catch (Exception)
            {
                MessageBox.Show("숫자만 입력해주세요");
            }
        }
    }
}
