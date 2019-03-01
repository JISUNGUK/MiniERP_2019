using MiniERP.VO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Model.DAO
{
    /*
     *  모든 반환형은 List형태로 내보낼 것
     *  오더코드 , 거래처 코드
     * 
     *  오더추가 / 오더검색
     *
     */

    class OrderedDAO
    {
        public List<Ordered> SelectAllOrdered()
        {
            List<Ordered> ordereds = new List<Ordered>();

            DBConnection conn = new DBConnection();
            SqlDataReader reader = conn.ExecuteSelect("Get_ALL_ORDERLIST");

            while (reader.Read())
            {
                Ordered order = new Ordered();
                order.Order_Code = reader[0].ToString();
                order.Business_Code = reader[1].ToString();
                order.Business_name = reader[2].ToString();

                ordereds.Add(order);
            }
            conn.Close();
            return ordereds;
        }

        public List<SampleOrder> SelectSampleOrdered(string order_Code)
        {
            DBConnection conn = new DBConnection();
            SqlParameter[] sqlParameter = { new SqlParameter("@Order_code", order_Code) };
            SqlDataReader reader = conn.ExecuteSelect("GET_ORDER", sqlParameter);

            List<SampleOrder> sampleOrders = new List<SampleOrder>();
            while (reader.Read()) 
            {
                SampleOrder sample = new SampleOrder();

                sample.Order_Code = order_Code;
                sample.Item_Code = reader[0].ToString();
                sample.Item_Name = reader[1].ToString();
                sample.Item_Count = Int32.Parse(reader[2].ToString());
                sample.Item_Wrote_Fee = Int32.Parse(reader[3].ToString());
                
                sampleOrders.Add(sample);
            }
            return sampleOrders;
        }

        /// <summary>
        /// 주문등록 함수
        /// </summary>
        /// <param name="business_code">거래처번호</param>
        /// <param name="clerk_code">담당자(사원)번호</param>
        /// <param name="warehouse_code">출고(입고)창고번호</param>
        /// <param name="trade_standard">거래구분(구매/판매)</param>
        /// <param name="item_code">품목번호(구분자 |를 이용하여 입력)</param>
        /// <param name="item_count">품목갯수(구분자 |를 이용하여 입력)</param>
        public void InsertOrdered(string business_code,string clerk_code,string warehouse_code,string trade_standard, string item_code, string item_count)
        {
            //유효성 검사

            //--------------
            DBConnection dbCon = new DBConnection();
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("business_code",business_code),
                new SqlParameter("clerk_code",clerk_code),
                new SqlParameter("warehouse_code",warehouse_code),
                new SqlParameter("trade_standard",trade_standard),
                new SqlParameter("item_code",item_code),
                new SqlParameter("item_count",item_count)
            };

            try
            {
                dbCon.ExecuteNonQuery("SET_ORDER", sqlParameters);
            }
            catch
            {
                throw;
            }
        }
    }
}
