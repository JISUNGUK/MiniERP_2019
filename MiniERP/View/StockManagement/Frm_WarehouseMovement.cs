using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniERP.Model;
using MiniERP.Model.DAO;
using MiniERP.VO;

namespace MiniERP.View.StockManagement
{
    public partial class Frm_WarehouseMovement : Form
    {
        public Frm_WarehouseMovement()
        {
            InitializeComponent();
        }

        List<Warehouse> warehouses = new List<Warehouse>();
        List<Stock> stocks = new List<Stock>();

        private void Frm_WarehouseMovement_Load(object sender, EventArgs e)
        {
            dt_moveDate.MinDate = DateTime.Now;
            SettingCombo();
        }

        /// <summary>
        /// 콤보박스를 세팅하는 함수
        /// </summary>
        private void SettingCombo()
        {
            WarehouseDAO warehouseDAO = new WarehouseDAO();
            warehouses = warehouseDAO.GetWarehouses(new Warehouse());
            foreach (var item in warehouses)
            {
                cmb_before.Items.Add(item.Warehouse_name);
            }
        }

        /// <summary>
        /// 선택한 출고창고의 재고목록을 lv_before에 추가하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_before_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv_afterStock.Items.Clear();
            lv_beforeStock.Items.Clear();

            foreach (var item in warehouses)
            {
                if (item.Warehouse_name == cmb_before.SelectedItem.ToString())
                {
                    StockDAO stockDAO = new StockDAO();
                    stocks = stockDAO.Get_Stock(item.Warehouse_code, "");
                    foreach (var subitem in stocks)
                    {
                        Lv_Before_Add(subitem);
                    }
                    break;
                }
            }
        }

        #region 리스트뷰에 아이템 추가하는 함수
        private void Lv_Before_Add(Stock item)
        {
            string[] itemArr = { item.Item_code, item.Stock_name, item.Stock_count.ToString() };
            ListViewItem lvItem = new ListViewItem(itemArr);
            lv_beforeStock.Items.Add(lvItem);
        }
        private void Lv_After_Add(Stock item)
        {
            string[] itemArr = { item.Item_code, item.Stock_name, item.Stock_count.ToString() };
            ListViewItem lvItem = new ListViewItem(itemArr);
            lv_afterStock.Items.Add(lvItem);
        }
        #endregion

