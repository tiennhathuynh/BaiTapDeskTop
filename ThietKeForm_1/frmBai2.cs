using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBai2
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        Dictionary<string, int> danhSachHang = new Dictionary<string, int>()
{
    { "Chuột", 100000 },
    { "Bàn phím", 150000 },
    { "Máy in", 2000000 },
    { "USB Kingmax", 200000 }
};
        private void frmBai2_Load(object sender, EventArgs e)
        {
            foreach (var item in danhSachHang.Keys)
            {
                lstHangHoa.Items.Add(item);
            }
        }
        // Chọn hàng
        private void btnChonHang_Click(object sender, EventArgs e)
        {
            if (lstHangHoa.SelectedItem != null)
            {
                lstHangBan.Items.Add(lstHangHoa.SelectedItem);
            }
        }

        // Bỏ hàng
        private void btnBoHang_Click(object sender, EventArgs e)
        {
            if (lstHangBan.SelectedItem != null)
            {
                lstHangBan.Items.Remove(lstHangBan.SelectedItem);
            }
        }

private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int tongTien = 0;
            foreach (var item in lstHangBan.Items)
            {
                string tenHang = item.ToString();
                if (danhSachHang.ContainsKey(tenHang))
                {
                    tongTien += danhSachHang[tenHang];
                }
            }

            lblTongTien.Text = "Tổng Tiền Thanh Toán : " + tongTien.ToString("N0") + " Đồng";
        }

    }
}
