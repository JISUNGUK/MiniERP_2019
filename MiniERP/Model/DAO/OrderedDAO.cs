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

            return ordereds;
        }

        //abstract public void InsertOrdered();
        //abstract public void DeleteOrdered();
    }
}
