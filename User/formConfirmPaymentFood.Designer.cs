namespace Quan_Li_Tiem_Net
{
    partial class formConfirmPaymentFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConfirmPaymentFood));
            this.btnCo = new System.Windows.Forms.Button();
            this.btnKhong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCo
            // 
            this.btnCo.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCo.Font = new System.Drawing.Font("UTM Banque", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCo.Location = new System.Drawing.Point(114, 133);
            this.btnCo.Name = "btnCo";
            this.btnCo.Size = new System.Drawing.Size(116, 48);
            this.btnCo.TabIndex = 0;
            this.btnCo.Text = "có";
            this.btnCo.UseVisualStyleBackColor = false;
            this.btnCo.Click += new System.EventHandler(this.btnCo_Click);
            // 
            // btnKhong
            // 
            this.btnKhong.BackColor = System.Drawing.Color.IndianRed;
            this.btnKhong.Font = new System.Drawing.Font("UTM Banque", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhong.Location = new System.Drawing.Point(311, 133);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(116, 48);
            this.btnKhong.TabIndex = 1;
            this.btnKhong.Text = "không";
            this.btnKhong.UseVisualStyleBackColor = false;
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Banque", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "bạn có chắc chắn muốn thanh toán không ?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnKhong);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnCo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 193);
            this.panel1.TabIndex = 4;
            // 
            // formConfirmPaymentFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 193);
            this.Controls.Add(this.panel1);
            this.Name = "formConfirmPaymentFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formConfirmPaymentFood";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCo;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}