using Quan_Li_Tiem_Net.Admin;
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
    public partial class formAdmin : Form
    {
        public formAdmin()
        {
            InitializeComponent();
        }


        private void datmonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tạm ẩn form Admin
            this.Hide();

            // 1. TÌM formDrink (của User) đang mở trong ứng dụng
            formDrink userFormInstance = Application.OpenForms.OfType<formDrink>().FirstOrDefault();

            // 2. TRUYỀN thể hiện userFormInstance vào FormDrrink (của Admin)
            FormDrrink fDrink = new FormDrrink(userFormInstance); // <-- ĐÃ SỬA

            fDrink.ShowDialog();

            // Sau khi form Đồ uống đóng, hiện lại form Admin
            this.Show();
        }

        private void lịchSửMuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tạm ẩn form Admin
            this.Hide();

            // 1. TÌM formPack (của User) đang mở trong ứng dụng
            formPack userFormInstance = Application.OpenForms.OfType<formPack>().FirstOrDefault();

            // 2. TRUYỀN thể hiện userFormInstance vào Formgoichoi (của Admin)
            // (Hãy chắc chắn bạn đã có "using Quan_Li_Tiem_Net.Admin;" ở đầu file)
            Formgoichoi fGoi = new Formgoichoi(userFormInstance);

            fGoi.ShowDialog();

            // Sau khi form Gói chơi đóng, hiện lại form Admin
            this.Show();
        }



        private void QLUSER_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Khởi tạo và hiển thị form tạo tài khoản
            formTaoTaiKhoan fTaoTK = new formTaoTaiKhoan();
            fTaoTK.ShowDialog();

            // Hiển thị lại form Admin sau khi form tạo tài khoản đóng
            this.Show();
        }





        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?",
                                      "Xác nhận",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // 1. Đóng form Admin hiện tại
                this.Close();

                // 2. Mở lại form Login
                // Lưu ý: Bạn cần tìm formLogin đang chạy hoặc tạo mới
                // Giả sử formLogin của bạn tên là "formLogin"

                // Cách 1: Nếu bạn đã ẩn formLogin khi mở formAdmin
                // (Tìm form Login đã bị ẩn và hiện nó lên)
                formLogin loginForm = Application.OpenForms.OfType<formLogin>().FirstOrDefault();
                if (loginForm != null)
                {
                    loginForm.Show();
                }
                else
                {
                    // Cách 2: Nếu formLogin đã bị đóng, tạo một form mới
                    formLogin newLoginForm = new formLogin();
                    newLoginForm.Show();
                }
            }
        }

        private void themmonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            // 1. TÌM formFood (của User) đang mở trong ứng dụng
            formFood userFormInstance = Application.OpenForms.OfType<formFood>().FirstOrDefault();

            // 2. TRUYỀN thể hiện userFormInstance vào Formfood (của Admin)
            Formfood fFood = new Formfood(userFormInstance); // <-- Đã sửa

            fFood.ShowDialog();

            // Sau khi form Đồ ăn đóng, hiện lại form Admin
            this.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 2. Tạo một đối tượng (instance) mới của FormThongKe
            FormThongKe fThongKe = new FormThongKe();

            // 3. Hiển thị form đó
            // (Dùng ShowDialog() để nó ưu tiên hiển thị, không cho bấm
            //  vào form Admin khi form Thống kê đang mở)
            fThongKe.ShowDialog();
        }

        
        
    }
}