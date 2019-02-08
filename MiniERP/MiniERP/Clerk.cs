using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    /// <summary>
    /// Clerk 테이블
    /// </summary>
    class Clerk
    {
        private string clerk_code;
        private string clerk_name;
        private string clerk_job;

        public string Clerk_code { get => clerk_code; set => clerk_code = value; }
        public string Clerk_name { get => clerk_name; set => clerk_name = value; }
        public string Clerk_job { get => clerk_job; set => clerk_job = value; }
    }
}
