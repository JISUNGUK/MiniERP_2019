using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Model.DAO
{
    interface IWarehouseDAO
    {
        /// <summary>
        /// Warehouse 테이블의 모든 내용을 얻어옵니다.
        /// </summary>
        /// <returns></returns>
        List<Warehouse> GetWarehouses();

        /// <summary>
        /// Warehouse 테이블에 새로운 정보를 등록합니다.
        /// </summary>
        /// <param name="warehouse"></param>
        /// <returns></returns>
        bool InsertWarehouse(Warehouse warehouse);

        bool UpdateWarehouse();

        bool DeleteWarehouse(string warehouse_code);
    }
}
