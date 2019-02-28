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
        private List<BOM> boms; // DataGridView에 표시되는, Bom테이블의 모든 내용을 저장할 리스트입니다.
        private List<BOM> bomDetail; // Frm_BomDetail에 넘겨줄, 선택한 품목을 만드는데 필요한 파츠 리스트를 저장할 변수입니다.

        public List<BOM> GetBoms(BOM bom)
        {
            boms = new List<BOM>();
            string storedProcedureName = "GET_BOM";
            DBConnection con = new DBConnection();
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("item_code", bom.Item_code),
                new SqlParameter("part_code", bom.Part_code)
            };
            try
            {
                SqlDataReader sr = con.ExecuteSelect(storedProcedureName, sqlParameters);
                while (sr.Read())
                {
                    boms.Add(new BOM()
                    {
                        Item_code = sr["Item_code"].ToString(),
                        Item_name = sr["Item_name"].ToString()
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

        public List<BOM> GetBomDetail(string itemCode)
        {
            bomDetail = new List<BOM>();
            string storedProcedureName = "GET_BomDetail";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("item_code", itemCode)
            };
            DBConnection con = new DBConnection();
            try
            {
                SqlDataReader sr = con.ExecuteSelect(storedProcedureName, sqlParameters);
                while (sr.Read())
                {
                    bomDetail.Add(new BOM()
                    {
                        Part_code = sr["Part_code"].ToString(),
                        Part_name = sr["Item_name"].ToString(),
                        Part_count = Int32.Parse(sr["Part_count"].ToString())
                    });
                }
                con.Close();
                return bomDetail;
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

        public int DeleteBom(string itemCode)
        {
            string storedProcedureName = "DeleteBom";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("item_code", itemCode)
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

        public List<BOM> GetBomSimple(string codeOrName)
        {
            boms = new List<BOM>();
            string storeProcedureName = "GET_BOM_SIMPLE";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("code_name", codeOrName)
            };
            DBConnection con = new DBConnection();
            try
            {
                SqlDataReader sr = con.ExecuteSelect(storeProcedureName, sqlParameters);
                while (sr.Read())
                {
                    boms.Add(new BOM()
                    {
                        Item_code = sr["Item_code"].ToString(),
                        Item_name = sr["Item_name"].ToString()
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
    }
}
