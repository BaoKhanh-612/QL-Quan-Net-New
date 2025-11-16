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
// Thêm thư viện BCrypt.Net
using BCrypt.Net;

namespace Quan_Li_Tiem_Net
{
    public partial class formLogin : Form
    {
        public static string TenDangNhap;
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // ----- BẮT ĐẦU CODE TẠM THỜI -----
            // Mục đích: Dùng để băm mật khẩu cho 1 tài khoản (ví dụ: admin)
            // vì ta không thể đăng nhập bằng mật khẩu cũ (chưa băm).
            if (username == "admin" && password == "convert_admin_pass")
            {
                try
                {
                    databaseDataContext db = new databaseDataContext();
                    var user = db.TaiKhoans.SingleOrDefault(u => u.TenDangNhap == "admin");
                    if (user != null)
                    {
                        // !!! THAY "admin123" bằng MẬT KHẨU MỚI BẠN MUỐN ĐẶT
                        string newHashedPassword = BCrypt.Net.BCrypt.HashPassword("1");
                        user.MatKhau = newHashedPassword;
                        db.SubmitChanges();

                        MessageBox.Show("THÀNH CÔNG!\n\nMật khẩu cho 'admin' đã được băm. " +
                                      "Bây giờ hãy đăng nhập lại bằng mật khẩu mới ('1').");
                        return; // Dừng lại, không chạy code đăng nhập bên dưới
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi convert: " + ex.Message);
                    return;
                }
            }
            // ----- KẾT THÚC CODE TẠM THỜI -----


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
                    // 2. Dùng BCrypt.Verify để so sánh mật khẩu
                    // Nó sẽ so sánh mật khẩu người dùng nhập (password)
                    // với chuỗi băm trong database (user.MatKhau)
                    if (BCrypt.Net.BCrypt.Verify(password, user.MatKhau))
                    {
                        TenDangNhap = user.TenDangNhap;
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