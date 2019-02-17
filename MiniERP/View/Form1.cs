using ChattingServer.FTPbase;
using MiniERP.Model.DAO;
using MiniERP.View.BusinessManagement;
using MiniERP.View.LogisticsManagement;
using MiniERP.View.SalesPurchaseManagement;
using MiniERP.View.StockManagement;
using MiniERP.View.TradeManagement;
using System;
using System.Collections;
using System.Collections.Generic;
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
        //메시지 구현 필요 변수 부분  
        public string[] bannWord = { "//", "[", "]", "접속종료합니다", "접속인원:", "만든 방명:", "$$$$", "방에 참가했습니다", "방정보:", "방에 메시지를 보냅니다", ":방의 주인은?", "방을 삭제합니다", "인원:" };
        TcpClient client = new TcpClient();
        private Hashtable clientList = new Hashtable();//방과 해당 방의 메시지 내용을 저장
        NetworkStream network = default(NetworkStream);//기본값 할당(해당 객체의 기본값 참조형은 null)
        private string currentfileName;
        string readData = null;
        Frm_MakeRoom makeRoom;//방속성 정하는 창

        Hashtable roomtable;//방이름과 방의 메시지내용으로 구성

        private string ownedRoom = "";

       private MessageDAO messagedao;


        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        /// <summary>
        /// 접속할 서버객체
        /// </summary>
        private IFTPServer Server = null;
        List<UploadData> upload;//업로드할 파일들

        //메시지 구현부분 by 종완






        private Panel panel_mdi;
        private bool tabChk = true; // 탭페이지 중복검사용 - true 중복 , false 중복 X
        private bool mboxchk = true; // 메세지 박스 실행 방지용

        private int tabSelcted_Index = 0; // 선택한 탭의 인덱스 값을 저장합니다. 디폴트 = 0 ( 메인 페이지 )

        public string OwnedRoom { get => ownedRoom; set => ownedRoom = value; }
        public MessageDAO Messagedao { get => messagedao; set => messagedao = value; }

        internal DialogResult logIn;          //  로그인 체커부
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

        /// <summary>
        /// 서버에서 받고 전송한 메시지를 받아옴
        /// </summary>
        private void getMsg()
        {
            //서버가 보내준 메시지를 받음!!!
            while (true)
            {
                if (client.Connected)
                {
                    try
                    {
                        network = client.GetStream();
                        Byte[] byteFrom = new byte[client.SendBufferSize];
                        network.Read(byteFrom, 0, client.SendBufferSize);
                        readData = Encoding.UTF8.GetString(byteFrom).Replace("\0", "");
                    }
                    catch (Exception)
                    {


                    };
                    if (readData.Contains("해당 방은 있습니다"))
                        MessageBox.Show("같은 이름의 방은 만들수 없습니다");

                    Msg();
                    DisplayMember();
                }


            }
        }
        /// <summary>
        /// 방목록과 방에 들어온 접속자들을 폼에 추가
        /// </summary>
        private void DisplayMember()
        {
            if (this.InvokeRequired)//현재 getMsg()를 실행하는 스레드가 ui를 담당하는(Main()에서만들어진 스레드라면 다른 스레드로 getMsge가 호출되도록 함(대리자 이용)
            {
                this.Invoke(new MethodInvoker(DisplayMember));//스레드간 메시지 교환시킴
            }
            else
            {
                Messagedao.DisplayContent(readData, memberList, roomList, roomtable);   
            
            }
        }

        /// <summary>
        /// 서버에서 받은 메시지를 채팅창에 추가
        /// </summary>
        private void Msg()
        {
            if (this.InvokeRequired)//현재 getMsg()를 실행하는 스레드가 ui를 담당하는(Main()에서만들어진 스레드라면 다른 스레드로 getMsge가 호출되도록 함(대리자 이용)
            {
                this.Invoke(new MethodInvoker(Msg));//스레드간 메시지 교환시킴
            }
            else
            {
                Messagedao.GetMsg(readData, roomtable, roomList, ChatContent);
              

            }
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
                    Frm_TradeList treadelist = new Frm_TradeList();
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

        

        private void 견적서조회ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenForm(sender);
        }

        private void tsm_OrdM_inquiry_Click_1(object sender, EventArgs e)
        {
            OpenForm(sender);
        }

        private void 견적서조회ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            OpenForm(sender);
        }

        private void tsm_Accountregistration_Click(object sender, EventArgs e)
        {
            Frm_MaxSizeGrp frm_MaxSizeGrp = new Frm_MaxSizeGrp();
            frm_MaxSizeGrp.Show();
        }

        private void MenuClickEvnet(object sender, EventArgs e)
        {
            OpenForm(sender);
            tabControl1.SelectedTab = tabControl1.TabPages[tabSelcted_Index];
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
                    if (network != null)
                    {
                        Messagedao.SendMessage(nicname.Text + "접속종료합니다");
                        //SendMessage(nicname.Text + "접속종료합니다");
                        client.Close();
                        network.Close();
                    }
                    e.Cancel = false; // 폼 닫음
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
        #endregion
    
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Frm_MaxSizeGrp frm_MaxSizeGrp = new Frm_MaxSizeGrp();
            frm_MaxSizeGrp.Show();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            Bitmap oBitmap = null;



           
            OpenFileDialog openfile1 = new OpenFileDialog();
            DialogResult dr = openfile1.ShowDialog();
            openfile1.Multiselect = true;
            openfile1.Filter = "All files (*.*)|*.*";
            openfile1.FilterIndex = 2;
            openfile1.RestoreDirectory = true;
            if (dr == DialogResult.OK)
            {              
                string filename = openfile1.FileName;
                currentfileName = openfile1.FileName;
                filelabel.Text = openfile1.SafeFileName;

                //파일 아이콘을 갖고오는 부분
                SHFILEINFO shinfo = new SHFILEINFO();
                Win32.SHGetFileInfo(filename, 0, ref shinfo, (uint)System.Runtime.InteropServices.Marshal.SizeOf(shinfo), Win32.SHGFI_ICON | Win32.SHGFI_LARGEICON);
                System.Drawing.Icon myIcon = System.Drawing.Icon.FromHandle(shinfo.hIcon);
                fileImage.Image = (Image)myIcon.ToBitmap();

                upload = new List<UploadData>();
                foreach (string file in openfile1.FileNames)
                {
                    if ((new System.IO.FileInfo(file)).Length > 2000000000)
                    {
                        MessageBox.Show("파일명: '" + file + "'은 사이즈가 2기가 보다 큽니다 더 작은 파일을 선택해주세요.", "FTP파일전송", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }
                    UploadData data = new UploadData();
                    data.Filename = file.Split('\\')[file.Split('\\').Length - 1];
                    data.File = System.IO.File.ReadAllBytes(file);
                    upload.Add(data);
                }

            }


                        
            }

        private void access_Click(object sender, EventArgs e)
        {

            //메시지 서버에 접속
            try
            {
                Messagedao = new MessageDAO();
                readData = "채팅 서버 연결중...";
                client.Connect("192.168.0.8", 3333);//서버 접속
                Messagedao.Client = client;
                roomtable = new Hashtable();//처음 서버에 접속했을때 방목록을 처음 생성
                roomtable.Add("전체", "");
                //Msg();
                network = client.GetStream();              
                Messagedao.SendMessage(nicname.Text);
                Thread thread = new Thread(getMsg);
                thread.Start();
                Thread ftptread = new Thread(FTPConnection);
                ftptread.Start();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message+"오류가 발생했습니다");
            }
            access.Enabled = false;
            nicname.Enabled = false;
            //메시지 서버에 접속
        }

        private void message_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendMsg_Click(sender, null);
                message.Text = "";
            }
        }

        private void sendMsg_Click(object sender, EventArgs e)
        {
        if(!string.IsNullOrEmpty(message.Text))
            { 
            Messagedao.SendChatMessage(message.Text, roomList);
            message.Text = "";
            }

        if(upload.Count>0 && additionFile.Checked)
            {
                string folderName = "전체";
                if (roomList.SelectedIndex != -1)
                    folderName = roomList.SelectedItem.ToString();
                Server.Upload(MachineInfo.GetJustIP(), upload, folderName);
                RefreshList();
            }

        }

        private void particiRoom_Click(object sender, EventArgs e)
        {
            if (roomList.SelectedIndex != -1)
            {
                string message = roomList.SelectedItem.ToString() + "방에 참가했습니다";
                Messagedao.SendMessage(message);
            }

        }

        private void mkRoom_Click(object sender, EventArgs e)
        {

            makeRoom = new Frm_MakeRoom();

            makeRoom.Owner = this;
            makeRoom.RoomArr = new string[roomList.Items.Count];
            makeRoom.MemberArr = new string[memberList.Items.Count];
            DisplayMemberRoom();
            makeRoom.Show();
        }

        private void DisplayMemberRoom()
        {
            for (int i = 0; i < roomList.Items.Count; i++)
            {
                makeRoom.RoomArr[i] = roomList.Items[i].ToString();
            }

            for (int i = 0; i < memberList.Items.Count; i++)
            {
                makeRoom.MemberArr[i] = memberList.Items[i].ToString();
            }
        }

        private void roomList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChatContent.Text = roomtable[roomList.SelectedItem].ToString();
            if (this.OwnedRoom.Contains(roomList.SelectedItem.ToString()))
            {
                rmRoom.Enabled = true;
                rmRoom.Visible = true;
            }
            else
            {
                rmRoom.Enabled = false;
                rmRoom.Visible = false;

            }
            lbl_RoomName.Text = roomList.SelectedItem.ToString();
            RefreshList();

        }

        /// <summary>
        /// 파일리스트의 리스트뷰를 더블클릭하면 발생
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServerFileListView_DockChanged(object sender, EventArgs e)
        {
            if (ServerFileListView.SelectedItems.Count < 1)
                return;

            byte[] file;
            string folderName = "전체";
            if (roomList.SelectedIndex != -1)
                folderName = roomList.SelectedItem.ToString();
            Server.Download(MachineInfo.GetJustIP(), ServerFileListView.SelectedItems[0].SubItems[2].Text, out file, folderName);

            SaveFileDialog save = new SaveFileDialog();
            save.Title = "It saves the downloaded file.";
            save.SupportMultiDottedExtensions = false;
            save.Filter = "All|*.*";
            save.FileName = ServerFileListView.SelectedItems[0].SubItems[2].Text;
            if (save.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                System.IO.File.WriteAllBytes(save.FileName, file);
                MessageBox.Show(ServerFileListView.SelectedItems[0].SubItems[2].Text + "이 다운로드 되었습니다.", "FTP File 공유중", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            save.Dispose();

        }

        private void rmRoom_Click(object sender, EventArgs e)
        {
            if (roomList.SelectedIndex != -1 && roomList.SelectedItem != "전체")
            {
                DialogResult result = MessageBox.Show("제거하시겠습니까?", "방제거창", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string message = roomList.SelectedItem.ToString() + "방을 삭제합니다";
                    Messagedao.SendMessage(message);
                    roomtable.Remove(roomList.SelectedItem);
                    rmRoom.Enabled = false;
                    rmRoom.Visible = false;
                }
                
            }
        }


        #region 탭페이지 선택 이벤트
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex != -1 )
            {
                tabSelcted_Index = tabControl1.SelectedIndex;
            }
            
        }
        #endregion

        private void fileButton_MouseUp(object sender, MouseEventArgs e)
        {
            toolTip1.Show("파일 용량은 100mb보다 작아야합니다", fileButton, fileButton.Location, 10);
        }
        /// <summary>
        /// 파일이 서버에 올려졌을때 서버의 파일목록을 최신화
        /// </summary>
        private void RefreshList()
        {
            if (ServerFileListView.InvokeRequired)
            {
                MethodInvoker invoker = new MethodInvoker(RefreshList);
                ServerFileListView.Invoke(invoker);
            }
            else
            {
                try
                {
                    ServerFileListView.Items.Clear();
                    ServerFileListView.SuspendLayout();
                    List<ChattingServer.FTPbase.FileInfo> files = new List<ChattingServer.FTPbase.FileInfo>();
                    string folderName = "전체";
                    if (roomList.SelectedIndex != -1)
                        folderName = roomList.SelectedItem.ToString();
                    Server.GetFiles(out files, folderName);

                    foreach (ChattingServer.FTPbase.FileInfo file in files)
                    {

                        ListViewItem item = new ListViewItem((ServerFileListView.Items.Count + 1).ToString());
                        item.SubItems.Add("FTP Server");
                        item.SubItems.Add(file.Filename.Split('\\')[2]);
                        item.SubItems.Add(file.Size.ToString());
                        ServerFileListView.Items.Add(item);
                    }
                    ServerFileListView.ResumeLayout();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FTP File Sharing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FTPConnection()
        {
            if (!GetConnection())//만약 ftpconnection이 되어있지않으면 ftp연결은 되지 않는다;
                return;
            else
                MessageBox.Show("FTP서버와 연결이 잘 되었습니다");

        }

        /// <summary>
        /// FTP서버에 접속!!
        /// </summary>
        private bool GetConnection()
        {
            bool connected = true;

            SoapServerFormatterSinkProvider soap = new SoapServerFormatterSinkProvider();
            BinaryServerFormatterSinkProvider binary = new BinaryServerFormatterSinkProvider();
            soap.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            binary.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            soap.Next = binary;

            Hashtable table = new Hashtable();
            table.Add("port", "0");

            TcpChannel channel = new TcpChannel(table, null, soap);
            ChannelServices.RegisterChannel(channel, false);

            try
            {
                Server = (IFTPServer)Activator.GetObject(typeof(IFTPServer), string.Format("tcp://{0}:{1}/FTPServerAPP/ftpserver.svr", "192.168.0.8", "8081"));
            }
            catch (Exception ex)
            {
                connected = false;
                EventLogger.Logger(ex, "Client - GetConnection");
            }

            if (Server == null)
            {
                connected = false;
                ChannelServices.UnregisterChannel(channel);
                MessageBox.Show("Cannot Connect to the Server", "FTP File Sharing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return connected;
            }

            try
            {
                MiniERP.Model.DAO.PostedData handler = new MiniERP.Model.DAO.PostedData();
                handler.RefreshList += new EventHandler(handler_RefreshList);

                Server.PostedData += new PostedDataHandler(handler.Server_PostData);
                Server.Update += new UpdateHandler(handler.Server_Update);

                Server.Connect(MachineInfo.GetJustIP());

            }
            catch (Exception ex)
            {
                connected = false;
                ChannelServices.UnregisterChannel(channel);
                MessageBox.Show(ex.Message, "FTP File Sharing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return connected;

        }
        void handler_RefreshList(object sender, EventArgs e)
        {
            MessageBox.Show("Please Refresh your list.", "FTP File Sharing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }   
}