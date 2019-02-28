using ChattingServer.FTPbase;
using MiniERP.Model.DAO;
using MiniERP.View.BusinessManagement;
using MiniERP.View.LogisticsManagement;
using MiniERP.View.StockManagement;
using MiniERP.View.TradeManagement;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;


namespace MiniERP.View
{
    public partial class Form1 : Form
    {


        public static bool notify = false;//알림이 오는지 선택            
        Frm_message frm_message;//메시지창              


        /// <summary>
        /// 접속할 서버객체
        /// </summary>      

        //메시지 구현부분 by 종완






        private Panel panel_mdi;
        private bool tabChk = true; // 탭페이지 중복검사용 - true 중복 , false 중복 X
        private bool mboxchk = true; // 메세지 박스 실행 방지용

        private int tabSelcted_Index = 0; // 선택한 탭의 인덱스 값을 저장합니다. 디폴트 = 0 ( 메인 페이지 )
        private string id;//로그인시 입력할 사원id
        private string pwd;//로그인시 입력될 사원pw
        private bool save;//현 로그인 정보 저장
        private string autologin;//자동로그인 여부

        public string nickname = "";//상대방에게 보이는 자신의 이름

        public DialogResult logIn;          //  로그인 체커부

        public string Id { get => id; set => id = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public string Autologin { get => autologin; set => autologin = value; }
        public bool Save { get => save; set => save = value; }

        public Form1()
        {
            Frm_LoginBox loginbox = new Frm_LoginBox(this);
            loginbox.ShowDialog();
            if (logIn != DialogResult.OK)
            {
                this.Close();
            }
            InitializeComponent();
        }








        #region MDI 패널에 폼 불러오기 메서드
        private void OpenForm(object menuName)
        {
            if (tabControl1.TabCount <= 10)
            {
                if (!tabChk) // 최초실행시 탭생성 실행
                {
                    bool mdichk = true;
                    for (int i = 0; i < tabControl1.TabCount; i++)
                    {
                        // 폼 생성 중복검사
                        if (tabControl1.TabPages[i].Name == menuName.ToString()) // 생선된 탭 페이지중 선택한 탭페이지 이름이 있다면 실행
                        {
                            tabControl1.SelectedTab = tabControl1.TabPages[menuName.ToString()]; // 중복된 탭 활성화
                            mdichk = false; // 중복검사용 bool 문 false로 전환
                            break;
                        }
                    }
                    if (mdichk)
                    {
                        // 2. 중복된 폼이 있을때 아래 메서드를 실행하여 폼 생성
                        tabChk = true; // 중복검사용 bool 문 true로 전환
                        OpenForm(menuName);
                        tabControl1.SelectedTab = tabControl1.TabPages[menuName.ToString()]; // 중복된 탭이 있으면 중복탭 선택
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
        #endregion

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
                        Add_CloseBtn(orderList); // 폼에 닫기 버튼 생성
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
                        Add_CloseBtn(estimateList); // 폼에 닫기 버튼 생성
                        tabChk = true; // 중복확인용 bool 타입
                        break;
                    }
                case "진행중인 거래조회":
                    #region 판넬생성 -> 탭페이지생성 -> 탭페이지.컨트롤.넣기(판넬)
                    panel_mdi = new Panel();
                    panel_mdi.Name = "testno1";
                    tabControl1.TabPages.Add(menuName.ToString(), menuName.ToString());
                    tabControl1.TabPages[menuName.ToString()].Controls.Add(panel_mdi);
                    tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].Dock = DockStyle.Fill;
                    tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].BackColor = Color.AliceBlue;
                    #endregion

                    #region 판넬에 넣을 폼 객체 생성 -> 폼 스타일 설정 -> 판넬에 폼을 MDI 로 출력
                    TradeManagement.Frm_SellBuyList selllist = new TradeManagement.Frm_SellBuyList();
                    selllist.ControlBox = false; // 컨트롤 상자 없애기
                    selllist.FormBorderStyle = FormBorderStyle.None; // 폼 테투리 삭제
                    selllist.MdiParent = this; // MDI 설정
                    selllist.Dock = DockStyle.Fill; // Dock 스타일 설정 Fill
                    panel_mdi.Controls.Add(selllist); // 판넬에 설정한 폼 넣기
                    selllist.Show();  // 폼 실행
                    #endregion
                    Add_CloseBtn(selllist); // 폼에 닫기 버튼 생성
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
                    Add_CloseBtn(businessList); // 폼에 닫기 버튼 생성
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
                    Add_CloseBtn(productionList); // 폼에 닫기 버튼 생성
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
                    Add_CloseBtn(stockList); // 폼에 닫기 버튼 생성
                    tabChk = true;
                    break;
                case "거래 조회":
                    #region 판넬생성 -> 탭페이지생성 -> 탭페이지.컨트롤.넣기(판넬)
                    panel_mdi = new Panel();
                    panel_mdi.Name = "testno1";
                    tabControl1.TabPages.Add(menuName.ToString(), menuName.ToString());
                    tabControl1.TabPages[menuName.ToString()].Controls.Add(panel_mdi);
                    tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].Dock = DockStyle.Fill;
                    tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].BackColor = Color.AliceBlue;
                    #endregion

