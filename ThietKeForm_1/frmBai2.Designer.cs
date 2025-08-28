namespace frmBai2
{
    partial class frmBai2
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
            this.lstHangBan = new System.Windows.Forms.ListBox();
            this.btnChonHang = new System.Windows.Forms.Button();
            this.btnBoHang = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lstHangHoa = new System.Windows.Forms.ListBox();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.grbMatHangMua = new System.Windows.Forms.GroupBox();
            this.grpDanhSach.SuspendLayout();
            this.grbMatHangMua.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstHangBan
            // 
            this.lstHangBan.FormattingEnabled = true;
            this.lstHangBan.ItemHeight = 16;
            this.lstHangBan.Location = new System.Drawing.Point(138, 42);
            this.lstHangBan.Name = "lstHangBan";
            this.lstHangBan.Size = new System.Drawing.Size(249, 180);
            this.lstHangBan.TabIndex = 1;
            // 
            // btnChonHang
            // 
            this.btnChonHang.Location = new System.Drawing.Point(240, 89);
            this.btnChonHang.Name = "btnChonHang";
            this.btnChonHang.Size = new System.Drawing.Size(108, 42);
            this.btnChonHang.TabIndex = 2;
            this.btnChonHang.Text = "Chọn Hàng >";
            this.btnChonHang.UseVisualStyleBackColor = true;
            this.btnChonHang.Click += new System.EventHandler(this.btnChonHang_Click);
            // 
            // btnBoHang
            // 
            this.btnBoHang.Location = new System.Drawing.Point(24, 89);
            this.btnBoHang.Name = "btnBoHang";
            this.btnBoHang.Size = new System.Drawing.Size(108, 42);
            this.btnBoHang.TabIndex = 3;
            this.btnBoHang.Text = "< Bỏ Hàng";
            this.btnBoHang.UseVisualStyleBackColor = true;
            this.btnBoHang.Click += new System.EventHandler(this.btnBoHang_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.Location = new System.Drawing.Point(196, 242);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(122, 35);
            this.btnTinhTien.TabIndex = 4;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(20, 344);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(273, 20);
            this.lblTongTien.TabIndex = 5;
            this.lblTongTien.Text = "Tổng Tiền Thanh Toán : 0 Đồng";
            // 
            // lstHangHoa
            // 
            this.lstHangHoa.FormattingEnabled = true;
            this.lstHangHoa.ItemHeight = 16;
            this.lstHangHoa.Location = new System.Drawing.Point(0, 42);
            this.lstHangHoa.Name = "lstHangHoa";
            this.lstHangHoa.Size = new System.Drawing.Size(234, 180);
            this.lstHangHoa.TabIndex = 0;
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.lstHangHoa);
            this.grpDanhSach.Controls.Add(this.btnChonHang);
            this.grpDanhSach.Location = new System.Drawing.Point(7, 2);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(377, 436);
            this.grpDanhSach.TabIndex = 6;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh Sách Hàng Hóa";
            // 
            // grbMatHangMua
            // 
            this.grbMatHangMua.Controls.Add(this.lstHangBan);
            this.grbMatHangMua.Controls.Add(this.lblTongTien);
            this.grbMatHangMua.Controls.Add(this.btnTinhTien);
            this.grbMatHangMua.Controls.Add(this.btnBoHang);
            this.grbMatHangMua.Location = new System.Drawing.Point(406, 2);
            this.grbMatHangMua.Name = "grbMatHangMua";
            this.grbMatHangMua.Size = new System.Drawing.Size(393, 436);
            this.grbMatHangMua.TabIndex = 7;
            this.grbMatHangMua.TabStop = false;
            this.grbMatHangMua.Text = "Các Mặt Hàng Khách Mua";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbMatHangMua);
            this.Controls.Add(this.grpDanhSach);
            this.Name = "frmBai2";
            this.Text = "Bán hàng ";
            this.Load += new System.EventHandler(this.frmBai2_Load);
            this.grpDanhSach.ResumeLayout(false);
            this.grbMatHangMua.ResumeLayout(false);
            this.grbMatHangMua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstHangBan;
        private System.Windows.Forms.Button btnChonHang;
        private System.Windows.Forms.Button btnBoHang;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.ListBox lstHangHoa;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.GroupBox grbMatHangMua;
    }
}