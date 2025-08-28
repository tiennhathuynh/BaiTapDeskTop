using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBai3
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        Dictionary<string, string> tuDien = new Dictionary<string, string>();
        private void btnThemTu_Click(object sender, EventArgs e)
        {
            string tuMoi = txtTuMoi.Text.Trim();
            string nghia = txtNghiaTuMoi.Text.Trim();

            if (tuMoi != "" && nghia != "")
            {
                if (!tuDien.ContainsKey(tuMoi))
                {
                    tuDien.Add(tuMoi, nghia);
                    listBoxTuMoi.Items.Add(tuMoi);

                    txtTuMoi.Clear();
                    txtNghiaTuMoi.Clear();
                }
                else
                {
                    MessageBox.Show("Từ đã tồn tại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ từ và nghĩa.");
            }
        }
        private void listBoxTuMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTuMoi.SelectedItem != null)
            {
                string tuChon = listBoxTuMoi.SelectedItem.ToString();
                if (tuDien.ContainsKey(tuChon))
                {
                    txtNghiaCuaTu.Text = tuDien[tuChon];
                }
            }
        }
    }
}
