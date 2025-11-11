namespace Quan_Li_Tiem_Net
{
    partial class formDrink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDrink));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDoUong = new System.Windows.Forms.DataGridView();
            this.MaDoUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDoUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.txtTenDoUong = new System.Windows.Forms.TextBox();
            this.txtMaDoUong = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDatMon = new System.Windows.Forms.Button();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lblTenDoUong = new System.Windows.Forms.Label();
            this.lblMaDoUong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoUong)).BeginInit();
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
            this.btnQuayVe.Size = new System.Drawing.Size(120, 35);
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
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(140, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(797, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "🧃 PHẦN MỀM ĐẶT ĐỒ UỐNG 🧋";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(943, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDoUong);
            this.panel1.Location = new System.Drawing.Point(12, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 460);
            this.panel1.TabIndex = 7;
            // 
            // dgvDoUong
            // 
            this.dgvDoUong.AllowUserToAddRows = false;
            this.dgvDoUong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoUong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoUong.ColumnHeadersHeight = 30;
            this.dgvDoUong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDoUong,
            this.TenDoUong,
            this.GiaTien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoUong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDoUong.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvDoUong.Location = new System.Drawing.Point(0, 0);
            this.dgvDoUong.Name = "dgvDoUong";
            this.dgvDoUong.ReadOnly = true;
            this.dgvDoUong.RowTemplate.Height = 30;
            this.dgvDoUong.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDoUong.Size = new System.Drawing.Size(496, 460);
            this.dgvDoUong.TabIndex = 0;
            this.dgvDoUong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoUong_CellClick_1);
            // 
            // MaDoUong
            // 
            this.MaDoUong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaDoUong.DataPropertyName = "MaDoUong";
            this.MaDoUong.HeaderText = "Mã đồ uống";
            this.MaDoUong.Name = "MaDoUong";
            this.MaDoUong.ReadOnly = true;
            this.MaDoUong.Width = 128;
            // 
            // TenDoUong
            // 
            this.TenDoUong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDoUong.DataPropertyName = "TenDoUong";
            this.TenDoUong.HeaderText = "Tên đồ uống";
            this.TenDoUong.Name = "TenDoUong";
            this.TenDoUong.ReadOnly = true;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.txtGiaTien);
            this.panel2.Controls.Add(this.txtTenDoUong);
            this.panel2.Controls.Add(this.txtMaDoUong);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnDatMon);
            this.panel2.Controls.Add(this.lblSoLuong);
            this.panel2.Controls.Add(this.lblGiaTien);
            this.panel2.Controls.Add(this.lblTenDoUong);
            this.panel2.Controls.Add(this.lblMaDoUong);
            this.panel2.Location = new System.Drawing.Point(514, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 460);
            this.panel2.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(187, 365);
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(578, 224);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã món ăn";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên món ăn";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá tiền";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.Location = new System.Drawing.Point(187, 324);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(323, 26);
            this.txtGiaTien.TabIndex = 6;
            // 
            // txtTenDoUong
            // 
            this.txtTenDoUong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDoUong.Location = new System.Drawing.Point(187, 286);
            this.txtTenDoUong.Name = "txtTenDoUong";
            this.txtTenDoUong.Size = new System.Drawing.Size(323, 26);
            this.txtTenDoUong.TabIndex = 4;
            // 
            // txtMaDoUong
            // 
            this.txtMaDoUong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDoUong.Location = new System.Drawing.Point(187, 246);
            this.txtMaDoUong.Name = "txtMaDoUong";
            this.txtMaDoUong.Size = new System.Drawing.Size(323, 26);
            this.txtMaDoUong.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("UTM Banque", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(291, 410);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 34);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("UTM Banque", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(187, 410);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 34);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnDatMon
            // 
            this.btnDatMon.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnDatMon.Font = new System.Drawing.Font("UTM Banque", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatMon.Location = new System.Drawing.Point(410, 385);
            this.btnDatMon.Name = "btnDatMon";
            this.btnDatMon.Size = new System.Drawing.Size(112, 59);
            this.btnDatMon.TabIndex = 11;
            this.btnDatMon.Text = "ĐẶT MÓN";
            this.btnDatMon.UseVisualStyleBackColor = false;
            this.btnDatMon.Click += new System.EventHandler(this.btnDatMon_Click_1);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(79, 362);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(94, 24);
            this.lblSoLuong.TabIndex = 7;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.Location = new System.Drawing.Point(79, 324);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(81, 24);
            this.lblGiaTien.TabIndex = 5;
            this.lblGiaTien.Text = "Giá tiền";
            // 
            // lblTenDoUong
            // 
            this.lblTenDoUong.AutoSize = true;
            this.lblTenDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDoUong.Location = new System.Drawing.Point(37, 286);
            this.lblTenDoUong.Name = "lblTenDoUong";
            this.lblTenDoUong.Size = new System.Drawing.Size(132, 24);
            this.lblTenDoUong.TabIndex = 3;
            this.lblTenDoUong.Text = "Tên đồ uống";
            // 
            // lblMaDoUong
            // 
            this.lblMaDoUong.AutoSize = true;
            this.lblMaDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDoUong.Location = new System.Drawing.Point(46, 246);
            this.lblMaDoUong.Name = "lblMaDoUong";
            this.lblMaDoUong.Size = new System.Drawing.Size(123, 24);
            this.lblMaDoUong.TabIndex = 1;
            this.lblMaDoUong.Text = "Mã đồ uống";
            // 
            // formDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuayVe);
            this.Name = "formDrink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formDrink";
            this.Load += new System.EventHandler(this.formDrink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoUong)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDoUong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.TextBox txtTenDoUong;
        private System.Windows.Forms.TextBox txtMaDoUong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDatMon;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.Label lblTenDoUong;
        private System.Windows.Forms.Label lblMaDoUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDoUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
    }
}