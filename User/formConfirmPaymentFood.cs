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
    public partial class formConfirmPaymentFood : Form
    {
        public formConfirmPaymentFood()
        {
            InitializeComponent();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công! Nhân viên sẽ đến mang món và thu tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            formFood form = new formFood();
            form.ShowDialog();
        }
    }
}
