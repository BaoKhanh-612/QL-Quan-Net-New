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
    public partial class formChonLoaiIn : Form
    {
        // Thuộc tính công khai để lấy lựa chọn của người dùng
        public string LoaiDuocChon { get; private set; }

        public formChonLoaiIn()
        {
            InitializeComponent();

            LoadOptions();
        }

        private void LoadOptions()
        {
            // Thêm các lựa chọn vào ComboBox
            comboBoxLoai.Items.Add("Tất cả");
            comboBoxLoai.Items.Add("Gói chơi"); // Giả sử tên loại trong DB là "Gói chơi"
            comboBoxLoai.Items.Add("Đồ uống"); // Giả sử tên loại trong DB là "Đồ uống"
            comboBoxLoai.Items.Add("Món ăn");   // Giả sử tên loại trong DB là "Món ăn"

            // Đặt giá trị được chọn mặc định là "Tất cả"
            comboBoxLoai.SelectedIndex = 0;
        }

        // Để tạo sự kiện này, bạn có thể quay lại tab [Design],
        // bấm đúp (double-click) vào nút "Đồng ý".
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Lấy giá trị đã chọn từ ComboBox
            this.LoaiDuocChon = comboBoxLoai.SelectedItem.ToString();

            // Đặt DialogResult để form cha biết là đã bấm OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Đặt DialogResult để form cha biết là đã bấm Cancel
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
