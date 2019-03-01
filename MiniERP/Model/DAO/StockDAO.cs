using MiniERP.VO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Model.DAO
{
    class StockDAO
    {
        List<Stock> stocks = new List<Stock>();

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
