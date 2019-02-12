using MiniERP.View.BusinessManagement;
using MiniERP.View.LogisticsManagement;
using MiniERP.View.SalesPurchaseManagement;
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

namespace MiniERP.View
{
    public partial class Form1 : Form
    {
        private Panel panel_mdi;
        private bool tabChk = true;

        private Point imageLocation = new Point(10, 5);
        private Point imageHitArea = new Point(10, 5);
        Image CloseIcon;

        public Form1()
        {
            InitializeComponent();      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void OpenForm(object menuName)
        {
            if (tabControl1.TabCount <= 10)
            {
                if (!tabChk) // 최초실행시 탭생성 실행
                {
                    bool test = true;
                    for (int i = 0; i < tabControl1.TabCount; i++)
                    {
                        // 폼 생성 중복검사
                        if (tabControl1.TabPages[i].Name == menuName.ToString())
                        {
                            tabControl1.SelectedTab = tabControl1.TabPages[menuName.ToString()];
                            test = false;
                            break;
                        }
                    }
                    if (test)
                    {
                        // 2번째이상부턴 여기서 폼 생성
                        tabChk = true;
                        tabControl1.SelectedTab = tabControl1.TabPages[menuName.ToString()];
                        OpenForm(menuName);
                    }

                }
                else
                {
                    // 최초생성
                    FormSwich(menuName);
                } 
            }
            else
            {
                MessageBox.Show("탭은 10개까지만 생성할 수 있습니다.");
            }
        }

        /// <summary>
        /// 탭 페이지와 판넬을 생성하고 MDI로 폼까지 호출 시켜주는 메서드
        /// </summary>
        /// <param name="menuName"> 메뉴에서 클릭한 버튼의 sender을 매개변수로 받아와 사용</param>
        private void FormSwich(object menuName)
        {
            switch (menuName.ToString())
            {
                case "주문 조회":
                    {
                        #region 판넬생성 -> 탭페이지생성 -> 탭페이지.컨트롤.넣기(판넬)
                        panel_mdi = new Panel();
                        panel_mdi.Name = "testno1";
                        tabControl1.TabPages.Add(menuName.ToString(), menuName.ToString());
                        tabControl1.TabPages[menuName.ToString()].Controls.Add(panel_mdi);
                        tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].Dock = DockStyle.Fill;
                        tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].BackColor = Color.AliceBlue;

                        
                        
                        #endregion

                        #region 판넬에 넣을 폼 객체 생성 -> 폼 스타일 설정 -> 판넬에 폼을 MDI 로 출력
                        Frm_OrderList orderList = new Frm_OrderList();
                        orderList.ControlBox = false; // 컨트롤 상자 없애기
                        orderList.FormBorderStyle = FormBorderStyle.None; // 폼 테투리 삭제
                        orderList.MdiParent = this; // MDI 설정
                        orderList.Dock = DockStyle.Fill; // Dock 스타일 설정 Fill
                        panel_mdi.Controls.Add(orderList); // 판넬에 설정한 폼 넣기
                        orderList.Show();  // 폼 실행
                        #endregion
                        tabChk = true; // 중복확인용 bool 타입
                        break;
                    }
              
                case "견적서 조회":
                    {
                        #region 판넬생성 -> 탭페이지생성 -> 탭페이지.컨트롤.넣기(판넬)
                        panel_mdi = new Panel();
                        panel_mdi.Name = "testno1";
                        tabControl1.TabPages.Add(menuName.ToString(), menuName.ToString());
                        tabControl1.TabPages[menuName.ToString()].Controls.Add(panel_mdi);
                        tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].Dock = DockStyle.Fill;
                        tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].BackColor = Color.AliceBlue;
                        #endregion

                        #region 판넬에 넣을 폼 객체 생성 -> 폼 스타일 설정 -> 판넬에 폼을 MDI 로 출력
                        Frm_EstimateList estimateList = new Frm_EstimateList();
                        estimateList.ControlBox = false; // 컨트롤 상자 없애기
                        estimateList.FormBorderStyle = FormBorderStyle.None; // 폼 테투리 삭제
                        estimateList.MdiParent = this; // MDI 설정
                        estimateList.Dock = DockStyle.Fill; // Dock 스타일 설정 Fill
                        panel_mdi.Controls.Add(estimateList); // 판넬에 설정한 폼 넣기
                        estimateList.Show();  // 폼 실행
                        #endregion
                        tabChk = true; // 중복확인용 bool 타입
                        break;
                    }
                case "품목등록":

