namespace Quan_Li_Tiem_Net
{
    partial class formOrderFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOrderFood));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.btnCashF = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 586);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(542, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Akashi", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "THANH TOÁN MÓN ĂN";
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvHoaDon.HideSelection = false;
            this.lvHoaDon.Location = new System.Drawing.Point(29, 99);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(498, 263);
            this.lvHoaDon.TabIndex = 2;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Banque", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "chọn phương thức thanh toán";
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.BackColor = System.Drawing.Color.IndianRed;
            this.btnQuayVe.Font = new System.Drawing.Font("UTM Banque", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayVe.Location = new System.Drawing.Point(431, 527);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(114, 46);
            this.btnQuayVe.TabIndex = 5;
            this.btnQuayVe.Text = "⬅️ quay về";
            this.btnQuayVe.UseVisualStyleBackColor = false;
            this.btnQuayVe.Click += new System.EventHandler(this.btnQuayVe_Click);
            // 
            // btnCashF
            // 
            this.btnCashF.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCashF.Font = new System.Drawing.Font("UTM Banque", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashF.Location = new System.Drawing.Point(160, 475);
            this.btnCashF.Name = "btnCashF";
            this.btnCashF.Size = new System.Drawing.Size(110, 36);
            this.btnCashF.TabIndex = 6;
            this.btnCashF.Text = "Tiền mặt";
            this.btnCashF.UseVisualStyleBackColor = false;
            this.btnCashF.Click += new System.EventHandler(this.btnCashF_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCredit.Font = new System.Drawing.Font("UTM Banque", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredit.Location = new System.Drawing.Point(302, 475);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(110, 36);
            this.btnCredit.TabIndex = 6;
            this.btnCredit.Text = "Tín dụng";
            this.btnCredit.UseVisualStyleBackColor = false;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Banque", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "TỔNG TIỀN :";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(375, 368);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(152, 26);
            this.txtTongTien.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtTongTien);
            this.panel2.Controls.Add(this.lvHoaDon);
            this.panel2.Controls.Add(this.btnCredit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnCashF);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnQuayVe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(549, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 586);
            this.panel2.TabIndex = 8;
            // 
            // formOrderFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "formOrderFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formOrderFood";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.Button btnCashF;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Panel panel2;
    }
}