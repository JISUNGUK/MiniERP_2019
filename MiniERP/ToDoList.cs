using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.View
{
    public partial class ToDoList : UserControl
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        private void btn_Layer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("클릭시 해당 상세화면 나오는 폼 / 진행단계 나와야함");
            ToDoList_Detail detail = new ToDoList_Detail();
            detail.Dock = DockStyle.Fill;
            //detail.Size = new Size(300, 150);

            //  DashBoard 폼의 split 컨트롤을 찾아 동적으로 붙여넣음
            foreach (Control item in ParentForm.Controls)
            {
                if (item.Name=="split")
                {
                    MessageBox.Show("컨트롤을 찾았음");
                    ((SplitContainer)item).Panel2.Controls.Add(detail);

                }
            }
        }
    }
}