                    break;
                case "판매조회":
                    #region 판넬생성 -> 탭페이지생성 -> 탭페이지.컨트롤.넣기(판넬)
                    panel_mdi = new Panel();
                    panel_mdi.Name = "testno1";
                    tabControl1.TabPages.Add(menuName.ToString(), menuName.ToString());
                    tabControl1.TabPages[menuName.ToString()].Controls.Add(panel_mdi);
                    tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].Dock = DockStyle.Fill;
                    tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].BackColor = Color.AliceBlue;
                    #endregion

                    #region 판넬에 넣을 폼 객체 생성 -> 폼 스타일 설정 -> 판넬에 폼을 MDI 로 출력
                    Frm_SellBuyList selllist = new Frm_SellBuyList();
                    selllist.ControlBox = false; // 컨트롤 상자 없애기
                    selllist.FormBorderStyle = FormBorderStyle.None; // 폼 테투리 삭제
                    selllist.MdiParent = this; // MDI 설정
                    selllist.Dock = DockStyle.Fill; // Dock 스타일 설정 Fill
                    panel_mdi.Controls.Add(selllist); // 판넬에 설정한 폼 넣기
                    selllist.Show();  // 폼 실행
                    #endregion
                   tabChk = true; // 중복확인용 bool 타입
                    break;

                case "거래처 조회":
                    #region 판넬생성 -> 탭페이지생성 -> 탭페이지.컨트롤.넣기(판넬)
                    panel_mdi = new Panel();
                    panel_mdi.Name = "testno1";
                    tabControl1.TabPages.Add(menuName.ToString(), menuName.ToString());
                    tabControl1.TabPages[menuName.ToString()].Controls.Add(panel_mdi);
                    tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].Dock = DockStyle.Fill;
                    tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].BackColor = Color.AliceBlue;
                    #endregion

                    #region 판넬에 넣을 폼 객체 생성 -> 폼 스타일 설정 -> 판넬에 폼을 MDI 로 출력

                    Frm_BusinessList businessList = new Frm_BusinessList();
                    businessList.ControlBox = false; // 컨트롤 상자 없애기
                    businessList.FormBorderStyle = FormBorderStyle.None; // 폼 테투리 삭제
                    businessList.MdiParent = this; // MDI 설정
                    businessList.Dock = DockStyle.Fill; // Dock 스타일 설정 Fill
                    panel_mdi.Controls.Add(businessList); // 판넬에 설정한 폼 넣기
                    businessList.Show();  // 폼 실행
                    #endregion

                    tabChk = true; // 중복확인용 bool 타입
                    break;
                case "생산계획서 조회":
                    #region 판넬생성 -> 탭페이지생성 -> 탭페이지.컨트롤.넣기(판넬)
                    panel_mdi = new Panel();
                    panel_mdi.Name = "testno1";
                    tabControl1.TabPages.Add(menuName.ToString(), menuName.ToString());
                    tabControl1.TabPages[menuName.ToString()].Controls.Add(panel_mdi);
                    tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].Dock = DockStyle.Fill;
                    tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].BackColor = Color.AliceBlue;
                    #endregion

                    #region 판넬에 넣을 폼 객체 생성 -> 폼 스타일 설정 -> 판넬에 폼을 MDI 로 출력

                    Frm_ProductionPlanList productionPlanList = new Frm_ProductionPlanList();
                    productionPlanList.ControlBox = false; // 컨트롤 상자 없애기
                    productionPlanList.FormBorderStyle = FormBorderStyle.None; // 폼 테투리 삭제
                    productionPlanList.MdiParent = this; // MDI 설정
                    productionPlanList.Dock = DockStyle.Fill; // Dock 스타일 설정 Fill
                    panel_mdi.Controls.Add(productionPlanList); // 판넬에 설정한 폼 넣기
                    productionPlanList.Show();  // 폼 실행
                    #endregion

                    tabChk = true; // 중복확인용 bool 타입
                    break;
                default:
                    MessageBox.Show("해당 폼이 없습니다.");
                    tabControl1.SelectedTab = tabControl1.TabPages[0];
                    break;

            }
            tabChk = false;
        }

        #region 탭페이지 닫기 버튼 추가 이벤트
        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }
        #endregion

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // 미완   
        }

        // 왼쪽 실시간 확인창 최대화 폼 호출하는 메서드
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Frm_MaxSizeGrp frm_MaxSizeGrp = new Frm_MaxSizeGrp();
            frm_MaxSizeGrp.Show();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuClickEvnet(object sender, EventArgs e)
        {
            OpenForm(sender);
        }
    }
}
