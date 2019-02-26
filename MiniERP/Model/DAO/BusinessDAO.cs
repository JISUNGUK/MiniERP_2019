using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Model.DAO
{
    class BusinessDAO
    {
        List<Business> businesses;
        
        public List<Business> GetBusiness(Business business)
        {
            businesses = new List<Business>();
            string storedProcedureName = "GET_BUSINESS";
            
            try
            {
                DBConnection con = new DBConnection();

                SqlParameter[] sqlParameters = new SqlParameter[5]
                {
                    new SqlParameter("business_code", business.Code),
                    new SqlParameter("business_name", business.Name),
                    new SqlParameter("business_tel", business.Tel),
                    new SqlParameter("business_email", business.Email),
                    new SqlParameter("business_presenter", business.Presenter)
                };

                SqlDataReader sr = con.ExecuteSelect(storedProcedureName, sqlParameters);
                while (sr.Read())
                {
                    businesses.Add(new Business
                    {
                        Code = sr["Business_code"].ToString(),
                        Name = sr["Business_name"].ToString(),
                        Tel = sr["Business_tel"].ToString(),
                        Addr = sr["Business_addr"].ToString(),
                        Email = sr["Business_email"].ToString(),
                        Presenter = sr["Business_presenter"].ToString()
                    });
                }
                con.Close();
                return businesses;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int InsertBusiness(Business business)
        {
            string storedProcedureName = "InsertBusiness";

            DBConnection con = new DBConnection();

            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("Business_code", business.Code);
            sqlParameters[1] = new SqlParameter("Business_name", business.Name);
            sqlParameters[2] = new SqlParameter("Business_tel", business.Tel);
            sqlParameters[3] = new SqlParameter("Business_addr", business.Addr);
            sqlParameters[4] = new SqlParameter("Business_email", business.Email);
            sqlParameters[5] = new SqlParameter("Business_presenter", business.Presenter);

            try
            {
                return con.ExecuteNonQuery(storedProcedureName, sqlParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int UpdateBusiness()
        {
            throw new NotImplementedException();
        }

        public int DeleteBusiness(string business_code)
        {
            string storedProcedureName = "DeleteBusiness";

            DBConnection con = new DBConnection();

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("Business_code", business_code);

            try
            {
                return con.ExecuteNonQuery(storedProcedureName, sqlParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
