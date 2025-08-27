using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1
{
    public partial class FormMain : Form
    {   
        public FormMain()
        {
            InitializeComponent();
        }
        //click doi se tao ra chuong trinh
        private void btnOK_Click(object sender, EventArgs e)
        {
            var tenDaNhap=txtTen.Text;
            MessageBox.Show($"Xin Chao Ban {tenDaNhap}. Rat vui duoc gap ban","Thong Diep CHao Mung" );
        }

      
        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text=txtTen.Text;

        }

        private void txtSaoChep_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }

       
    }
}
