namespace Quan_Li_Tiem_Net
{
    partial class formTaoTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTaoTaiKhoan));
            this.lblTaoTaiKhoan = new System.Windows.Forms.Label();
            this.LoaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDanhSachTaiKhoan = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblDanhSachTaiKhoan = new System.Windows.Forms.Label();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.Ltk = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblXacNhanMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTaiKhoan)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTaoTaiKhoan
            // 
            this.lblTaoTaiKhoan.BackColor = System.Drawing.SystemColors.Control;
            this.lblTaoTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTaoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaoTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.lblTaoTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaoTaiKhoan.Name = "lblTaoTaiKhoan";
            this.lblTaoTaiKhoan.Size = new System.Drawing.Size(775, 80);
            this.lblTaoTaiKhoan.TabIndex = 0;
            this.lblTaoTaiKhoan.Text = "TẠO TÀI KHOẢN";
            this.lblTaoTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoaiTaiKhoan
            // 
            this.LoaiTaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LoaiTaiKhoan.DataPropertyName = "LoaiTaiKhoan";
            this.LoaiTaiKhoan.HeaderText = "Loại Tài Khoản";
            this.LoaiTaiKhoan.MinimumWidth = 6;
            this.LoaiTaiKhoan.Name = "LoaiTaiKhoan";
            this.LoaiTaiKhoan.ReadOnly = true;
            this.LoaiTaiKhoan.Width = 116;
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.TenDangNhap.MinimumWidth = 6;
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.ReadOnly = true;
            // 
            // dgvDanhSachTaiKhoan
            // 
            this.dgvDanhSachTaiKhoan.AllowUserToAddRows = false;
            this.dgvDanhSachTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvDanhSachTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDangNhap,
            this.MatKhau,
            this.LoaiTaiKhoan});
            this.dgvDanhSachTaiKhoan.Location = new System.Drawing.Point(17, 0);
            this.dgvDanhSachTaiKhoan.Name = "dgvDanhSachTaiKhoan";
            this.dgvDanhSachTaiKhoan.ReadOnly = true;
            this.dgvDanhSachTaiKhoan.RowHeadersWidth = 51;
            this.dgvDanhSachTaiKhoan.RowTemplate.Height = 24;
            this.dgvDanhSachTaiKhoan.Size = new System.Drawing.Size(875, 545);
            this.dgvDanhSachTaiKhoan.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDanhSachTaiKhoan);
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 566);
            this.panel1.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(296, 304);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(430, 30);
            this.txtHoTen.TabIndex = 0;
            // 
            // lblDanhSachTaiKhoan
            // 
            this.lblDanhSachTaiKhoan.BackColor = System.Drawing.SystemColors.Control;
            this.lblDanhSachTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDanhSachTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.lblDanhSachTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanhSachTaiKhoan.Name = "lblDanhSachTaiKhoan";
            this.lblDanhSachTaiKhoan.Size = new System.Drawing.Size(1149, 80);
            this.lblDanhSachTaiKhoan.TabIndex = 0;
            this.lblDanhSachTaiKhoan.Text = "DANH SÁCH TÀI KHOẢN";
            this.lblDanhSachTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.BackColor = System.Drawing.Color.IndianRed;
            this.btnQuayVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayVe.ForeColor = System.Drawing.Color.Black;
            this.btnQuayVe.Location = new System.Drawing.Point(1324, 15);
            this.btnQuayVe.Margin = new System.Windows.Forms.Padding(5);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(200, 52);
            this.btnQuayVe.TabIndex = 6;
            this.btnQuayVe.Text = "QUAY VỀ";
            this.btnQuayVe.UseVisualStyleBackColor = false;
            // 
            // Ltk
            // 
            this.Ltk.AutoSize = true;
            this.Ltk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltk.Location = new System.Drawing.Point(35, 306);
            this.Ltk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ltk.Name = "Ltk";
            this.Ltk.Size = new System.Drawing.Size(175, 29);
            this.Ltk.TabIndex = 0;
            this.Ltk.Text = "Loại tài khoản";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTop.Controls.Add(this.btnQuayVe);
            this.pnlTop.Controls.Add(this.lblTieuDe);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(775, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1149, 80);
            this.pnlTop.TabIndex = 8;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(167, 20);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(487, 39);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ TÀI KHOẢN USER";
            // 
            // lblXacNhanMatKhau
            // 
            this.lblXacNhanMatKhau.AutoSize = true;
            this.lblXacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXacNhanMatKhau.Location = new System.Drawing.Point(35, 447);
            this.lblXacNhanMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            this.lblXacNhanMatKhau.Size = new System.Drawing.Size(232, 29);
            this.lblXacNhanMatKhau.TabIndex = 0;
            this.lblXacNhanMatKhau.Text = "Xác nhận mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(296, 400);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(430, 30);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(35, 399);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(117, 29);
            this.lblMatKhau.TabIndex = 0;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(296, 353);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(430, 30);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.SystemColors.Control;
            this.pnlRight.Controls.Add(this.panel1);
            this.pnlRight.Controls.Add(this.lblDanhSachTaiKhoan);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(775, 0);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1149, 826);
            this.pnlRight.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(272, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(410, 511);
            this.btnsua.Margin = new System.Windows.Forms.Padding(5);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(156, 52);
            this.btnsua.TabIndex = 5;
            this.btnsua.Text = "CHỈNH SỬA";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(184, 511);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(195, 52);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(296, 448);
            this.txtXacNhanMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(430, 30);
            this.txtXacNhanMatKhau.TabIndex = 3;
            this.txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(35, 352);
            this.lblTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(188, 29);
            this.lblTenDangNhap.TabIndex = 0;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLeft.Controls.Add(this.btnexit);
            this.pnlLeft.Controls.Add(this.pictureBox1);
            this.pnlLeft.Controls.Add(this.btnsua);
            this.pnlLeft.Controls.Add(this.btnThem);
            this.pnlLeft.Controls.Add(this.txtXacNhanMatKhau);
            this.pnlLeft.Controls.Add(this.lblXacNhanMatKhau);
            this.pnlLeft.Controls.Add(this.txtMatKhau);
            this.pnlLeft.Controls.Add(this.lblMatKhau);
            this.pnlLeft.Controls.Add(this.txtTenDangNhap);
            this.pnlLeft.Controls.Add(this.lblTenDangNhap);
            this.pnlLeft.Controls.Add(this.txtHoTen);
            this.pnlLeft.Controls.Add(this.Ltk);
            this.pnlLeft.Controls.Add(this.lblTaoTaiKhoan);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(775, 826);
            this.pnlLeft.TabIndex = 6;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.IndianRed;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(13, 13);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(160, 43);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "⬅️ QUAY VỀ";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit1);
            // 
            // formTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 826);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Name = "formTaoTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTaoTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTaiKhoan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTaoTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridView dgvDanhSachTaiKhoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblDanhSachTaiKhoan;
        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.Label Ltk;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblXacNhanMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnexit;
    }
}