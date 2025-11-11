using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Tiem_Net
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }


        private void formMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLogin form = new formLogin();
            form.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giớiThiệuThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formGTTV form = new formGTTV();
            form.ShowDialog();
        }
    }
}
