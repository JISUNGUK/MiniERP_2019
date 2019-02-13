using MiniERP.View.BusinessManagement;
using MiniERP.View.LogisticsManagement;
using MiniERP.View.SalesPurchaseManagement;
using MiniERP.View.StockManagement;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace MiniERP.View
{
    public partial class Form1 : Form
    {
        //메시지 구현 필요 변수 부분  
        public string[] bannWord = { "//", "[", "]", "접속종료합니다", "접속인원:", "만든 방명:", "$$$$", "방에 참가했습니다", "방정보:", "방에 메시지를 보냅니다", ":방의 주인은?", "방을 삭제합니다", "인원:" };
        TcpClient client = new TcpClient();
        private Hashtable clientList = new Hashtable();//방과 해당 방의 메시지 내용을 저장
        NetworkStream network = default(NetworkStream);//기본값 할당(해당 객체의 기본값 참조형은 null)
        string readData = null;
        Frm_MakeRoom makeRoom;//방속성 정하는 창

        Hashtable roomtable;//방이름과 방의 메시지내용으로 구성
        //메시지 구현부분 by 종완






        private Panel panel_mdi;
        private bool tabChk = true; // 탭페이지 중복검사용 - true 중복 , false 중복 X
        private bool mboxchk = true; // 메세지 박스 실행 방지용

        private int tabSelcted_Index; // 선택한 탭의 인덱스 값을 저장합니다.

        public Form1()
        {
            Frm_LoginBox loginbox = new Frm_LoginBox();
            loginbox.ShowDialog();
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
                network = client.GetStream();
                Byte[] byteFrom = new byte[client.SendBufferSize];
                network.Read(byteFrom, 0, client.SendBufferSize);
                readData = Encoding.UTF8.GetString(byteFrom).Replace("\0", "");
                if (readData.Contains("해당 방은 있습니다"))
                    MessageBox.Show("같은 이름의 방은 만들수 없습니다");
                
                Msg();
                DisplayMember();


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
               

                if (readData.Contains("접속 인원:"))
                {
                    memberList.Items.Clear();
                    var seperators = new char[1];
                    seperators[0] = ',';
                    int lastIndex = readData.IndexOf("::");
                    string accessmember = readData.Remove(lastIndex);
                    int accessMemberIndex = readData.IndexOf("접속 인원:") + 6;
                    accessmember = accessmember.Substring(accessMemberIndex);                 
                    string[] members = accessmember.Split(seperators[0]);
                    string memberNamelist = "";
                    foreach (var v in members)
                    {
                        if (!memberNamelist.Contains(v))
                            memberList.Items.Add(v);
                        memberNamelist += v;
                    }
                }

                if(readData.Contains("방 주인 맞으시네요~~"))
                {
                    rmRoom.Enabled = true;
                    rmRoom.Visible = true;
                }


                if (readData.Contains("방 목록:"))
                {
                    roomList.Items.Clear();
                    var seperators = new char[1];
                    seperators[0] = ',';
                    int lastIndex = readData.IndexOf(";;");
                    int accessRoomIndex = readData.IndexOf("방 목록:") + 5;
                    string accessRoom = readData.Remove(lastIndex);
                    string roomlist = accessRoom.Substring(accessRoomIndex);
                    if (roomlist != "")
                    {
                        string[] rooms = roomlist.Split(seperators[0]);
                        string roomNamelist = "";
                        foreach (var v in rooms)
                        {
                            if (!roomNamelist.Contains(v))
                            {
                                
                                roomList.Items.Add(v);
                            }
                            if(!roomtable.Contains(v))
                            {
                                roomtable.Add(v, "");//로컬프로그램에 저장될 채팅방 이름과 메시지내용들
                            }
                            roomNamelist += v;
                        }
                    }
                }
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
                if (!readData.Contains("서버 메시지:"))
                {
                    string date = Environment.NewLine + "보낸 시간:" + DateTime.Now + "\n";
                    if (readData.Contains(">>>>"))
                    {
                        int indexOfseprate = readData.IndexOf(">>>>");
                        string roomname = readData.Remove(indexOfseprate);
                        string message = readData.Substring(indexOfseprate+4);
                        roomname = roomname.Substring(3);//방명:으로부터 인덱스가 3인것부터가 방명이므로
                        roomtable[roomname] += date + Environment.NewLine + ">>" + message + "\n";
                       
                    if(roomList.SelectedIndex!=-1)
                        {
                            if(roomList.SelectedItem.ToString()==roomname)
                            {
                                ChatContent.Text = ChatContent.Text + date + Environment.NewLine + ">>" + message + "\n";
                                ChatContent.SelectionStart = ChatContent.TextLength;
                                ChatContent.ScrollToCaret();

                            }
                        }



                    }
                    else
                    {
                        if (roomList.SelectedItem==null|| roomList.SelectedItem.ToString()=="전체")
                        {
                            ChatContent.Text = ChatContent.Text + date + Environment.NewLine + ">>" + readData;
                            ChatContent.SelectionStart = ChatContent.TextLength;
                            ChatContent.ScrollToCaret();
                        }
                        roomtable["전체"] += date + Environment.NewLine + ">>" + readData+"\n" ; 
                    }


                }

                

            }
        }


        public void SendMessage(string message)
        {
            try
            {
                byte[] messageByte = Encoding.UTF8.GetBytes(message);//서버쪽에서 받았을때 해당 문자가 있으면 사용자가 보낸 문자라고 인식되게 함~~
                network = client.GetStream();
                network.Write(messageByte, 0, messageByte.Length);
                network.Flush();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
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
                    SendMessage(nicname.Text + "접속종료합니다" + "$$$$"); // 종료시 대화방 사람들에게 접속종료 메세지 전송
                    client.Close(); // 통신서버 닫음
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

        private void imageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile1 = new OpenFileDialog();
            DialogResult dr = openfile1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                imageLabel.Text += openfile1.FileName;
            }
        }

        private void access_Click(object sender, EventArgs e)
        {

            //메시지 서버에 접속
            try
            {
                readData = "채팅 서버 연결중...";
                client.Connect("192.168.0.6", 3333);//서버 접속
                roomtable = new Hashtable();//처음 서버에 접속했을때 방목록을 처음 생성
                roomtable.Add("전체", "");
                //Msg();
                network = client.GetStream();

                SendMessage(nicname.Text);

                Thread thread = new Thread(getMsg);
                thread.Start();
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
            }
        }

        private void sendMsg_Click(object sender, EventArgs e)
        {
            if (roomList.SelectedIndex != -1)
            {
                if (checkmessage(message.Text))
                {
                    if (roomList.SelectedItem.ToString() == "전체")
                        SendMessage(message.Text + "$$$$");
                    else
                        SendMessage(roomList.SelectedItem.ToString() + "방에 메시지를 보냅니다" + message.Text + "//");
                    message.Text = "";
                }
                else
                    MessageBox.Show("금지된 단어로 메시지를 보낼수 없습니다");
            }
            if (roomList.SelectedIndex == -1)
            {
                SendMessage(message.Text + "$$$$");
            }
        }
        private bool checkmessage(string message)
        {
            foreach (var v in bannWord)
            {
                if (message.Contains(v))
                    return false;
            }
            return true;
        }

        private void particiRoom_Click(object sender, EventArgs e)
        {
            if (roomList.SelectedIndex != -1)
            {
                string message = roomList.SelectedItem.ToString() + "방에 참가했습니다";
                SendMessage(message);
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
            timer1.Enabled = true;
            ChatContent.Text = roomtable[roomList.SelectedItem].ToString();

        }

        private void rmRoom_Click(object sender, EventArgs e)
        {
            if (roomList.SelectedIndex != -1 && roomList.SelectedItem != "전체")
            {
                DialogResult result = MessageBox.Show("제거하시겠습니까?", "방제거창", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string message = roomList.SelectedItem.ToString() + "방을 삭제합니다";
                    SendMessage(message);
                }
                roomtable.Remove(roomList.SelectedItem);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        if(roomList.SelectedIndex!=-1)
            { 
            if(roomList.SelectedItem.ToString()!="전체")
                { 
                string message = roomList.SelectedItem.ToString() + ":방의 주인은?";
                SendMessage(message);
                timer1.Enabled = false;
                }
            }
        }
    }   
}