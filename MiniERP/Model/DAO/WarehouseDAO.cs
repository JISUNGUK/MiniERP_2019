using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniERP;

namespace MiniERP.Model.DAO
{
    class WarehouseDAO
    {
        List<MiniERP.Warehouse> warehouses;

        public List<MiniERP.Warehouse> GetWarehouses(MiniERP.Warehouse warehouse)
        {
            warehouses = new List<MiniERP.Warehouse>();
            string storedProcedureName = "GET_WAREHOUSE";

            try
            {
                DBConnection con = new DBConnection();

                SqlParameter[] sqlParameters = new SqlParameter[3]
                {
                    new SqlParameter("warehouse_code", warehouse.Warehouse_code),
                    new SqlParameter("warehouse_name", warehouse.Warehouse_name),
                    new SqlParameter("warehouse_standard", warehouse.Warehouse_standard)
                };
                SqlDataReader sr = con.ExecuteSelect(storedProcedureName, sqlParameters);
                while(sr.Read())
                {
                    warehouses.Add(new MiniERP.Warehouse
                    {
                        Warehouse_code = sr["Warehouse_code"].ToString(),
                        Warehouse_name = sr["Warehouse_name"].ToString(),
                        Warehouse_standard = sr["Warehouse_standard"].ToString()
                    });
                }
                con.Close();
                return warehouses;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int InsertWarehouse(MiniERP.Warehouse warehouse)
        {
            string storedProcedureName = "InsertWarehouse";

            DBConnection con = new DBConnection();

            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("Warehouse_code", warehouse.Warehouse_code);
            sqlParameters[1] = new SqlParameter("Warehouse_name", warehouse.Warehouse_name);
            sqlParameters[2] = new SqlParameter("Warehouse_standard", warehouse.Warehouse_standard);

            try
            {
                return con.ExecuteNonQuery(storedProcedureName, sqlParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int UpdateWarehouse(Warehouse warehouse)
        {
            string storedProcedureName = "UpdateWarehouse";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("Warehouse_code", warehouse.Warehouse_code),
                new SqlParameter("Warehouse_name", warehouse.Warehouse_name),
                new SqlParameter("Warehouse_standard", warehouse.Warehouse_standard)
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

        public int DeleteWarehouse(string warehouse_code)
        {
            DBConnection con = new DBConnection();
            string storedProcedureName = "DeleteWarehouse";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("Warehouse_code", warehouse_code);

            try
            {
                return con.ExecuteNonQuery(storedProcedureName, sqlParameters);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool CheckWarehouseData(string warehouseCode)
        {
            string storedProcedureName = "Check_WarehouseData";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("warehouse_code", warehouseCode)
            };
            DBConnection con = new DBConnection();
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
