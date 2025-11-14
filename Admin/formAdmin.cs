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

       

        private void đồUốngToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
