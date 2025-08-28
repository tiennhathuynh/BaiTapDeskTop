namespace frmBai4
{
    partial class frmBai4
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.lblNhap = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.lstSo = new System.Windows.Forms.ListBox();
            this.lbtKetQua = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(597, 108);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(160, 22);
            this.txtNhap.TabIndex = 0;
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Location = new System.Drawing.Point(475, 108);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(116, 16);
            this.lblNhap.TabIndex = 1;
            this.lblNhap.Text = "Nhập Số Cần Tìm:";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(640, 151);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm Số ";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lstSo
            // 
            this.lstSo.FormattingEnabled = true;
            this.lstSo.ItemHeight = 16;
            this.lstSo.Location = new System.Drawing.Point(134, 108);
            this.lstSo.Name = "lstSo";
            this.lstSo.Size = new System.Drawing.Size(205, 292);
            this.lstSo.TabIndex = 3;
            // 
            // lbtKetQua
            // 
            this.lbtKetQua.AutoSize = true;
            this.lbtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtKetQua.Location = new System.Drawing.Point(508, 294);
            this.lbtKetQua.Name = "lbtKetQua";
            this.lbtKetQua.Size = new System.Drawing.Size(83, 20);
            this.lbtKetQua.TabIndex = 4;
            this.lbtKetQua.Text = "Kết Quả:";
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(593, 294);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(59, 20);
            this.lblThongBao.TabIndex = 5;
            this.lblThongBao.Text = "label1";
            // 
            // frmBai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.lbtKetQua);
            this.Controls.Add(this.lstSo);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.lblNhap);
            this.Controls.Add(this.txtNhap);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "frmBai4";
            this.Text = "Tìm Số Trong Danh SÁch";
            this.Load += new System.EventHandler(this.frmBai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.Label lbtKetQua;
        private System.Windows.Forms.Label lblThongBao;
    }
}