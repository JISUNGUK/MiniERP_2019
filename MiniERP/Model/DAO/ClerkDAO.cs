using MiniERP.VO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Model.DAO
{
    class ClerkDAO
    {
        List<Clerk> clerks;

        public List<Clerk> GetClerk()
        {
            clerks = new List<Clerk>();
            string storedProcedureName = "GET_Clerk";

            try
            {
                SqlDataReader sr = new DBConnection().ExecuteSelect(storedProcedureName);
                while (sr.Read())
                {
                    Byte[] byted = StrToByteArray(sr["Clerk_password"].ToString());
                    string password = Encoding.Unicode.GetString(byted);
                    Clerk clerk = new Clerk();
                    clerk.Clerk_code = sr["Clerk_code"].ToString();
                    clerk.Clerk_name = sr["Clerk_name"].ToString();
                    clerk.Clerk_job = sr["Clerk_job"].ToString();
                    clerk.Clerk_password = password;
                    clerks.Add(clerk);
                }
                    return clerks;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private byte[] StrToByteArray(string strValue)
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            return encoding.GetBytes(strValue);
        }

        public bool InsertClerk(Clerk clerk)
        {
            string storedProcedureName = "InsertClerk";

            DBConnection con = new DBConnection();
            byte[] password=StrToByteArray(clerk.Clerk_password);
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("Clerk_code", clerk.Clerk_code);
            sqlParameters[1] = new SqlParameter("Clerk_name", clerk.Clerk_name);
            sqlParameters[2] = new SqlParameter("Clerk_job", clerk.Clerk_job);
            sqlParameters[3] = new SqlParameter("Clerk_password", password);

            try
            {
                return con.ExcuteInsert(storedProcedureName, sqlParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateClerk()
        {
            throw new NotImplementedException();
        }

        public bool DeleteClerk(string clerk_code)
        {
            DBConnection con = new DBConnection();
            string storedProcedureName = "DeleteClerk";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("Clerk_code", clerk_code);

            try
            {
                return con.ExecuteUpdateOrDelete(storedProcedureName, sqlParameters);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
