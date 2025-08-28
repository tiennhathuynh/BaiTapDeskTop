namespace frmBai3
{
    partial class frmBai3
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
            this.lblTuMoi = new System.Windows.Forms.Label();
            this.txtTuMoi = new System.Windows.Forms.TextBox();
            this.lblNghiaCuaTuMoi = new System.Windows.Forms.Label();
            this.txtNghiaTuMoi = new System.Windows.Forms.TextBox();
            this.btnThemTuMoi = new System.Windows.Forms.Button();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.listBoxTuMoi = new System.Windows.Forms.ListBox();
            this.lblNghiaCuaTu = new System.Windows.Forms.Label();
            this.txtNghiaCuaTu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTuMoi
            // 
            this.lblTuMoi.AutoSize = true;
            this.lblTuMoi.Location = new System.Drawing.Point(75, 49);
            this.lblTuMoi.Name = "lblTuMoi";
            this.lblTuMoi.Size = new System.Drawing.Size(51, 16);
            this.lblTuMoi.TabIndex = 0;
            this.lblTuMoi.Text = "Từ Mới:";
            // 
            // txtTuMoi
            // 
            this.txtTuMoi.Location = new System.Drawing.Point(135, 49);
            this.txtTuMoi.Name = "txtTuMoi";
            this.txtTuMoi.Size = new System.Drawing.Size(174, 22);
            this.txtTuMoi.TabIndex = 1;
            // 
            // lblNghiaCuaTuMoi
            // 
            this.lblNghiaCuaTuMoi.AutoSize = true;
            this.lblNghiaCuaTuMoi.Location = new System.Drawing.Point(35, 99);
            this.lblNghiaCuaTuMoi.Name = "lblNghiaCuaTuMoi";
            this.lblNghiaCuaTuMoi.Size = new System.Drawing.Size(94, 16);
            this.lblNghiaCuaTuMoi.TabIndex = 2;
            this.lblNghiaCuaTuMoi.Text = "Nghĩa Của Từ:";
            // 
            // txtNghiaTuMoi
            // 
            this.txtNghiaTuMoi.Location = new System.Drawing.Point(135, 96);
            this.txtNghiaTuMoi.Name = "txtNghiaTuMoi";
            this.txtNghiaTuMoi.Size = new System.Drawing.Size(233, 22);
            this.txtNghiaTuMoi.TabIndex = 3;
            // 
            // btnThemTuMoi
            // 
            this.btnThemTuMoi.Location = new System.Drawing.Point(174, 124);
            this.btnThemTuMoi.Name = "btnThemTuMoi";
            this.btnThemTuMoi.Size = new System.Drawing.Size(106, 27);
            this.btnThemTuMoi.TabIndex = 4;
            this.btnThemTuMoi.Text = "Thêm từ mới";
            this.btnThemTuMoi.UseVisualStyleBackColor = true;
            this.btnThemTuMoi.Click += new System.EventHandler(this.btnThemTu_Click);
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Location = new System.Drawing.Point(174, 195);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(135, 16);
            this.lblDanhSach.TabIndex = 5;
            this.lblDanhSach.Text = "DANH SÁCH TỪ MỚI";
            // 
            // listBoxTuMoi
            // 
            this.listBoxTuMoi.FormattingEnabled = true;
            this.listBoxTuMoi.ItemHeight = 16;
            this.listBoxTuMoi.Location = new System.Drawing.Point(135, 225);
            this.listBoxTuMoi.Name = "listBoxTuMoi";
            this.listBoxTuMoi.Size = new System.Drawing.Size(233, 148);
            this.listBoxTuMoi.TabIndex = 6;
            this.listBoxTuMoi.SelectedIndexChanged += new System.EventHandler(this.listBoxTuMoi_SelectedIndexChanged);
            // 
            // lblNghiaCuaTu
            // 
            this.lblNghiaCuaTu.AutoSize = true;
            this.lblNghiaCuaTu.Location = new System.Drawing.Point(630, 195);
            this.lblNghiaCuaTu.Name = "lblNghiaCuaTu";
            this.lblNghiaCuaTu.Size = new System.Drawing.Size(104, 16);
            this.lblNghiaCuaTu.TabIndex = 7;
            this.lblNghiaCuaTu.Text = "NGHĨA CỦA TỪ";
            // 
            // txtNghiaCuaTu
            // 
            this.txtNghiaCuaTu.Location = new System.Drawing.Point(562, 225);
            this.txtNghiaCuaTu.Multiline = true;
            this.txtNghiaCuaTu.Name = "txtNghiaCuaTu";
            this.txtNghiaCuaTu.ReadOnly = true;
            this.txtNghiaCuaTu.Size = new System.Drawing.Size(172, 22);
            this.txtNghiaCuaTu.TabIndex = 8;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNghiaCuaTu);
            this.Controls.Add(this.lblNghiaCuaTu);
            this.Controls.Add(this.listBoxTuMoi);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.btnThemTuMoi);
            this.Controls.Add(this.txtNghiaTuMoi);
            this.Controls.Add(this.lblNghiaCuaTuMoi);
            this.Controls.Add(this.txtTuMoi);
            this.Controls.Add(this.lblTuMoi);
            this.Name = "frmBai3";
            this.Text = "Từ Điển Anh-Việt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTuMoi;
        private System.Windows.Forms.TextBox txtTuMoi;
        private System.Windows.Forms.Label lblNghiaCuaTuMoi;
        private System.Windows.Forms.TextBox txtNghiaTuMoi;
        private System.Windows.Forms.Button btnThemTuMoi;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.ListBox listBoxTuMoi;
        private System.Windows.Forms.Label lblNghiaCuaTu;
        private System.Windows.Forms.TextBox txtNghiaCuaTu;
    }
}