using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmChinh
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmBai1.frmBai1 f=new frmBai1.frmBai1();
            f.ShowDialog();
         
        }
        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai2.frmBai2 f = new frmBai2.frmBai2();
            f.ShowDialog();
        }
        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai3.frmBai3 f = new frmBai3.frmBai3();
            f.ShowDialog();
        }
        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai4.frmBai4 f = new frmBai4.frmBai4();
            f.ShowDialog();
        }
    }
    }
