using System;
using System.Windows.Forms;

namespace frmBai1
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void rdbXanh_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbXanh.Checked)
                txtDonGia.Text = "22000";
        }

        private void rdbDo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDo.Checked)
                txtDonGia.Text = "21000";
        }

        private void rdbTrang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTrang.Checked)
                txtDonGia.Text = "20000";
        }

        private void CalculateTotal_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDonGia.Text, out int donGia) &&
                int.TryParse(txtSoluong.Text, out int soLuong))
            {
                int tongTien = donGia * soLuong;
                lblTongTienText.Text = $"Tổng tiền: {tongTien}$";
                lblTongTienText.Visible = true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng số liệu!", "Thông báo");
                lblTongTienText.Text = "Tổng tiền thanh toán:";
            }
        }

    }

    }
