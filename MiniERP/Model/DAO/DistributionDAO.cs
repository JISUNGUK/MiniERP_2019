using MiniERP.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 구현: 조성호
 * 물류 관련 DAO클래스
 * 완료일: 2019-02-29
 */
namespace MiniERP.Model.DAO
{
    class DistributionDAO
    {
        /// <summary>
        /// 물류등록 함수
        /// </summary>
        /// <param name="dist">물류등록 프로시저의 매개변수</param>
        public void SET_DISTRIBUTION(Distribution dist)
        {
            MiniErpDB db = new MiniErpDB();

            try
            {
                db.SET_DISTRIBUTION(null, dist.Before_warehouse_code, dist.After_warehouse_code, dist.Item_code, dist.Dist_count, dist.Move_date);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
