using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniERP.VO;

namespace MiniERP.Model.DAO
{
    class ItemDAO
    {
        private List<Item> items;

        public List<Item> GetItems(string itemCodeOrName)
        {
            items = new List<Item>();
            string storedProcedureName = "GET_ITEM";

            try
            {
                DBConnection con = new DBConnection();
                SqlParameter[] sqlParameters = new SqlParameter[3]
                {
                    new SqlParameter("search", itemCodeOrName),
                    new SqlParameter("PageNumber", null),
                    new SqlParameter("RowsPerPage", null)
                };
                SqlDataReader sr = con.ExecuteSelect(storedProcedureName, sqlParameters);
                while (sr.Read())
                {
                    Item item = new Item();
                    item.Item_code = sr["Item_code"].ToString();
                    item.Item_name = sr["Item_name"].ToString();
                    item.Item_standard = sr["Item_standard"].ToString();
                    item.Item_unit = sr["Item_unit"].ToString();
                    item.Item_class = sr["Item_class"].ToString();
                    item.Item_fee = Int32.Parse(sr["Item_fee"].ToString());
                    item.Stock_count = Int32.Parse(sr["Stock_count"].ToString());
                    // item.Item_image
                    item.Item_group = sr["Item_group"].ToString();
                    item.Item_comment = sr["Item_comment"].ToString();
                    items.Add(item);
                }
                return items;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int InsertItem(Item item)
        {
            string procedureName = "InsertItem";

            DBConnection con = new DBConnection();

            ImageConverter imageConverter = new ImageConverter();
            byte[] bytes = null;
            if(item.Item_image != null)
            {
                bytes = (byte[])imageConverter.ConvertTo(item.Item_image, typeof(byte[]));
            }

            SqlParameter[] sqlParameters = 
            {
                new SqlParameter("item_code", item.Item_code),
                new SqlParameter("item_name", item.Item_name),
                new SqlParameter("item_standard", item.Item_standard),
                new SqlParameter("item_unit", item.Item_unit),
                new SqlParameter("item_class", item.Item_class),
                new SqlParameter("item_fee", item.Item_fee),
                new SqlParameter("item_image", bytes),
                new SqlParameter("item_group", item.Item_group),
                new SqlParameter("item_comment", item.Item_comment)
            };

            try
            {
                return con.ExecuteNonQuery(procedureName, sqlParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
