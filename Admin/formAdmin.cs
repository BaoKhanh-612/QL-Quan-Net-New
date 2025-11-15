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
    }
}
