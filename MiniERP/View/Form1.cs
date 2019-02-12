using MiniERP.View.BusinessManagement;
using MiniERP.View.LogisticsManagement;
using MiniERP.View.SalesPurchaseManagement;
using MiniERP.View.StockManagement;
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
        private bool tabChk = true; // 탭페이지 중복검사용 - true 중복 , false 중복 X

        private Point imageLocation = new Point(10, 5);
        private Point imageHitArea = new Point(10, 5);

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
                        if (tabControl1.TabPages[i].Name == menuName.ToString()) // 생선된 탭 페이지중 선택한 탭페이지 이름이 있다면 실행
                        {
                            tabControl1.SelectedTab = tabControl1.TabPages[menuName.ToString()]; // 중복된 탭 활성화
                            test = false; // 중복검사용 bool 문 false로 전환
                            break;
                        }
                    }
                    if (test)
                    {
                        // 2. 중복된 폼이 있을때 아래 메서드를 실행하여 폼 생성
                        tabChk = true; // 중복검사용 bool 문 true로 전환
                        tabControl1.SelectedTab = tabControl1.TabPages[menuName.ToString()];
                        OpenForm(menuName);
                    }

                }
                else
                {
                    // 1. 중복된 폼 없이 최초생성시 실행
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
                case "MainPage":
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
                        FrmDashBoard dashBoard = new FrmDashBoard();
                        dashBoard.ControlBox = false; // 컨트롤 상자 없애기
                        dashBoard.FormBorderStyle = FormBorderStyle.None; // 폼 테투리 삭제
                        dashBoard.MdiParent = this; // MDI 설정
                        dashBoard.Dock = DockStyle.Fill; // Dock 스타일 설정 Fill
                        panel_mdi.Controls.Add(dashBoard); // 판넬에 설정한 폼 넣기
                        dashBoard.Show();  // 폼 실행
                        #endregion
                        tabChk = true; // 중복확인용 bool 타입
                        break;
                    }
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

                case "품목 등록":
                    {
                        Frm_ItemInsert itemInsert = new Frm_ItemInsert();
                        itemInsert.Show();  // 폼 실행
                        break;
                    }
                case "창고 등록":
                    {
                        Frm_StockInsert stockInsert = new Frm_StockInsert();

                        stockInsert.Show();  // 폼 실행
                        break;
                    }
                case "거래처 등록":
                    {
                        Frm_BusinessInsert businessInsert = new Frm_BusinessInsert();
                        businessInsert.Show();
                        break;
                    }
                case "판매/구매 조회":
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

                    Frm_productionList productionList = new Frm_productionList();
                    productionList.ControlBox = false; // 컨트롤 상자 없애기
                    productionList.FormBorderStyle = FormBorderStyle.None; // 폼 테투리 삭제
                    productionList.MdiParent = this; // MDI 설정
                    productionList.Dock = DockStyle.Fill; // Dock 스타일 설정 Fill
                    panel_mdi.Controls.Add(productionList); // 판넬에 설정한 폼 넣기
                    productionList.Show();  // 폼 실행
                    #endregion

                    tabChk = true; // 중복확인용 bool 타입
                    break;
                case "창고 조회":
                    #region 판넬생성 -> 탭페이지생성 -> 탭페이지.컨트롤.넣기(판넬)
                    panel_mdi = new Panel();
                    panel_mdi.Name = "testno1";
                    tabControl1.TabPages.Add(menuName.ToString(), menuName.ToString());
                    tabControl1.TabPages[menuName.ToString()].Controls.Add(panel_mdi);
                    tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].Dock = DockStyle.Fill;
                    tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].BackColor = Color.AliceBlue;
                    #endregion

                    #region 판넬에 넣을 폼 객체 생성 -> 폼 스타일 설정 -> 판넬에 폼을 MDI 로 출력
                    Frm_StockList stockList = new Frm_StockList();
                    stockList.ControlBox = false; // 컨트롤 상자 없애기
                    stockList.FormBorderStyle = FormBorderStyle.None; // 폼 테투리 삭제
                    stockList.MdiParent = this; // MDI 설정
                    stockList.Dock = DockStyle.Fill; // Dock 스타일 설정 Fill
                    panel_mdi.Controls.Add(stockList); // 판넬에 설정한 폼 넣기
                    stockList.Show();  // 폼 실행
                    #endregion
                    tabChk = true;
                    break;
              
                case "BOM 조회":
                    #region 판넬생성 -> 탭페이지생성 -> 탭페이지.컨트롤.넣기(판넬)
                    panel_mdi = new Panel();
                    panel_mdi.Name = "testno1";
                    tabControl1.TabPages.Add(menuName.ToString(), menuName.ToString());
                    tabControl1.TabPages[menuName.ToString()].Controls.Add(panel_mdi);
                    tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].Dock = DockStyle.Fill;
                    tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].BackColor = Color.AliceBlue;
                    #endregion

                    #region 판넬에 넣을 폼 객체 생성 -> 폼 스타일 설정 -> 판넬에 폼을 MDI 로 출력
                    Frm_BomList bomList = new Frm_BomList();
                    bomList.ControlBox = false; // 컨트롤 상자 없애기
                    bomList.FormBorderStyle = FormBorderStyle.None; // 폼 테투리 삭제
                    bomList.MdiParent = this; // MDI 설정
                    bomList.Dock = DockStyle.Fill; // Dock 스타일 설정 Fill
                    panel_mdi.Controls.Add(bomList); // 판넬에 설정한 폼 넣기
                    bomList.Show();  // 폼 실행
                    #endregion
                    tabChk = true;
                    break;
                case "사원등록":
                    #region 판넬생성 -> 탭페이지생성 -> 탭페이지.컨트롤.넣기(판넬)
                    panel_mdi = new Panel();
                    panel_mdi.Name = "testno1";
                    tabControl1.TabPages.Add(menuName.ToString(), menuName.ToString());
                    tabControl1.TabPages[menuName.ToString()].Controls.Add(panel_mdi);
                    tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].Dock = DockStyle.Fill;
                    tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].BackColor = Color.AliceBlue;
                    #endregion

                    #region 판넬에 넣을 폼 객체 생성 -> 폼 스타일 설정 -> 판넬에 폼을 MDI 로 출력
                    Frm_clerkInsert clerkInsert = new Frm_clerkInsert();
                    clerkInsert.ControlBox = false; // 컨트롤 상자 없애기
                    clerkInsert.FormBorderStyle = FormBorderStyle.None; // 폼 테투리 삭제
                    clerkInsert.MdiParent = this; // MDI 설정
                    clerkInsert.Dock = DockStyle.Fill; // Dock 스타일 설정 Fill
                    panel_mdi.Controls.Add(clerkInsert); // 판넬에 설정한 폼 넣기
                    clerkInsert.Show();  // 폼 실행
                    #endregion
                    tabChk = true;
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