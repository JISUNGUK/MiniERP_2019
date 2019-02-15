using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Model.DAO
{
    class WarehouseDAO : Interface.IWarehouseDAO
    {
        List<Warehouse> warehouses;

        public List<Warehouse> GetWarehouses()
        {
            warehouses = new List<Warehouse>();
            string storedProcedureName = "GET_WAREHOUSE";

            try
            {
                SqlDataReader sr = new DBConnection().ExecuteSelect(storedProcedureName);
                while(sr.Read())
                {
                    warehouses.Add(new Warehouse
                    {
                        Warehouse_code = sr["Warehouse_code"].ToString(),
                        Warehouse_name = sr["Warehouse_name"].ToString(),
                        Warehouse_standard = sr["Warehouse_standard"].ToString()
                    });
                }
                return warehouses;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool InsertWarehouse(Warehouse warehouse)
        {
            string storedProcedureName = "InsertWarehouse";

            DBConnection con = new DBConnection();

            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("Warehouse_code", warehouse.Warehouse_code);
            sqlParameters[1] = new SqlParameter("Warehouse_name", warehouse.Warehouse_name);
            sqlParameters[2] = new SqlParameter("Warehouse_standard", warehouse.Warehouse_standard);

            try
            {
                return con.ExcuteInsert(storedProcedureName, sqlParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateWarehouse()
        {
            throw new NotImplementedException();
        }

        public bool DeleteWarehouse(string warehouse_code)
        {
            DBConnection con = new DBConnection();
            string storedProcedureName = "DeleteWarehouse";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("Warehouse_code", warehouse_code);

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
