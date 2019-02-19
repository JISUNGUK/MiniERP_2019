using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MiniERP.VO
{
    public class Clerk
    {
        private string clerk_code;
        private string clerk_password;
        private string clerk_job;
        private string clerk_name;

        public string Clerk_code { get => clerk_code; set => clerk_code = value; }
        public string Clerk_password { get => clerk_password; set => clerk_password = value; }
        public string Clerk_job { get => clerk_job; set => clerk_job = value; }
        public string Clerk_name { get => clerk_name; set => clerk_name = value; }
    }
}