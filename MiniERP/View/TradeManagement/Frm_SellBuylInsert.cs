using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniERP.VO;

namespace MiniERP.View.TradeManagement
{
    public partial class Frm_SellBuyInsert : Form
    {
        public Frm_SellBuyInsert()
        {
            InitializeComponent();
        }

        #region 라디오박스 이벤트
        private void rdo_Sell_CheckedChanged(object sender, EventArgs e)
        {
            lab_Warehouse.Text = "출고창고";
        }

        private void rdo_Buy_CheckedChanged(object sender, EventArgs e)
        {
            lab_Warehouse.Text = "입고창고";
        }
        #endregion

        /// <summary>
        /// 다시작성 버튼클릭 이벤트, 텍스트박스와 그리드뷰를 Clear 한다
        /// </summary>
        private void btn_Cleaner_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    ((TextBox)item).Clear();
                }
                else if (item.GetType() == typeof(DataGridView))
                {
                    ((DataGridView)item).Rows.Clear();
                }
            }
        }

        #region 품목 갯수 변경시 총액합구하기
        private void gView_Order_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (gView_Order.RowCount > 0)
            {
                Get_TotalFee();
            }
            else
            {
                lab_TotalPrice.Text = "0";
            }
        }

        private void Get_TotalFee()
        {
            int totalFee = 0;
            if (gView_Order.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in gView_Order.Rows)
                {
                    totalFee += Convert.ToInt32(item.Cells["totalFee"].Value);
                }
            }
            lab_TotalPrice.Text = string.Format("{0:n0}", totalFee);
        }
        #endregion

        /// <summary>
        /// 그리드뷰 체크박스 체크이벤트
        /// </summary>
        private void gView_Order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                gView_Order.Rows[e.RowIndex].Cells["Select"].Value = (bool)gView_Order.Rows[e.RowIndex].Cells["Select"].Value ? false : true;
            }
        }

        private void btn_Text_Click(object sender, EventArgs e)
        {
            Form frm;
            if (((Button)sender).Name.Contains("Clerk"))
            {
                frm = new Frm_ClerkSelect();
                if (frm.ShowDialog() != DialogResult.Cancel)
                {
                    this.txt_ClerkCode.Text = ((Frm_ClerkSelect)frm).Clerk.Clerk_code;
                    this.txt_ClerkName.Text = ((Frm_ClerkSelect)frm).Clerk.Clerk_name;
                }
            }
            else if (((Button)sender).Name.Contains("Business"))
            {
                frm = new Frm_BusinessSelect();
                if (frm.ShowDialog() != DialogResult.Cancel)
                {
                    this.txt_BusinessCode.Text = ((Frm_BusinessSelect)frm).Business.Code;
                    this.txt_BusinessName.Text = ((Frm_BusinessSelect)frm).Business.Name;
                }
            }
            else if (((Button)sender).Name.Contains("Warehouse"))
            {
                frm = new Frm_WarehouseSelect();
                if (frm.ShowDialog() != DialogResult.Cancel)
                {
                    this.txt_WareCode.Text = ((Frm_WarehouseSelect)frm).Warehouse.Warehouse_code;
                    this.txt_WareName.Text = ((Frm_WarehouseSelect)frm).Warehouse.Warehouse_name;
                }
            }
        }

        private void btn_ItemAdd_Click(object sender, EventArgs e)
        {
            Frm_ItemSelect frm = new Frm_ItemSelect();
            if (frm.ShowDialog() != DialogResult.Cancel)
            {
                VO.Item item = frm.SelectItem;
                SetGridView(item);
            }
        }

        /// <summary>
        /// 그리드뷰 품목데이터 추가 함수
        /// </summary>
        private void SetGridView(Item item)
        {
            bool check = true;
            foreach (DataGridViewRow row in gView_Order.Rows)
            {
                if (row.Cells["code"].Value.ToString() == item.Item_code)
                {
                    check = false;
                    break;
                }
            }

            if (check)
            {
                gView_Order.Rows.Add(false, item.Item_code, item.Item_name, item.Item_unit, item.Item_standard, 0, item.Item_fee, 0);
            }
        }

        private void btn_ItemDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in gView_Order.Rows)
            {
                if ((bool)item.Cells["select"].Value)
                {
                    gView_Order.Rows.Remove(item);
                }
            }
        }

        private void gView_Order_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (gView_Order.Columns[e.ColumnIndex].Name.Contains("count"))
            {
                gView_Order.Rows[e.RowIndex].Cells["totalfee"].Value = Convert.ToInt32(gView_Order.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) * Convert.ToInt32(gView_Order.Rows[e.RowIndex].Cells["fee"].Value);
                Get_TotalFee();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Valiable_Check())
            {
                string standard = String.Empty; //판매 or 구매
                string code = String.Empty; // 품목코드문자열, 구분자 |
                string count = String.Empty; // 품목갯수문자열, 구분자 |

                // 거래구분
                if (rdo_Buy.Checked)
                {
                    standard = "구매";
                }
                else
                {
                    standard = "판매";
                }

                // 품목코드/갯수 문자열
                foreach (DataGridViewRow item in gView_Order.Rows)
                {
                    code += item.Cells["code"].Value.ToString() + "|";
                    count += item.Cells["count"].Value.ToString() + "|";
                }
                code = code.Substring(0, code.Length - 1);
                count = count.Substring(0, count.Length - 1);
                //MessageBox.Show("거래처코드: " + txt_BusinessCode.Text);
                //MessageBox.Show("사원코드: " + txt_ClerkCode.Text);
                //MessageBox.Show("창고코드: " + txt_WareCode.Text);
                //MessageBox.Show("구분: " + standard);
                //MessageBox.Show("품목문자열: " + code);
                //MessageBox.Show("갯수문자열: " + count);

                Model.DAO.OrderedDAO order = new Model.DAO.OrderedDAO();
                try
                {
                    order.InsertOrdered(txt_BusinessCode.Text, txt_ClerkCode.Text, txt_WareCode.Text, standard, code, count);
                    MessageBox.Show("주문완료");
                }
                catch (Exception)
                {
                    MessageBox.Show("DB오류발생");
                }
            }
        }

        private bool Valiable_Check()
        {
            if (String.IsNullOrWhiteSpace(txt_ClerkCode.Text))
            {
                MessageBox.Show("담당자를 선택해주세요");
                btn_Clerk.Focus();
                return false;
            }
            else if (String.IsNullOrWhiteSpace(txt_BusinessCode.Text))
            {
                MessageBox.Show("거래처를 선택해주세요");
                btn_Business.Focus();
                return false;
            }
            else if (String.IsNullOrWhiteSpace(txt_WareCode.Text))
            {
                MessageBox.Show(lab_Warehouse.Text + "를 선택해주세요");
                btn_Warehouse.Focus();
                return false;
            }
            else if (gView_Order.Rows.Count < 1)
            {
                foreach (DataGridViewRow item in gView_Order.Rows)
                {
                    if (Convert.ToInt32(item.Cells["count"].Value) < 1)
                    {
                        MessageBox.Show("품목의 갯수는 0개 이상이어야 합니다");
                        item.Cells["count"].Selected = true;
                        return false;
                    }
                }
                MessageBox.Show("품목이 하나 이상 필요합니다");
                btn_ItemAdd.Focus();
                return false;
            }
            return true;
        }
    }
}
