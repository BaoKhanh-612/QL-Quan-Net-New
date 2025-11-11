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

            if (username == null || password == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (username == "admin" && password == "123")
                {
                    MessageBox.Show("Xin chao Admin", "Thong bao ", MessageBoxButtons.OK);
                    formAdmin fAdmin = new formAdmin();
                    this.Hide();
                    DialogResult result = fAdmin.ShowDialog();

                    // Nếu Admin đăng xuất, đóng form Login để quay về form Main
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                        return;
                    }

                    // Sau khi form Admin đóng, hiện lại form Login và xóa dữ liệu
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                    this.Show();
                }
                else if (username == "user" && password == "123")
                {
                    MessageBox.Show("Xin chao User", "Thong bao ", MessageBoxButtons.OK);
                    formUser fUser = new formUser();
                    this.Hide();
                    DialogResult result = fUser.ShowDialog();

                    // Nếu User đăng xuất, đóng form Login để quay về form Main
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                        return;
                    }

                    // Sau khi form User đóng, hiện lại form Login và xóa dữ liệu
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai thong tin dang nhap, Vui long nhap lai", "Thong bao ", MessageBoxButtons.OK);
                    txtUsername.Focus();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
