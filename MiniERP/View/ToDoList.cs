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
        }
    }
}
