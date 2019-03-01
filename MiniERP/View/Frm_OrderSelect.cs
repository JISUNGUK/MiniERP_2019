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
    public partial class Frm_OrderSelect : Form
    {
        private List<Ordered> orders;
        private Ordered selectorder;

        internal Ordered SelectOrder { get => selectorder; set => selectorder = value; }

        public Frm_OrderSelect()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 현재 클래스의 List를 이용해 DataGridView에 내용을 출력합니다.
        /// </summary>
        private void Display()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] dataColumns = new DataColumn[3]
            {
                new DataColumn("주문코드"),
                new DataColumn("거래처코드"),
                new DataColumn("거래처명")
            };
            dataTable.Columns.AddRange(dataColumns);
            foreach (var order in orders)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["주문코드"] = order.Order_Code;
                dataRow["거래처코드"] = order.Business_Code;
                dataRow["거래처명"] = order.Business_name;
                dataTable.Rows.Add(dataRow);
            }

            dataGridView1.DataSource = dataTable;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = dataGridView1.Size.Width / dataGridView1.Columns.Count;
            }
        }



       

        private void btnApply_Click(object sender, EventArgs e)
        {
            foreach (var order in orders)
            {
                if (order.Order_Code == dataGridView1.SelectedRows[0].Cells["아이템코드"].Value.ToString())
                {
                    selectorder = new Ordered()
                    {
                        Order_Code = order.Order_Code,
                        Business_Code= order.Business_Code,
                        Business_name = order.Business_name
                        
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

        private void Frm_OrderSelect_Load(object sender, EventArgs e)
        {
            orders = new OrderedDAO().SelectAllOrdered();
            Display();
        }
    }
}
