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

namespace MiniERP.View
{
    public partial class FrmDashBoard : Form
    {
        //private bool menu_OpenChk = false;

        List<Trade> trades = new List<Trade>();

        public FrmDashBoard()
        {
            InitializeComponent();
            lbl_ToDay.Text = "오늘은 " + DateTime.Today.ToShortDateString() + " 입니다.";
            TradeListShow();
        }

        /// <summary>
        /// 트레이드 리스트 다시그립니다.
        /// </summary>
        public void TradeListShow()
        {
            trades.Clear();
            trades = GetTreade();
            ControlAdd(trades);
        }
         /// <summary>
        /// '판매' 거래에대한 정보를 리스트에 초기화
        /// </summary>
        private List<Trade> GetTreade()
        {
            TradeDAO tradeDAO = new TradeDAO();
            return tradeDAO.GetProgTrade("판매");
        }

        /// <summary>
        /// 거래리스트에 있는 모든 정보에 대한 컨트롤을 동적생성합니다.
        /// </summary>
        private void ControlAdd(List<Trade> list)
        {
            panel_TradeList.Controls.Clear();

            int x = 11; int y = 5;
            foreach (var item in list)
            {
                ToDoList temp = new ToDoList(item,split.Panel2,this);
                temp.Location = new Point(x, y);
                y += 48;

                panel_TradeList.Controls.Add(temp);
                temp.Show();
            }
        }

        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            panel1.AutoScroll = true;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = "현재시간 : " + DateTime.Now.ToLongTimeString();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            TradeListShow();
        }
    }
}
