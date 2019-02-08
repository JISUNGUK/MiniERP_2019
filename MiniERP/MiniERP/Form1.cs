using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP
{
    public partial class Form1 : Form
    {
        //private MdiClient mdi = new MdiClient();
        
        public Form1()
        {
            InitializeComponent();      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //mdi.Controls.Add(panel_Mdi);
        }

        private void tsm_OrdM_inquiry_Click(object sender, EventArgs e)
        {
            OpenForm(sender);
        }

        private void OpenForm(object menuName)
        {
            CloseForm(menuName);
            switch (menuName.ToString())
            {
                case "주문 조회":
                    { 
                    Frm_OrderList orderList= new Frm_OrderList();                       
                        orderList.MdiParent = this;
                        orderList.Dock = DockStyle.Fill;
                        panel_Mdi.Controls.Add(orderList);
                    orderList.Show();                     
                    break;
                    }
                case "기초등록":
                                
                    break;
                case "견적서 조회":
                    Frm_LogisticsList logisticsList = new Frm_LogisticsList();
                    logisticsList.MdiParent = this;
                    logisticsList.Dock = DockStyle.Fill;
                    panel_Mdi.Controls.Add(logisticsList);
                    logisticsList.Show();
                    break;
                case "구매조회":

                    break;
                case "매입매출거래":

                    break;
            }
           
        }

        private void CloseForm(object test)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void 견적서조회ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenForm(sender);
        }

        private void BomGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Bomtree bt = new Bomtree();
            bt.MdiParent = this;
            bt.Show();
        }
    }
}
