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
    public partial class formConfirmPaymentPack : Form
    {
        // Khai báo một biến để lưu trữ hành động (logic) cần thực thi
        private Action paymentAction;

        // Cập nhật constructor để nhận hành động từ form gọi
        public formConfirmPaymentPack(Action onConfirm)
        {
            InitializeComponent();
            this.paymentAction = onConfirm;
        }

        // Phương thức mặc định (nếu không truyền hành động)
        public formConfirmPaymentPack()
        {
            InitializeComponent();
            this.paymentAction = null;
        }


        private void btnCo_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem hành động đã được truyền vào hay chưa
            if (paymentAction != null)
            {
                // Thực thi hành động (logic của btnCashP)
                paymentAction.Invoke();
            }

            // Đóng form confirm sau khi thực thi
            this.Close();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}