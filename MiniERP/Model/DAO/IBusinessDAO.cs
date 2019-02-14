using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Model.DAO
{
    interface IBusinessDAO
    {
        List<Business> GetBusiness();

        bool InsertBusiness(Business business);

        bool UpdateBusiness();

        bool DeleteBusiness(string business_code);
    }
}
