using MiniERP.VO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Model.DAO
{
    class TradeDAO
    {
        List<Trade> tradeList = new List<Trade>();

        public List<Trade> GetTrade(DateTime lowDate, DateTime maxDate, string business_code)
        {
            DBConnection dbCon = new DBConnection();
            SqlParameter[] sqlParameters = {
                new SqlParameter("low_date",lowDate),
                new SqlParameter("max_date",maxDate),
                new SqlParameter("business_code",business_code)
                //new SqlParameter("PageNumber",pageNumber),
                //new SqlParameter("RowsPerPage",rowPerPage)
            };

            SqlDataReader sdr = dbCon.ExecuteSelect("GET_TRADE", sqlParameters);
            List<Trade> trades = new List<Trade>();
            while (sdr.Read())
            {
                Trade row = new Trade();
                row.Trade_code = sdr["Trade_code"].ToString();
                row.Business_code = sdr["Business_code"].ToString();
                row.Business_name = sdr["Business_name"].ToString();
                row.Total_fee = Convert.ToInt32(sdr["Total_fee"]);
                row.Trade_status = sdr["Trade_status"].ToString();
                row.Trade_standard = sdr["Trade_standard"].ToString();
                row.Item_summary = sdr["item_summary"].ToString();
                row.Warehouse_code = sdr["Warehouse_code"].ToString();
                row.Warehouse_name = sdr["Warehouse_name"].ToString();
                row.Clerk_code = sdr["Clerk_code"].ToString();
                row.Clerk_name = sdr["Clerk_name"].ToString();
                //row.End_date = (DateTime)sdr["End_date"];
                trades.Add(row);
            }
            return trades;
        }

        //public List<Trade> GetProgTrade(string standard,int pageNumber, int rowPerPage)
        public List<Trade> GetProgTrade(string standard)
        {
            DBConnection dbCon = new DBConnection();
            SqlParameter[] sqlParameters = {
                new SqlParameter("trade_standard",standard),
                //new SqlParameter("PageNumber",pageNumber),
                //new SqlParameter("RowsPerPage",rowPerPage)
            };

            SqlDataReader sdr = dbCon.ExecuteSelect("GET_PROG_TRADE", sqlParameters);
            List<Trade> trades = new List<Trade>();
            while (sdr.Read())
            {
                Trade row = new Trade();
                row.Trade_code = sdr["Trade_code"].ToString();
                row.Business_code = sdr["Business_code"].ToString();
                row.Business_name = sdr["Business_name"].ToString();
                row.Total_fee = Convert.ToInt32(sdr["Total_fee"]);
                row.Trade_status = sdr["Trade_status"].ToString();
                row.Item_summary = sdr["item_summary"].ToString();
                row.Warehouse_code = sdr["Warehouse_code"].ToString();
                row.Warehouse_name = sdr["Warehouse_name"].ToString();
                row.Clerk_code = sdr["Clerk_code"].ToString();
                row.Clerk_name = sdr["Clerk_name"].ToString();
                trades.Add(row);
            }
            return trades;
        }

        public int UpdateTrade(Trade trade)
        {
            MiniErpDB miniErpDB = new MiniErpDB();

            try
            {
                return miniErpDB.MODIFY_TRADE(trade.Trade_code, trade.Clerk_code, trade.Warehouse_code, trade.Trade_status);
            }
            catch
            {
                throw;
            }
        }
    }
}