                    #region 판넬에 넣을 폼 객체 생성 -> 폼 스타일 설정 -> 판넬에 폼을 MDI 로 출력
                    TradeManagement.Frm_TradeList treadelist = new TradeManagement.Frm_TradeList();
                    treadelist.ControlBox = false; // 컨트롤 상자 없애기
                    treadelist.FormBorderStyle = FormBorderStyle.None; // 폼 테투리 삭제
                    treadelist.MdiParent = this; // MDI 설정
                    treadelist.Dock = DockStyle.Fill; // Dock 스타일 설정 Fill
                    panel_mdi.Controls.Add(treadelist); // 판넬에 설정한 폼 넣기
                    treadelist.Show();  // 폼 실행
                    #endregion
                    Add_CloseBtn(treadelist); // 폼에 닫기 버튼 생성
                    tabChk = true;
                    break;
                case "창고 이동":

                    #region 판넬생성 -> 탭페이지생성 -> 탭페이지.컨트롤.넣기(판넬)
                    panel_mdi = new Panel();
                    panel_mdi.Name = "testno1";
                    tabControl1.TabPages.Add(menuName.ToString(), menuName.ToString());
                    tabControl1.TabPages[menuName.ToString()].Controls.Add(panel_mdi);
                    tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].Dock = DockStyle.Fill;
                    tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].BackColor = Color.AliceBlue;
                    #endregion

                    #region 판넬에 넣을 폼 객체 생성 -> 폼 스타일 설정 -> 판넬에 폼을 MDI 로 출력
                    Frm_WarehouseMovement warehouseMovement = new Frm_WarehouseMovement();
                    warehouseMovement.ControlBox = false; // 컨트롤 상자 없애기
                    warehouseMovement.FormBorderStyle = FormBorderStyle.None; // 폼 테투리 삭제
                    warehouseMovement.MdiParent = this; // MDI 설정
                    warehouseMovement.Dock = DockStyle.Fill; // Dock 스타일 설정 Fill
                    panel_mdi.Controls.Add(warehouseMovement); // 판넬에 설정한 폼 넣기
                    warehouseMovement.Show();  // 폼 실행
                    #endregion
                    Add_CloseBtn(warehouseMovement); // 폼에 닫기 버튼 생성
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
                    Add_CloseBtn(bomList); // 폼에 닫기 버튼 생성
                    break;
                case "사원 조회":
                    #region 판넬생성 -> 탭페이지생성 -> 탭페이지.컨트롤.넣기(판넬)
                    panel_mdi = new Panel();
                    panel_mdi.Name = "testno1";
                    tabControl1.TabPages.Add(menuName.ToString(), menuName.ToString());
                    tabControl1.TabPages[menuName.ToString()].Controls.Add(panel_mdi);
                    tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].Dock = DockStyle.Fill;
                    tabControl1.TabPages[menuName.ToString()].Controls[panel_mdi.Name].BackColor = Color.AliceBlue;
                    #endregion

                    #region 판넬에 넣을 폼 객체 생성 -> 폼 스타일 설정 -> 판넬에 폼을 MDI 로 출력
                    Frm_ClerkList clerklist = new Frm_ClerkList();
                    clerklist.ControlBox = false; // 컨트롤 상자 없애기
                    clerklist.FormBorderStyle = FormBorderStyle.None; // 폼 테투리 삭제
                    clerklist.MdiParent = this; // MDI 설정
                    clerklist.Dock = DockStyle.Fill; // Dock 스타일 설정 Fill
                    panel_mdi.Controls.Add(clerklist); // 판넬에 설정한 폼 넣기
                    clerklist.Show();  // 폼 실행
                    #endregion
                    tabChk = true;
                    Add_CloseBtn(clerklist); // 폼에 닫기 버튼 생성
                    break;

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

                case "사원 등록":
                    Frm_ClerkInsert clerkInsert = new Frm_ClerkInsert();
                    clerkInsert.Show();  // 폼 실행
                    tabChk = true;
                    break;
                default:
                    MessageBox.Show("해당 폼이 없습니다.");
                    tabControl1.SelectedTab = tabControl1.TabPages[0];
                    break;
            }
            tabChk = false;
        }

        private void CloseForm(object test)
        {

        }

        private void tsm_Accountregistration_Click(object sender, EventArgs e)
        {
            Frm_MaxSizeGrp frm_MaxSizeGrp = new Frm_MaxSizeGrp();
            frm_MaxSizeGrp.Show();
        }

        #region 탭페이지 닫기버튼 생성 메서드
        private void Add_CloseBtn(Form formtest) // !! 주의 조회 폼에서만 사용할것
        {
            Button closebtn = new Button(); // 버튼 생성
            closebtn.Location = new Point(740, 12); // 위치고정 ( 변경하지말 것 )
            closebtn.Anchor = AnchorStyles.Right; // 이거 쓸모 없음 ㅡㅡ
            closebtn.Image = Properties.Resources.CloseIcon; // 리소스 폴더내 이미지 파일을 사용
            closebtn.ImageAlign = ContentAlignment.MiddleCenter;
            closebtn.Height = 23;
            closebtn.Width = 23;
            closebtn.MouseClick += Closebtn_MouseClick; // 버튼 이벤트 생성
            formtest.Controls.Add(closebtn); // 생성된 탭컨트롤 안에 버튼 넣음
        }

        #region 닫기버튼 클릭 이벤트
        private void Closebtn_MouseClick(object sender, MouseEventArgs e)
        {
            tabSelcted_Index = tabControl1.SelectedIndex;
            tabControl1.TabPages.Remove(tabControl1.TabPages[tabSelcted_Index]);// 탭컨트롤에서 해당 페이지 삭제
        }
        #endregion

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenForm("MainPage");
            frm_message = new Frm_message();
            frm_message.Form = this;
            frm_message.Nickname = this.nickname;
            frm_message.MdiParent = this;
            this.splitContainer2.Panel2.Controls.Add(frm_message);
            frm_message.Dock = DockStyle.Fill;
            frm_message.Show();
        }

        #region 프로그램 종료시 대화상자 이벤트
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 폼이 닫히기 전에 메세지 박스로 재확인
            if (mboxchk) // 중복방지용 변수 true 면 mbox 실행
            {
                mboxchk = false;
                if (MessageBox.Show("프로그램을 종료하시겠습니까?", "확인 메세지", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frm_message.Close();
                    outputloginFile();
                    e.Cancel = false; // 폼 닫음  
                    closeBackground(@"taskkill /im  Minierp.exe /f");

                    this.Dispose();
                }
                else // No 선택시 닫기 취소
                {
                    e.Cancel = true; // 폼 닫기 취소
                }
                mboxchk = true;
            }
            else
            {
                mboxchk = true;
            }
        }

        private void outputloginFile()
        {
            if(save)
            {
                FileStream fs=null;
                StreamWriter sr=null;
            if (!System.IO.File.Exists("login.txt"))
                {
                   fs = new FileStream("login.txt", FileMode.Create, FileAccess.Write, FileShare.None);
               
                }
            else
                {
                    fs = new FileStream("login.txt", FileMode.Truncate, FileAccess.Write, FileShare.None);

                }
                sr = new StreamWriter(fs);
                sr.WriteLine("id:" + id);
                sr.WriteLine("pw:" + pwd);
                sr.WriteLine("autologin:" + autologin);
                sr.Close();
                fs.Close();

            }

        }

        

        private void closeBackground(string command)
        {
            ProcessStartInfo cmd = new ProcessStartInfo();
            Process process = new Process();
            cmd.FileName = @"cmd";
            cmd.WindowStyle = ProcessWindowStyle.Hidden;
            cmd.CreateNoWindow = true;
            cmd.UseShellExecute = false;
            cmd.RedirectStandardInput = true;
            cmd.RedirectStandardInput = true;
            cmd.RedirectStandardError = false;

            process.EnableRaisingEvents = false;
            process.StartInfo = cmd;
            process.Start();
            process.StandardInput.Write(command + Environment.NewLine);
            process.StandardInput.Close();
        }
        #endregion

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Frm_MaxSizeGrp frm_MaxSizeGrp = new Frm_MaxSizeGrp();
            frm_MaxSizeGrp.Show();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {




        }









        private void Server_posted(string fileName)
        {
            MessageBox.Show("서버에 파일:" + fileName + "을 모두 전송완료 하였습니다");
        }




        #region 탭페이지 선택 이벤트
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex != -1)
            {
                tabSelcted_Index = tabControl1.SelectedIndex;
            }

        }


        #endregion

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                notify = false;
                frm_message.Windowstate = "최대화";
            }
            if (this.WindowState == FormWindowState.Normal)
            {
                notify = false;
                frm_message.Windowstate = "기본";
            }
            if (this.WindowState == FormWindowState.Minimized)
            {
                notify = true;
                frm_message.Windowstate = "최소화";
            }
        }

        private void MenuClickEvent(object sender, EventArgs e)
        {
            OpenForm(sender);
            tabControl1.SelectedTab = tabControl1.TabPages[tabSelcted_Index];
        }
    }
}