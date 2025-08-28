﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            listBox2.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int soTien = 0;
            foreach (string hang in listBox2.Items) 
            {
                switch (hang)
                {
                    case "Chuột":
                        soTien += 100000;
                            break;
                    case "Bàn phím":
                        soTien += 150000;
                        break;
                    case "Máy in":
                        soTien += 2000000;
                        break;
                    case "USB Kingmax":
                        soTien += 200000;
                        break;
                    default: break;
                }
                lblTongTien.Text = soTien + " Đồng";
            }
        }

       
    }
}
