using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBai4
{
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lstSo.Items.Clear();
            for(int i=0; i<10; i++) 
            {
                int soNgauNhien = rnd.Next(1, 100);
                lstSo.Items.Add(soNgauNhien);
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            int soCanTim=int.Parse(txtNhap.Text);
            foreach(int so in lstSo.Items)
            {
                if (so == soCanTim)
                {
                 lblThongBao.Text = "Tim Thay";
                    break;
                }
                else
                  lblThongBao.Text = "Khong Tim Thay";
            }
        }
    }
}
