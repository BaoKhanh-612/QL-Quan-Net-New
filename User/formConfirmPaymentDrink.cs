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
    public partial class formConfirmPaymentDrink : Form
    {
        public formConfirmPaymentDrink()
        {
            InitializeComponent();
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công! Nhân viên sẽ đến mang đồ uống và thu tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            formDrink form = new formDrink();
            form.ShowDialog();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
