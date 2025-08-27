namespace frmBai1
{
    partial class frmBai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai1));
            this.grpMauXe = new System.Windows.Forms.GroupBox();
            this.rdbTrang = new System.Windows.Forms.RadioButton();
            this.rdbDo = new System.Windows.Forms.RadioButton();
            this.rdbXanh = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lbtTongTien = new System.Windows.Forms.Label();
            this.picXe = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTongTienText = new System.Windows.Forms.Label();
            this.lblTongTienValue = new System.Windows.Forms.Label();
            this.grpMauXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picXe)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMauXe
            // 
            this.grpMauXe.Controls.Add(this.rdbTrang);
            this.grpMauXe.Controls.Add(this.rdbDo);
            this.grpMauXe.Controls.Add(this.rdbXanh);
            this.grpMauXe.Location = new System.Drawing.Point(469, 1);
            this.grpMauXe.Name = "grpMauXe";
            this.grpMauXe.Size = new System.Drawing.Size(328, 232);
            this.grpMauXe.TabIndex = 0;
            this.grpMauXe.TabStop = false;
            this.grpMauXe.Text = "Chọn màu xe";
            // 
            // rdbTrang
            // 
            this.rdbTrang.AutoSize = true;
            this.rdbTrang.Location = new System.Drawing.Point(7, 189);
            this.rdbTrang.Name = "rdbTrang";
            this.rdbTrang.Size = new System.Drawing.Size(64, 20);
            this.rdbTrang.TabIndex = 2;
            this.rdbTrang.TabStop = true;
            this.rdbTrang.Text = "Trắng";
            this.rdbTrang.UseVisualStyleBackColor = true;
            this.rdbTrang.CheckedChanged += new System.EventHandler(this.rdbTrang_CheckedChanged);
            // 
            // rdbDo
            // 
            this.rdbDo.AutoSize = true;
            this.rdbDo.Location = new System.Drawing.Point(7, 123);
            this.rdbDo.Name = "rdbDo";
            this.rdbDo.Size = new System.Drawing.Size(45, 20);
            this.rdbDo.TabIndex = 1;
            this.rdbDo.TabStop = true;
            this.rdbDo.Text = "Đỏ";
            this.rdbDo.UseVisualStyleBackColor = true;
            this.rdbDo.CheckedChanged += new System.EventHandler(this.rdbDo_CheckedChanged);
            // 
            // rdbXanh
            // 
            this.rdbXanh.AutoSize = true;
            this.rdbXanh.Location = new System.Drawing.Point(7, 50);
            this.rdbXanh.Name = "rdbXanh";
            this.rdbXanh.Size = new System.Drawing.Size(58, 20);
            this.rdbXanh.TabIndex = 0;
            this.rdbXanh.TabStop = true;
            this.rdbXanh.Text = "Xanh";
            this.rdbXanh.UseVisualStyleBackColor = true;
            this.rdbXanh.CheckedChanged += new System.EventHandler(this.rdbXanh_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đơn Giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(469, 254);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(226, 22);
            this.txtDonGia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Lượng";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(469, 294);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(226, 22);
            this.txtSoluong.TabIndex = 5;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(549, 322);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(84, 23);
            this.btnTinhTien.TabIndex = 6;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.CalculateTotal_Click);
            // 
            // lbtTongTien
            // 
            this.lbtTongTien.AutoSize = true;
            this.lbtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtTongTien.Location = new System.Drawing.Point(560, 368);
            this.lbtTongTien.Name = "lbtTongTien";
            this.lbtTongTien.Size = new System.Drawing.Size(0, 16);
            this.lbtTongTien.TabIndex = 7;
            // 
            // picXe
            // 
            this.picXe.Image = ((System.Drawing.Image)(resources.GetObject("picXe.Image")));
            this.picXe.Location = new System.Drawing.Point(5, 1);
            this.picXe.Name = "picXe";
            this.picXe.Size = new System.Drawing.Size(458, 240);
            this.picXe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picXe.TabIndex = 8;
            this.picXe.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(558, 368);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 9;
            // 
            // lblTongTienText
            // 
            this.lblTongTienText.AutoSize = true;
            this.lblTongTienText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienText.Location = new System.Drawing.Point(466, 377);
            this.lblTongTienText.Name = "lblTongTienText";
            this.lblTongTienText.Size = new System.Drawing.Size(218, 25);
            this.lblTongTienText.TabIndex = 10;
            this.lblTongTienText.Text = "Tổng tiền thanh toán:";
            // 
            // lblTongTienValue
            // 
            this.lblTongTienValue.AutoSize = true;
            this.lblTongTienValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienValue.Location = new System.Drawing.Point(690, 377);
            this.lblTongTienValue.Name = "lblTongTienValue";
            this.lblTongTienValue.Size = new System.Drawing.Size(0, 25);
            this.lblTongTienValue.TabIndex = 11;
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 657);
            this.Controls.Add(this.lblTongTienValue);
            this.Controls.Add(this.lblTongTienText);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.picXe);
            this.Controls.Add(this.lbtTongTien);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpMauXe);
            this.Name = "frmBai1";
            this.Text = "Mua Bán Xe";
            this.grpMauXe.ResumeLayout(false);
            this.grpMauXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMauXe;
        private System.Windows.Forms.RadioButton rdbTrang;
        private System.Windows.Forms.RadioButton rdbDo;
        private System.Windows.Forms.RadioButton rdbXanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lbtTongTien;
        private System.Windows.Forms.PictureBox picXe;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTongTienText;
        private System.Windows.Forms.Label lblTongTienValue;
    }
}