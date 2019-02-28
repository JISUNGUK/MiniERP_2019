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
        List<Status> statusList = new List<Status>();
        public StatusList(string standard_menu)
        {
            SetStatus(standard_menu);
        }

        public List<Status> GetStatus(string status)
        {
            List<Status> returnStatus = new List<Status>();
            if (status != "취소")
            {
                int no = 0;

                foreach (var item in statusList)
                {
                    if (item.StatusStr.Equals(status))
                    {
                        no = item.No;
                        break;
                    }
                }

                foreach (var item in statusList)
                {
                    if (item.StatusStr == status || item.No == no + 1)
                    {
                        returnStatus.Add(item);
                    }
                }
            }
            return returnStatus;
        }

        private void SetStatus(string standard_menu)
        {
            
            if(standard_menu == "판매")
            {
                statusList.AddRange(new Status[]{
                    new Status(1,"승인전"),
                    new Status(2,"승인"),
                    new Status(2,"취소"),
                    new Status(3,"생산"),
                    new Status(3,"출하대기중"),
                    new Status(3,"취소"),
                    new Status(4,"출하완료"),
                    new Status(4,"취소"),
                    new Status(5,"반품"),
                    new Status(5,"완료"),
                });
            }
            else if(standard_menu == "구매")
            {
                statusList.AddRange(new Status[]{
                    new Status(1,"승인전"),
                    new Status(2,"주문완료"),
                    new Status(2,"취소"),
                    new Status(3,"입고대기"),
                    new Status(3,"취소"),
                    new Status(4,"입고완료"),
                    new Status(5,"완료")
                });
            }
            else if(standard_menu == "물류")
            {
                statusList.AddRange(new Status[]{
                    new Status(1,"대기"),
                    new Status(2,"출고"),
                    new Status(2,"취소"),
                    new Status(3,"완료"),
                    new Status(3,"취소")
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
        }
    }
}
