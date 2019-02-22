using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniErp_Client_jsu
{
    public partial class Form1 : Form
    {
        Machine machine;
        List<Barcode> codes=new List<Barcode>();

        //  erro , command 리스트
        List<Erro> erros = new List<Erro>();
        List<Command> commands = new List<Command>();

        public Form1()
        {
            InitializeComponent();
        }


        private void txt_Barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                string temp = txt_Barcode.Text;
                txt_Barcode.Clear();

                foreach (var item in codes)
                {
                    if (item.Barcode_Code == temp)
                    {
                        item.Barcode_Count += 1;    // 같다면 카운트
                        return;
                    }
                }

                //  없다면 추가
                codes.Add(new Barcode(temp));
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                machine = new Machine();
                machine.Setting();
                if (machine.SeverState()==true)
                {
                    checkBox1.Checked = true;
                    txt_Log.Text += "sever connection ok";
                }
            }
            catch (Exception)
            {
                checkBox1.Checked = false;
            }

            #region command test 모듈
            ////string testmsg = "[command] exit";
            //string testmsg = "[command] restart";
            //MessageBox.Show("Test");

            //Command test = new Command(testmsg);
            //test.CommandRunning(); 
            #endregion

            #region erro test 모듈
            Erro testErro = new Erro(1);
            MessageBox.Show(testErro.Erro_Code + "\n" + testErro.Head + testErro.Erro_String); 
            #endregion


        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in codes)
            {
                txt_Log.Clear();
                sb.AppendLine(item.Barcode_Code + "\t" + item.Barcode_Count);
            }
            txt_Log.Text = sb.ToString();

            this.txt_Barcode.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                machine.CloseSeverTest();
            }
            catch (Exception)
            {

            }
        }
    }
}
