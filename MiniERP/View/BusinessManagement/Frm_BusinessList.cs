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
            businesses = new BusinessDAO().GetBusiness(new Business());
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
            businesses = new BusinessDAO().GetBusiness(new Business());
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Business business = new Business
            {
                Code = txtCode.Text,
                Name = txtName.Text,
                Tel = txtTel.Text,
                Email = txtEmail.Text,
                Presenter = txtPresenter.Text
            };
            selectBusinesses = new BusinessDAO().GetBusiness(business);
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
                try
                {
                    new BusinessDAO().DeleteBusiness(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    MessageBox.Show("해당 거래처가 삭제되었습니다.", "삭제 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReflashData();
                }
                catch (Exception)
                {
                    MessageBox.Show("해당 거래처와 진행중인 거래가 있습니다.", "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCodeOrName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Business business = new Business
                {
                    Code = "",
                    Name = txtCodeOrName.Text,
                    Tel = "",
                    Email = "",
                    Presenter = ""
                };
                selectBusinesses = new BusinessDAO().GetBusiness(business);
                dataGridView1.DataSource = selectBusinesses;
                dataGridView1.Columns[0].HeaderText = "거래처코드";
                dataGridView1.Columns[1].HeaderText = "거래처명";
                dataGridView1.Columns[2].HeaderText = "거래처연락처";
                dataGridView1.Columns[3].HeaderText = "거래처주소";
                dataGridView1.Columns[4].HeaderText = "거래처이메일";
                dataGridView1.Columns[5].HeaderText = "거래처대표";
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtCodeOrName.Clear();
        }

        private void btnSearchBusiness_Click(object sender, EventArgs e)
        {
            Frm_BusinessSelect fbs = new Frm_BusinessSelect();
            if (fbs.ShowDialog() == DialogResult.OK)
            {
                txtCode.Text = fbs.Business.Code;
                txtName.Text = fbs.Business.Name;
                txtTel.Text = fbs.Business.Tel;
                txtEmail.Text = fbs.Business.Email;
                txtPresenter.Text = fbs.Business.Presenter;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Frm_BusinessInsert businessInsert = new Frm_BusinessInsert(businesses);
            businessInsert.ShowDialog();
            ReflashData();
        }
    }
}
