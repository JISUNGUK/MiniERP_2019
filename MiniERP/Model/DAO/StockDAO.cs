using MiniERP.VO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 구현: 조성호
 * 재고 관련 DAO클래스
 * 완료일: 2019-02-22
 */
namespace MiniERP.Model.DAO
{
    class StockDAO
    {
        List<Stock> stocks = new List<Stock>();

        /// <summary>
        /// 재고등록 함수
        /// </summary>
        /// <param name="item_code">재고등록 프로시저 매개변수 - 품목번호</param>
        /// <param name="warehouse_code">재고등록 프로시저 매개변수 - 창고번호</param>
        /// <param name="stock_count">재고등록 프로시저 매개변수 - 품목갯수</param>
        public void Set_Stock_Item(string item_code, string warehouse_code, int stock_count)
        {
            MiniErpDB miniErp = new MiniErpDB();
            try
            {
                miniErp.SET_STOCK_ITEM(item_code, warehouse_code, stock_count);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 재고 데이터 조회 함수
        /// </summary>
        /// <param name="warehouse_code">재고조회 프로시저 매개변수 - 창고번호</param>
        /// <param name="item_code">재고조회 프로시저 매개변수 - 품목번호</param>
        /// <returns></returns>
        public List<Stock> Get_Stock(string warehouse_code,string item_code)
        {
            MiniErpDB miniErp = new MiniErpDB();
            try
            {
                var result = miniErp.GET_STOCK(warehouse_code, item_code);
                foreach (var item in result)
                {
                    Stock stock = new Stock();
                    stock.Item_code = item.Item_code;
                    stock.Stock_name = item.Item_name;
                    stock.Warehouse_code = item.Warehouse_code;
                    stock.Warehouse_name = item.Warehouse_name;
                    stock.Stock_standard = item.Item_standard;
                    stock.Stock_count = item.Stock_count;

                    stocks.Add(stock);
                }

                return stocks;
            }
            catch
            {
                throw;
            }
        }
    }
}
