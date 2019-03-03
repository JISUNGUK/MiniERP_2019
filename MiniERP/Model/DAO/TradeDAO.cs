using MiniERP.VO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 구현: 조성호
 * 거래 관련 DAO클래스
 * 완료일: 2019-02-22
 */
namespace MiniERP.Model.DAO
{
    class TradeDAO
    {
        List<Trade> tradeList = new List<Trade>();

        /// <summary>
        /// 거래조회 함수
        /// </summary>
        /// <param name="lowDate">거래조회 프로시저 매개변수 - 최소날짜 </param>
        /// <param name="maxDate">거래조회 프로시저 매개변수 - 최대날짜 </param>
        /// <param name="business_code">거래조회 프로시저 매개변수 - 거래처번호</param>
        /// <returns></returns>
        public List<Trade> GetTrade(DateTime lowDate, DateTime maxDate, string business_code)
        {
            DBConnection dbCon = new DBConnection();
            SqlParameter[] sqlParameters = {
                new SqlParameter("low_date",lowDate),
                new SqlParameter("max_date",maxDate),
                new SqlParameter("business",business_code)
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
                row.End_date_str = sdr["End_date"].ToString();
                if (!String.IsNullOrWhiteSpace(sdr["End_date"].ToString()))
                {
                    row.End_date = (DateTime)sdr["End_date"];
                }

                trades.Add(row);
            }
            return trades;
        }

        //public List<Trade> GetProgTrade(string standard,int pageNumber, int rowPerPage)
        /// <summary>
        /// 진행중인 거래 조회 함수
        /// </summary>
        /// <param name="standard">진행중인거래조회 프로시저 매개변수 - 거래상태(구매/판매)</param>
        /// <returns></returns>
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

        /// <summary>
        /// 거래수정 함수
        /// </summary>
        /// <param name="trade">거래수정 프로시저 매개변수 - 거래객체</param>
        /// <returns></returns>
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