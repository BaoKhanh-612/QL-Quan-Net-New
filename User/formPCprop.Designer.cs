namespace Quan_Li_Tiem_Net
{
    partial class formPCprop
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
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenMay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRAMInfo = new System.Windows.Forms.Label();
            this.lblGPUInfo = new System.Windows.Forms.Label();
            this.lblCPUInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.btnQuayVe.TabIndex = 3;
            this.btnQuayVe.Text = "⬅️ QUAY VỀ";
            this.btnQuayVe.UseVisualStyleBackColor = false;
            this.btnQuayVe.Click += new System.EventHandler(this.btnQuayVe_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("UTM Banque", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(951, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "cấu hình máy của bạn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenMay
            // 
            this.lblTenMay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTenMay.Font = new System.Drawing.Font("UTM Banque", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMay.Location = new System.Drawing.Point(163, 21);
            this.lblTenMay.Name = "lblTenMay";
            this.lblTenMay.Size = new System.Drawing.Size(743, 40);
            this.lblTenMay.TabIndex = 4;
            this.lblTenMay.Text = "thông tin TÊN MÁY ...";
            this.lblTenMay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("UTM Banque", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "tên máy";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblRAMInfo);
            this.panel1.Controls.Add(this.lblGPUInfo);
            this.panel1.Controls.Add(this.lblCPUInfo);
            this.panel1.Controls.Add(this.lblTenMay);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 303);
            this.panel1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("UTM Banque", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 40);
            this.label7.TabIndex = 4;
            this.label7.Text = "ram ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("UTM Banque", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = " gpu ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("UTM Banque", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = " cpu ";
            // 
            // lblRAMInfo
            // 
            this.lblRAMInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRAMInfo.Font = new System.Drawing.Font("UTM Banque", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAMInfo.Location = new System.Drawing.Point(163, 238);
            this.lblRAMInfo.Name = "lblRAMInfo";
            this.lblRAMInfo.Size = new System.Drawing.Size(743, 40);
            this.lblRAMInfo.TabIndex = 4;
            this.lblRAMInfo.Text = "thông tin RAM ...";
            this.lblRAMInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGPUInfo
            // 
            this.lblGPUInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGPUInfo.Font = new System.Drawing.Font("UTM Banque", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUInfo.Location = new System.Drawing.Point(163, 165);
            this.lblGPUInfo.Name = "lblGPUInfo";
            this.lblGPUInfo.Size = new System.Drawing.Size(743, 40);
            this.lblGPUInfo.TabIndex = 4;
            this.lblGPUInfo.Text = "thông tin GPU ...";
            this.lblGPUInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCPUInfo
            // 
            this.lblCPUInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCPUInfo.Font = new System.Drawing.Font("UTM Banque", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUInfo.Location = new System.Drawing.Point(164, 93);
            this.lblCPUInfo.Name = "lblCPUInfo";
            this.lblCPUInfo.Size = new System.Drawing.Size(743, 40);
            this.lblCPUInfo.TabIndex = 4;
            this.lblCPUInfo.Text = "thông tin CPU ...";
            this.lblCPUInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formPCprop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(951, 396);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.label1);
            this.Name = "formPCprop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPCprop";
            this.Load += new System.EventHandler(this.formPCprop_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenMay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCPUInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRAMInfo;
        private System.Windows.Forms.Label lblGPUInfo;
    }
}