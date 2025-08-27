namespace frmChinh
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hỌTênSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hỌTênSinhViênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hỌTênSinhViênToolStripMenuItem
            // 
            this.hỌTênSinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bài1ToolStripMenuItem,
            this.bài2ToolStripMenuItem,
            this.bài3ToolStripMenuItem});
            this.hỌTênSinhViênToolStripMenuItem.Name = "hỌTênSinhViênToolStripMenuItem";
            this.hỌTênSinhViênToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.hỌTênSinhViênToolStripMenuItem.Text = "Họ Tên Sinh Viên";
            // 
            // bài1ToolStripMenuItem
            // 
            this.bài1ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bài1ToolStripMenuItem.Image")));
            this.bài1ToolStripMenuItem.Name = "bài1ToolStripMenuItem";
            this.bài1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bài1ToolStripMenuItem.Text = "Bài 1";
            this.bài1ToolStripMenuItem.Click += new System.EventHandler(this.bài1ToolStripMenuItem_Click);
            // 
            // bài2ToolStripMenuItem
            // 
            this.bài2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bài2ToolStripMenuItem.Image")));
            this.bài2ToolStripMenuItem.Name = "bài2ToolStripMenuItem";
            this.bài2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bài2ToolStripMenuItem.Text = "Bài 2";
            // 
            // bài3ToolStripMenuItem
            // 
            this.bài3ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bài3ToolStripMenuItem.Image")));
            this.bài3ToolStripMenuItem.Name = "bài3ToolStripMenuItem";
            this.bài3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bài3ToolStripMenuItem.Text = "Bài 3";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMain";
            this.Text = "Chương Trình Chính ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hỌTênSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài3ToolStripMenuItem;
    }
}

