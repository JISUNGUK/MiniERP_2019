using MiniERP.VO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Model.DAO
{
    class BomDAO
    {
        private List<BOM> boms;

        public List<BOM> GetBoms()
        {
            boms = new List<BOM>();
            string storedProcedureName = "GET_BOM";
            DBConnection con = new DBConnection();
            try
            {
                SqlDataReader sr = con.ExecuteSelect(storedProcedureName, null);
                while (sr.Read())
                {
                    boms.Add(new BOM()
                    {
                        Item_code = sr["Item_code"].ToString(),
                        Part_code = sr["Part_code"].ToString(),
                        Part_count = Int32.Parse(sr["Part_count"].ToString())
                    });
                }
                con.Close();
                return boms;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int InsertBom(string itemCode, string partCode, string partCount)
        {
            string storedProcedureName = "INSERT_BOM";
            DBConnection con = new DBConnection();
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("item_code", itemCode),
                new SqlParameter("part_code", partCode),
                new SqlParameter("part_count", partCount)
            };
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
