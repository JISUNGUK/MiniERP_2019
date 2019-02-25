using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 상태정보를 저장하는 클래스
namespace MiniERP.VO
{
    class Status
    {
        private int no;
        private string statusStr;

        public int No { get => no; set => no = value; }
        public string StatusStr { get => statusStr; set => statusStr = value; }

        public Status(int no, string statusStr)
        {
            this.no = no;
            this.statusStr = statusStr;
        }

        public int GetNo(string status)
        {
            if(statusStr == status)
            {
                return no;
            }
            return 0;
        }

        public string GetStatusStr(int number)
        {
            if(no == number)
            {
                return statusStr;
            }
            return String.Empty;
        }
    }
}
