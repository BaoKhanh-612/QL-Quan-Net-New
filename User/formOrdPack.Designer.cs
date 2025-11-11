namespace Quan_Li_Tiem_Net
{
    partial class formOrdPack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOrdPack));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnCashP = new System.Windows.Forms.Button();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Akashi", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(617, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "THANH TOÁN GÓI CHƠI";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(925, 369);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(152, 26);
            this.txtTongTien.TabIndex = 14;
            // 
            // btnCredit
            // 
            this.btnCredit.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCredit.Font = new System.Drawing.Font("UTM Banque", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredit.Location = new System.Drawing.Point(851, 476);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(110, 36);
            this.btnCredit.TabIndex = 12;
            this.btnCredit.Text = "Tín dụng";
            this.btnCredit.UseVisualStyleBackColor = false;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click_1);
            // 
            // btnCashP
            // 
            this.btnCashP.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCashP.Font = new System.Drawing.Font("UTM Banque", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashP.Location = new System.Drawing.Point(710, 476);
            this.btnCashP.Name = "btnCashP";
            this.btnCashP.Size = new System.Drawing.Size(110, 36);
            this.btnCashP.TabIndex = 13;
            this.btnCashP.Text = "Tiền mặt";
            this.btnCashP.UseVisualStyleBackColor = false;
            this.btnCashP.Click += new System.EventHandler(this.btnCashP_Click);
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.BackColor = System.Drawing.Color.IndianRed;
            this.btnQuayVe.Font = new System.Drawing.Font("UTM Banque", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayVe.Location = new System.Drawing.Point(981, 528);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(114, 46);
            this.btnQuayVe.TabIndex = 11;
            this.btnQuayVe.Text = "⬅️ quay về";
            this.btnQuayVe.UseVisualStyleBackColor = false;
            this.btnQuayVe.Click += new System.EventHandler(this.btnQuayVe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Banque", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(765, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "TỔNG TIỀN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Banque", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "chọn phương thức thanh toán";
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvHoaDon.GridLines = true;
            this.lvHoaDon.HideSelection = false;
            this.lvHoaDon.Location = new System.Drawing.Point(579, 100);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(498, 263);
            this.lvHoaDon.TabIndex = 8;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            // 
            // formOrdPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 586);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.btnCashP);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvHoaDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "formOrdPack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formOrdPack";
            this.Load += new System.EventHandler(this.formOrdPack_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnCashP;
        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvHoaDon;
    }
}