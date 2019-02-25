using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 구분에 따라 상태목록 컬렉션(List)를 반환하는 클래스
namespace MiniERP.VO
{
    class StatusList
    {
        public List<Status> GetStatus(string standard_menu)
        {
            List<Status> statusList = new List<Status>();
            if(standard_menu == "판매")
            {
                statusList.AddRange(new Status[]{
                    new Status(1,"승인 전"),
                    new Status(2,"승인"),
                    new Status(3,"생산"),
                    new Status(4,"출하대기중"),
                    new Status(5,"출하완료"),
                    new Status(6,"반품"),
                    new Status(7,"완료"),
                    new Status(8,"취소")
                });
            }
            else if(standard_menu == "구매")
            {
                statusList.AddRange(new Status[]{
                    new Status(1,"승인 전"),
                    new Status(2,"주문완료"),
                    new Status(3,"입고대기중"),
                    new Status(4,"입고완료"),
                    new Status(5,"완료"),
                    new Status(6,"취소")
                });
            }
            else if(standard_menu == "물류")
            {
                statusList.AddRange(new Status[]{
                    new Status(1,"대기"),
                    new Status(2,"출고"),
                    new Status(3,"완료")
                });
            }
            else if(standard_menu == "창고")
            {
                statusList.AddRange(new Status[]{
                    new Status(1,"창고"),
                    new Status(2,"공장"),
                    new Status(3,"거래처")
                });
            }

            return statusList;
        }
    }
}