        /// <summary>
        /// 현재 선택된 창고를 제외한 창고목록을 추가하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_after_DropDown(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(cmb_before.SelectedItem.ToString()))
            {
                cmb_after.Items.Clear();
                foreach (var item in cmb_before.Items)
                {
                    if (item.ToString() != cmb_before.SelectedItem.ToString())
                    {
                        cmb_after.Items.Add(item.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// 출고창고->입고창고 품목이동 버튼 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_move_Click(object sender, EventArgs e)
        {
            if (lv_beforeStock.SelectedItems.Count != 0)
            {
                Frm_WarehouseMoveCount frm = new Frm_WarehouseMoveCount(Convert.ToInt32(lv_beforeStock.SelectedItems[0].SubItems[2].Text));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Stock stock = new Stock();
                    stock.Item_code = lv_beforeStock.SelectedItems[0].SubItems[0].Text;
                    stock.Stock_name = lv_beforeStock.SelectedItems[0].SubItems[1].Text;
                    stock.Stock_count = Convert.ToInt32(lv_beforeStock.SelectedItems[0].SubItems[2].Text);

                    if ((stock.Stock_count - frm.ReturnNum) != 0)
                    {
                        stock.Stock_count = stock.Stock_count - frm.ReturnNum;
                        lv_beforeStock.SelectedItems[0].SubItems[2].Text = (stock.Stock_count).ToString();
                    }
                    else
                    {
                        lv_beforeStock.Items.Remove(lv_beforeStock.SelectedItems[0]);
                    }

                    stock.Stock_count = frm.ReturnNum;
                    bool chk = false;
                    if (lv_afterStock.Items.Count != 0)
                    {
                        foreach (ListViewItem item in lv_afterStock.Items)
                        {
                            if (item.SubItems[0].Text == stock.Item_code)
                            {
                                item.SubItems[2].Text = (Convert.ToInt32(item.SubItems[2].Text) + stock.Stock_count).ToString();
                                chk = true;
                                break;
                            }
                        }
                    }

                    if (!chk)
                    {
                        Lv_After_Add(stock);
                    }
                }
            }
        }

        /// <summary>
        /// 취소(좌측화살표) 버튼 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (lv_afterStock.SelectedItems.Count != 0)
            {
                for (int i = lv_afterStock.SelectedItems.Count; i > 0; i--)
                {
                    bool chk = false;

                    ListViewItem item = lv_afterStock.SelectedItems[i - 1];
                    foreach (ListViewItem beforeItem in lv_beforeStock.Items)
                    {
                        if (beforeItem.SubItems[0].Text != item.SubItems[0].Text)
                        {
                            continue;
                        }
                        else
                        {
                            chk = true;
                            break;
                        }
                    }
                    if (chk)
                    {
                        foreach (ListViewItem beforeItem in lv_beforeStock.Items)
                        {
                            if (beforeItem.SubItems[0].Text == item.SubItems[0].Text)
                            {
                                beforeItem.SubItems[2].Text = (Convert.ToInt32(beforeItem.SubItems[2].Text) + Convert.ToInt32(item.SubItems[2].Text)).ToString();
                                break;
                            }
                        }
                    }
                    else
                    {
                        lv_beforeStock.Items.Add((ListViewItem)item.Clone());
                    }

                    lv_afterStock.Items.Remove(item);
                }
            }
        }

        /// <summary>
        /// 비우기 버튼 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (lv_afterStock.Items.Count != 0)
            {
                foreach (ListViewItem item in lv_afterStock.Items)
                {
                    item.Selected = true;
                }
                btn_cancel_Click(null, null);
            }
        }

        /// <summary>
        /// 이동 버튼 이벤트, 현재 값들의 물류가 이동된다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_moving_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                // 물류등록 프로시저의 매개변수
                Distribution dist = new Distribution();

                // 출고창고 입력
                foreach (var item in warehouses)
                {
                    if (item.Warehouse_name != cmb_before.SelectedItem.ToString())
                    {
                        continue;
                    }
                    else
                    {
                        dist.Before_warehouse_code = item.Warehouse_code;
                        break;
                    }
                }

                // 이동날짜 입력
                dist.Move_date = dt_moveDate.Value;

                // 입고창고 입력 (반복입력)
                foreach (var item in warehouses)
                {
                    if (item.Warehouse_name != cmb_after.SelectedItem.ToString())
                    {
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < lv_afterStock.Items.Count; i++)
                        {
                            dist.After_warehouse_code += item.Warehouse_code + "|";
                        }
                        break;
                    }
                }
                dist.After_warehouse_code = dist.After_warehouse_code.Substring(0, dist.After_warehouse_code.Length - 1);

                // 품목번호,갯수 입력 (반복입력)
                foreach (ListViewItem item in lv_afterStock.Items)
                {
                    dist.Item_code += item.SubItems[0].ToString() + "|";
                    dist.Dist_count += item.SubItems[2].ToString() + "|";
                    break;
                }
                dist.Item_code = dist.Item_code.Substring(0, dist.Item_code.Length - 1);
                dist.Dist_count = dist.Dist_count.Substring(0, dist.Dist_count.Length - 1);

                DistributionDAO distributionDAO = new DistributionDAO();

                try
                {
                    distributionDAO.SET_DISTRIBUTION(dist);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB 오류발생! \r\n" + ex.Message);
                }
            }
        }

        /// <summary>
        /// 물류등록시 유효성검사 함수
        /// </summary>
        /// <returns>통과: true, 실패: false</returns>
        private bool Validation()
        {
            if (cmb_before.SelectedIndex == -1)
            {
                MessageBox.Show("입고창고를 선택하셔야 합니다.");
                cmb_before.Select();
                return false;
            }
            else if (cmb_after.SelectedIndex == -1)
            {
                MessageBox.Show("출고창고를 선택하셔야 합니다.");
                cmb_after.Select();
                return false;
            }
            else if (lv_afterStock.Items.Count == 0)
            {
                MessageBox.Show("이동 품목을 하나이상 추가하셔야합니다.");
                return false;
            }

            return true;
        }
    }
}
