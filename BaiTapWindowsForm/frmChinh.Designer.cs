namespace BaiTapWindowsForm
{
    partial class frmChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbpBai1 = new System.Windows.Forms.ToolStripButton();
            this.tspBai2 = new System.Windows.Forms.ToolStripButton();
            this.tspBai3 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbpBai1,
            this.tspBai2,
            this.tspBai3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbpBai1
            // 
            this.tbpBai1.Image = ((System.Drawing.Image)(resources.GetObject("tbpBai1.Image")));
            this.tbpBai1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbpBai1.Name = "tbpBai1";
            this.tbpBai1.Size = new System.Drawing.Size(66, 28);
            this.tbpBai1.Text = "Bài 1";
            this.tbpBai1.Click += new System.EventHandler(this.tbpBai1_Click);
            // 
            // tspBai2
            // 
            this.tspBai2.Image = ((System.Drawing.Image)(resources.GetObject("tspBai2.Image")));
            this.tspBai2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspBai2.Name = "tspBai2";
            this.tspBai2.Size = new System.Drawing.Size(66, 28);
            this.tspBai2.Text = "Bài 2";
            this.tspBai2.Click += new System.EventHandler(this.tspBai2_Click);
            // 
            // tspBai3
            // 
            this.tspBai3.Image = ((System.Drawing.Image)(resources.GetObject("tspBai3.Image")));
            this.tspBai3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspBai3.Name = "tspBai3";
            this.tspBai3.Size = new System.Drawing.Size(66, 28);
            this.tspBai3.Text = "Bài 3";
            this.tspBai3.Click += new System.EventHandler(this.tspBai3_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmChinh";
            this.Text = "Chương Trình Chính ";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbpBai1;
        private System.Windows.Forms.ToolStripButton tspBai2;
        private System.Windows.Forms.ToolStripButton tspBai3;
    }
}

