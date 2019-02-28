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

        public List<Clerk> GetClerk(Clerk clerk)
        {
            clerks = new List<Clerk>();
            string storedProcedureName = "GET_CLERK";

            try
            {
                DBConnection con = new DBConnection();

                SqlParameter[] sqlParameters = new SqlParameter[2]
                {
                new SqlParameter("Clerk_name", clerk.Clerk_name),
                new SqlParameter("Clerk_job", clerk.Clerk_job)
                };

                SqlDataReader sr = con.ExecuteSelect(storedProcedureName, sqlParameters);
                while (sr.Read())
                {
                    clerks.Add(new Clerk
                    {
                        Clerk_code = sr["Clerk_code"].ToString(),
                        Clerk_name = sr["Clerk_name"].ToString(),
                        Clerk_job = sr["Clerk_job"].ToString(),
                        Clerk_password = sr["Clerk_password"].ToString()
                    });
                }
                con.Close();
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

        public int InsertClerk(Clerk clerk)
        {
            string storedProcedureName = "InsertClerk";

            DBConnection con = new DBConnection();

            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("Clerk_code", clerk.Clerk_code);
            sqlParameters[1] = new SqlParameter("Clerk_name", clerk.Clerk_name);
            sqlParameters[2] = new SqlParameter("Clerk_job", clerk.Clerk_job);
            sqlParameters[3] = new SqlParameter("Clerk_password", clerk.Clerk_password);

            try
            {
                return con.ExecuteNonQuery(storedProcedureName, sqlParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int UpdateClerk(Clerk clerk)
        {
            string storedProcedureName = "UpdateClerk";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("Clerk_code",clerk.Clerk_code),
                new SqlParameter("Clerk_name",clerk.Clerk_name),
                new SqlParameter("Clerk_job",clerk.Clerk_job)
            };
            DBConnection con = new DBConnection();
            try
            {
                return con.ExecuteNonQuery(storedProcedureName, sqlParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int DeleteClerk(string clerk_code)
        {
            DBConnection con = new DBConnection();
            string storedProcedureName = "DeleteClerk";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("Clerk_code", clerk_code);

            try
            {
                return con.ExecuteNonQuery(storedProcedureName, sqlParameters);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 등록하려는 사원이 이미 테이블에 존재하는지 확인하기 위한 메서드입니다.
        /// </summary>
        /// <param name="clerkCode">등록하려는 사원의 코드입니다.</param>
        /// <returns>사원코드로 Clerk테이블을 조회했을 때 나오는 행의 개수를 반환합니다.</returns>
        public bool CheckClerkData(string clerkCode)
        {
            string storedProcedureName = "Check_ClerkData";

            DBConnection con = new DBConnection();
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("clerk_code", clerkCode)
            };
            try
            {
                return con.ExecuteSelect(storedProcedureName, sqlParameters).HasRows;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
