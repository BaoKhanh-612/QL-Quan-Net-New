using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Quan_Li_Tiem_Net
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.");
                return;
            }

            try
            {   
                databaseDataContext db = new databaseDataContext();

                // 1. Kiểm tra tài khoản tồn tại (ko PHÂN BIỆT hoa thường)
                var user = db.TaiKhoans.SingleOrDefault(u => u.TenDangNhap == username);

                if (user == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại!");
                }
                else
                {
                    if (user.MatKhau == password)
                    {
                        // Đăng nhập thành công
                    MessageBox.Show("Đăng nhập thành công!");
                    this.Hide();

                if (user.LoaiTaiKhoan == "Admin")
                {
                    formAdmin fAdmin = new formAdmin();
                    fAdmin.ShowDialog();
                }
                else // LoaiTaiKhoan == "User"
                {
                    formUser fUser = new formUser();
                    // Truyền tên đăng nhập qua formUser để dùng cho chức năng đổi mật khẩu
                    fUser.currentUsername = user.TenDangNhap; 
                    fUser.ShowDialog();
                }
                
                    // Sau khi form Admin/User đóng, hiển thị lại form Login
                    this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
