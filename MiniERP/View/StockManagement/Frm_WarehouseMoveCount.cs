using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 구현: 조성호
 * 재고등록폼에서 사용하는 갯수설정 폼
 * 완료일: 2019-03-01
 */
namespace MiniERP.View.StockManagement
{
    /// <summary>
    /// 생성자로 받은 매개변수만큼 최대값을 설정하여 범위내에서 선택한 숫자를 반환하는 폼클래스
    /// </summary>
    public partial class Frm_WarehouseMoveCount : Form
    {
        public Frm_WarehouseMoveCount(int MaxNum)
        {
            InitializeComponent();
            num_updown.Maximum = MaxNum;
            num_updown.Value = MaxNum;
        }

        int returnNum = 0;
        public int ReturnNum { get => returnNum; }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if(num_updown.Value != 0)
            {
                returnNum = Convert.ToInt32(num_updown.Value);
                this.Close();
            }
            else
            {
                MessageBox.Show("선택된 값이 1 이상이어야합니다.");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
