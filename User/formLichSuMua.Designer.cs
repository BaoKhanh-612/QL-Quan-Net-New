namespace Quan_Li_Tiem_Net.User
{
    partial class formLichSuMua
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
            this.lvLichSuMua = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvLichSuMua
            // 
            this.lvLichSuMua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvLichSuMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLichSuMua.GridLines = true;
            this.lvLichSuMua.HideSelection = false;
            this.lvLichSuMua.Location = new System.Drawing.Point(0, 82);
            this.lvLichSuMua.Name = "lvLichSuMua";
            this.lvLichSuMua.Size = new System.Drawing.Size(768, 444);
            this.lvLichSuMua.TabIndex = 0;
            this.lvLichSuMua.UseCompatibleStateImageBehavior = false;
            this.lvLichSuMua.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Banque", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "lịch sử giao dịch";
            // 
            // formLichSuMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvLichSuMua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formLichSuMua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formLichSuMua";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvLichSuMua;
        private System.Windows.Forms.Label label1;
    }
}