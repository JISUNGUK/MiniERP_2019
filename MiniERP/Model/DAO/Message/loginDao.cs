using MiniERP.VO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Model.DAO.Message
{
    class loginDao
    {
        List<Clerk> clerks;

        /// <summary>
        /// 사원 id,비밀번호를 입력받아 해당 사원의 이름과 직책을 출력받음
        /// </summary>
        /// <param name="clerk"></param>
        /// <returns></returns>
        public List<Clerk> GetClerk(Clerk clerk)
        {
            clerks = new List<Clerk>();
            string storedProcedureName = "Clerk_password_check";

            try
            {
                DBConnection con = new DBConnection();

                SqlParameter[] sqlParameters = new SqlParameter[2]
                {
                new SqlParameter("Clerk_code", clerk.Clerk_code),
                new SqlParameter("Clerk_password", clerk.Clerk_password)
                };

                SqlDataReader sr = con.ExecuteSelect(storedProcedureName, sqlParameters);
                while (sr.Read())
                {                   
                    clerks.Add(new Clerk
                    {                      
                        Clerk_name = sr["Clerk_name"].ToString(),
                        Clerk_job = sr["Clerk_job"].ToString(),
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
    }
}
