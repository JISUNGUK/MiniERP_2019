using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    /// <summary>
    /// 거래처 테이블
    /// </summary>
    class Business
    {
        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string tel;

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        private string addr;

        public string Addr
        {
            get { return addr; }
            set { addr = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string presenter;

        public string Presenter
        {
            get { return presenter; }
            set { presenter = value; }
        }

    }
}
