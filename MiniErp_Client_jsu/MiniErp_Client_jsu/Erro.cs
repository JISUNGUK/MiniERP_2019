using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniErp_Client_jsu
{
    class Erro
    {
        private string head;

        public string Head
        {
            get { return head; }
            set { head = value; }
        }
        private string erro_String;

        public string Erro_String
        {
            get { return erro_String; }
            set { erro_String = value; }
        }
        private int erro_Code;

        public int Erro_Code
        {
            get { return erro_Code; }
            set { erro_Code = value; }
        }


        public Erro(int err_Code)
        {
            this.erro_Code = err_Code;
            this.head = "[erro] ";
            ErroSetting();
        }

        private void ErroSetting()
        {
            switch (this.erro_Code)
            {
                case 1: this.erro_String = "DB is lost"; break;
                default:
                    break;
            }
        }
    }
}
