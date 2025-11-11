namespace Quan_Li_Tiem_Net
{
    partial class formPack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPack));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvGoi = new System.Windows.Forms.DataGridView();
            this.MaGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.txtTenGoi = new System.Windows.Forms.TextBox();
            this.txtMaGoi = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnMuaGoi = new System.Windows.Forms.Button();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lblTenGoi = new System.Windows.Forms.Label();
            this.lblMaGoi = new System.Windows.Forms.Label();
            this.lvGoiChoi = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoi)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.BackColor = System.Drawing.Color.IndianRed;
            this.btnQuayVe.Font = new System.Drawing.Font("UTM Banque", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayVe.ForeColor = System.Drawing.Color.Black;
            this.btnQuayVe.Location = new System.Drawing.Point(12, 12);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(121, 36);
            this.btnQuayVe.TabIndex = 0;
            this.btnQuayVe.Text = "⬅️ QUAY VỀ";
            this.btnQuayVe.UseVisualStyleBackColor = false;
            this.btnQuayVe.Click += new System.EventHandler(this.btnQuayVe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("UTM Akashi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(151, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(799, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "🎮 PHẦN MỀM MUA GÓI CHƠI 🎮";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(943, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dgvGoi
            // 
            this.dgvGoi.AllowUserToAddRows = false;
            this.dgvGoi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGoi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGoi,
            this.TenGoi,
            this.GiaTien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGoi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGoi.Location = new System.Drawing.Point(0, 0);
            this.dgvGoi.Name = "dgvGoi";
            this.dgvGoi.ReadOnly = true;
            this.dgvGoi.RowHeadersWidth = 50;
            this.dgvGoi.RowTemplate.Height = 30;
            this.dgvGoi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvGoi.Size = new System.Drawing.Size(511, 445);
            this.dgvGoi.TabIndex = 0;
            this.dgvGoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoi_CellClick);
            // 
            // MaGoi
            // 
            this.MaGoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaGoi.DataPropertyName = "MaGoi";
            this.MaGoi.HeaderText = "Mã gói";
            this.MaGoi.Name = "MaGoi";
            this.MaGoi.ReadOnly = true;
            this.MaGoi.Width = 87;
            // 
            // TenGoi
            // 
            this.TenGoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenGoi.DataPropertyName = "TenGoi";
            this.TenGoi.HeaderText = "Tên gói";
            this.TenGoi.Name = "TenGoi";
            this.TenGoi.ReadOnly = true;
            // 
            // GiaTien
            // 
            this.GiaTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GiaTien.DataPropertyName = "GiaTien";
            this.GiaTien.HeaderText = "Giá tiền";
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.ReadOnly = true;
            this.GiaTien.Width = 97;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvGoi);
            this.panel1.Location = new System.Drawing.Point(12, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 445);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.txtGiaTien);
            this.panel2.Controls.Add(this.txtTenGoi);
            this.panel2.Controls.Add(this.txtMaGoi);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnMuaGoi);
            this.panel2.Controls.Add(this.lblSoLuong);
            this.panel2.Controls.Add(this.lblGiaTien);
            this.panel2.Controls.Add(this.lblTenGoi);
            this.panel2.Controls.Add(this.lblMaGoi);
            this.panel2.Controls.Add(this.lvGoiChoi);
            this.panel2.Location = new System.Drawing.Point(529, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 445);
            this.panel2.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(198, 356);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(35, 26);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.Location = new System.Drawing.Point(198, 315);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(323, 26);
            this.txtGiaTien.TabIndex = 6;
            // 
            // txtTenGoi
            // 
            this.txtTenGoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGoi.Location = new System.Drawing.Point(198, 277);
            this.txtTenGoi.Name = "txtTenGoi";
            this.txtTenGoi.Size = new System.Drawing.Size(323, 26);
            this.txtTenGoi.TabIndex = 4;
            // 
            // txtMaGoi
            // 
            this.txtMaGoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGoi.Location = new System.Drawing.Point(198, 237);
            this.txtMaGoi.Name = "txtMaGoi";
            this.txtMaGoi.Size = new System.Drawing.Size(323, 26);
            this.txtMaGoi.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("UTM Banque", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(302, 401);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 34);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("UTM Banque", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(198, 401);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 34);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
           
            // btnMuaGoi
            // 
            this.btnMuaGoi.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnMuaGoi.Font = new System.Drawing.Font("UTM Banque", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuaGoi.Location = new System.Drawing.Point(421, 376);
            this.btnMuaGoi.Name = "btnMuaGoi";
            this.btnMuaGoi.Size = new System.Drawing.Size(112, 59);
            this.btnMuaGoi.TabIndex = 11;
            this.btnMuaGoi.Text = "MUA GÓI";
            this.btnMuaGoi.UseVisualStyleBackColor = false;
            this.btnMuaGoi.Click += new System.EventHandler(this.btnMuaGoi_Click);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(90, 353);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(94, 24);
            this.lblSoLuong.TabIndex = 7;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.Location = new System.Drawing.Point(90, 315);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(81, 24);
            this.lblGiaTien.TabIndex = 5;
            this.lblGiaTien.Text = "Giá tiền";
            // 
            // lblTenGoi
            // 
            this.lblTenGoi.AutoSize = true;
            this.lblTenGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGoi.Location = new System.Drawing.Point(89, 276);
            this.lblTenGoi.Name = "lblTenGoi";
            this.lblTenGoi.Size = new System.Drawing.Size(82, 24);
            this.lblTenGoi.TabIndex = 3;
            this.lblTenGoi.Text = "Tên gói";
            // 
            // lblMaGoi
            // 
            this.lblMaGoi.AutoSize = true;
            this.lblMaGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGoi.Location = new System.Drawing.Point(98, 239);
            this.lblMaGoi.Name = "lblMaGoi";
            this.lblMaGoi.Size = new System.Drawing.Size(73, 24);
            this.lblMaGoi.TabIndex = 1;
            this.lblMaGoi.Text = "Mã gói";
            // 
            // lvGoiChoi
            // 
            this.lvGoiChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvGoiChoi.GridLines = true;
            this.lvGoiChoi.HideSelection = false;
            this.lvGoiChoi.Location = new System.Drawing.Point(0, 0);
            this.lvGoiChoi.Name = "lvGoiChoi";
            this.lvGoiChoi.Size = new System.Drawing.Size(566, 223);
            this.lvGoiChoi.TabIndex = 0;
            this.lvGoiChoi.UseCompatibleStateImageBehavior = false;
            // 
            // formPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formPack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPack";
            this.Load += new System.EventHandler(this.formPack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvGoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvGoiChoi;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.TextBox txtTenGoi;
        private System.Windows.Forms.TextBox txtMaGoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnMuaGoi;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.Label lblTenGoi;
        private System.Windows.Forms.Label lblMaGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
    }
}