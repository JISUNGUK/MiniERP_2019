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
     *  오더추가 / 오더검색 /오더 삭제?
     *
     */

    class OrderedDAO
    {
        List<Ordered> ordereds = new List<Ordered>();

        public List<Ordered> SelectAllOrdered()
        {
            ordereds.Clear();

            DBConnection conn = new DBConnection();
            SqlDataReader reader = conn.SelectQuery("select * from ordered");

            while (reader.Read())
            {
                Ordered order = new Ordered();
                order.Order_Code = reader[0].ToString();
                order.Business_Code = reader[1].ToString();

                ordereds.Add(order);
            }
            conn.Close();
            return ordereds;
        }

        public List<SampleOrder> SelectSampleOrdered(string order_Code)
        {
            List<SampleOrder> sampleOrders = new List<SampleOrder>();

            DBConnection conn = new DBConnection();
            SqlParameter[] sqlParameter = { new SqlParameter("@Order_code", order_Code) };

            SqlDataReader reader = conn.ExecuteSelect("GET_ORDER", sqlParameter);
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
        //abstract public void InsertOrdered();
        //abstract public void DeleteOrdered();
    }
}
