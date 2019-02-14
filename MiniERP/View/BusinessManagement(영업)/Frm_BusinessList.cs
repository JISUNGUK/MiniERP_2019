using MiniERP.Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.View.BusinessManagement
{
    public partial class Frm_BusinessList : Form
    {
        private List<Business> businesses; // Business테이블의 모든 행을 저장하고있는 리스트입니다.
        private List<Business> selectBusinesses; // 검색 조건에 맞는 거래처가 저장되어있는 리스트입니다.

        private bool boxchk = true;

        /// <summary>
        /// DataGridView의 내용을 최신화합니다.
        /// </summary>
        /// 작성자 : 이상권
        private void ReflashData()
        {
            businesses.Clear();
            dataGridView1.DataSource = null;
            businesses = new BusinessDAO().GetBusiness();
            dataGridView1.DataSource = businesses;
            dataGridView1.Columns[0].HeaderText = "거래처코드";
            dataGridView1.Columns[1].HeaderText = "거래처명";
            dataGridView1.Columns[2].HeaderText = "거래처연락처";
            dataGridView1.Columns[3].HeaderText = "거래처주소";
            dataGridView1.Columns[4].HeaderText = "거래처이메일";
            dataGridView1.Columns[5].HeaderText = "거래처대표";
        }

        public Frm_BusinessList()
        {
            InitializeComponent();
        }

        private void Frm_BusinessList_Load(object sender, EventArgs e)
        {
            businesses = new BusinessDAO().GetBusiness();
            dataGridView1.DataSource = businesses;
            dataGridView1.Columns[0].HeaderText = "거래처코드";
            dataGridView1.Columns[1].HeaderText = "거래처명";
            dataGridView1.Columns[2].HeaderText = "거래처연락처";
            dataGridView1.Columns[3].HeaderText = "거래처주소";
            dataGridView1.Columns[4].HeaderText = "거래처이메일";
            dataGridView1.Columns[5].HeaderText = "거래처대표";
        }

        private void btn_BusinessSelect_Click(object sender, EventArgs e)
        {
            Frm_BusinessSelect Frm_businessSelect = new Frm_BusinessSelect();
            Frm_businessSelect.ShowDialog();              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (boxchk)
            {
                pnl_serchbox.Visible = true;
                boxchk = false;
            }
            else
            {
                pnl_serchbox.Visible = false;
                boxchk = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_BusinessInsert businessInsert = new Frm_BusinessInsert(businesses);
            businessInsert.ShowDialog();
            ReflashData();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectBusinesses = new List<Business>();
            foreach (var item in businesses)
            {
                if (item.Code.Contains(txtCode.Text) && item.Name.Contains(txtName.Text) && item.Tel.Contains(txtTel.Text) && item.Email.Contains(txtEmail.Text) && item.Presenter.Contains(txtPresenter.Text))
                {
                    selectBusinesses.Add(item);
                }
            }
            pnl_serchbox.Visible = false;
            dataGridView1.DataSource = selectBusinesses;
        }

        private void txtCodeOrName_Click(object sender, EventArgs e)
        {
            txtCodeOrName.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택한 거래처를 삭제하시겠습니까?", "거래처 삭제", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                //MessageBox.Show(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                new BusinessDAO().DeleteBusiness(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                MessageBox.Show("삭제되었습니다.");
                ReflashData();
            }
        }

        private void txtCodeOrName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                selectBusinesses = new List<Business>();
                foreach (var item in businesses)
                {
                    if (item.Code.Contains(txtCodeOrName.Text) || item.Name.Contains(txtCodeOrName.Text))
                    {
                        selectBusinesses.Add(item);
                    }
                }
                dataGridView1.DataSource = selectBusinesses;
                dataGridView1.Columns[0].HeaderText = "거래처코드";
                dataGridView1.Columns[1].HeaderText = "거래처명";
                dataGridView1.Columns[2].HeaderText = "거래처연락처";
                dataGridView1.Columns[3].HeaderText = "거래처주소";
                dataGridView1.Columns[4].HeaderText = "거래처이메일";
                dataGridView1.Columns[5].HeaderText = "거래처대표";
            }
        }
    }
}
