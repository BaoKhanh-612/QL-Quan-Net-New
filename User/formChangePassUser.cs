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
    public partial class formChangePassUser : Form
    {
        // 1. Biến private để lưu tên đăng nhập của user
        private string _currentUsername;

        // 2. Sửa hàm khởi tạo (Constructor) để nhận tên đăng nhập
        public formChangePassUser(string username)
        {
            InitializeComponent();

            // Lưu tên đăng nhập được truyền vào
            _currentUsername = username;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // 3. Sự kiện click cho nút "Đổi Mật Khẩu" (hoặc tên tương tự)
        private void btnChangePassword_Click_1(object sender, EventArgs e)
        {
            string oldPass = txtOldPassword.Text;
            string newPass = txtNewPassword.Text;
            string confirmPass = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(oldPass) || string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!");
                return;
            }

            try
            {
                databaseDataContext db = new databaseDataContext();

                // 4. Tìm user dựa trên tên đăng nhập đã lưu (_currentUsername)
                var user = db.TaiKhoans.SingleOrDefault(u => u.TenDangNhap == _currentUsername);

                if (user == null)
                {
                    MessageBox.Show("Lỗi: Không tìm thấy tài khoản.");
                    return;
                }

                // 5. Kiểm tra mật khẩu cũ
                if (user.MatKhau != oldPass)
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác!");
                }
                else
                {
                    // 6. Cập nhật mật khẩu mới
                    user.MatKhau = newPass;
                    db.SubmitChanges();
                    MessageBox.Show("Đổi mật khẩu thành công!");

                    // 7. Đóng form sau khi đổi thành công
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đổi mật khẩu: " + ex.Message);
            }
        }
    }
}
