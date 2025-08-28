namespace BaiTap2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbBai1 = new System.Windows.Forms.GroupBox();
            this.rbTrang = new System.Windows.Forms.RadioButton();
            this.rdDo = new System.Windows.Forms.RadioButton();
            this.rdXanh = new System.Windows.Forms.RadioButton();
            this.labelGia = new System.Windows.Forms.Label();
            this.labelSL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.gbBai1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BaiTap2.Properties.Resources.images;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(11, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 423);
            this.panel1.TabIndex = 0;
            // 
            // gbBai1
            // 
            this.gbBai1.Controls.Add(this.rbTrang);
            this.gbBai1.Controls.Add(this.rdDo);
            this.gbBai1.Controls.Add(this.rdXanh);
            this.gbBai1.Location = new System.Drawing.Point(439, 51);
            this.gbBai1.Name = "gbBai1";
            this.gbBai1.Size = new System.Drawing.Size(250, 165);
            this.gbBai1.TabIndex = 1;
            this.gbBai1.TabStop = false;
            this.gbBai1.Text = "Chọn màu xe";
            // 
            // rbTrang
            // 
            this.rbTrang.AutoSize = true;
            this.rbTrang.Location = new System.Drawing.Point(34, 111);
            this.rbTrang.Name = "rbTrang";
            this.rbTrang.Size = new System.Drawing.Size(64, 20);
            this.rbTrang.TabIndex = 2;
            this.rbTrang.TabStop = true;
            this.rbTrang.Text = "Trắng";
            this.rbTrang.UseVisualStyleBackColor = true;
            this.rbTrang.CheckedChanged += new System.EventHandler(this.rbTrang_CheckedChanged);
            // 
            // rdDo
            // 
            this.rdDo.AutoSize = true;
            this.rdDo.Location = new System.Drawing.Point(34, 71);
            this.rdDo.Name = "rdDo";
            this.rdDo.Size = new System.Drawing.Size(45, 20);
            this.rdDo.TabIndex = 1;
            this.rdDo.TabStop = true;
            this.rdDo.Text = "Đỏ";
            this.rdDo.UseVisualStyleBackColor = true;
            this.rdDo.CheckedChanged += new System.EventHandler(this.rdDo_CheckedChanged);
            // 
            // rdXanh
            // 
            this.rdXanh.AutoSize = true;
            this.rdXanh.Checked = true;
            this.rdXanh.Location = new System.Drawing.Point(34, 36);
            this.rdXanh.Name = "rdXanh";
            this.rdXanh.Size = new System.Drawing.Size(58, 20);
            this.rdXanh.TabIndex = 0;
            this.rdXanh.TabStop = true;
            this.rdXanh.Text = "Xanh";
            this.rdXanh.UseVisualStyleBackColor = true;
            this.rdXanh.CheckedChanged += new System.EventHandler(this.rdXanh_CheckedChanged);
            // 
            // labelGia
            // 
            this.labelGia.AutoSize = true;
            this.labelGia.Location = new System.Drawing.Point(404, 265);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(58, 16);
            this.labelGia.TabIndex = 2;
            this.labelGia.Text = "Đơn Giá:";
            // 
            // labelSL
            // 
            this.labelSL.AutoSize = true;
            this.labelSL.Location = new System.Drawing.Point(404, 305);
            this.labelSL.Name = "labelSL";
            this.labelSL.Size = new System.Drawing.Size(67, 16);
            this.labelSL.TabIndex = 3;
            this.labelSL.Text = "Số Lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "$";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(483, 262);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 26);
            this.txtDonGia.TabIndex = 5;
            this.txtDonGia.Text = "22000";
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(483, 302);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 26);
            this.txtSoLuong.TabIndex = 6;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(473, 346);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(121, 29);
            this.btnTinhTien.TabIndex = 7;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tổng số tiền thanh toán:";
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTien.Location = new System.Drawing.Point(574, 406);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(0, 25);
            this.labelTongTien.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(666, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "$";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(580, 406);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(14, 20);
            this.lblTongTien.TabIndex = 11;
            this.lblTongTien.Text = ".";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTongTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSL);
            this.Controls.Add(this.labelGia);
            this.Controls.Add(this.gbBai1);
            this.Controls.Add(this.panel1);
            this.Name = "frmBai1";
            this.Text = "frmBai1";
            this.gbBai1.ResumeLayout(false);
            this.gbBai1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbBai1;
        private System.Windows.Forms.RadioButton rbTrang;
        private System.Windows.Forms.RadioButton rdDo;
        private System.Windows.Forms.RadioButton rdXanh;
        private System.Windows.Forms.Label labelGia;
        private System.Windows.Forms.Label labelSL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTongTien;
    }
}