using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Tiem_Net.User
{
    public partial class formLichSuMua : Form
    {
        // Biến để lưu tên đăng nhập của người dùng hiện tại
        private string tenDangNhapHienTai;

        // Constructor mặc định (có thể không hữu dụng nếu không gán tenDangNhapHienTai)
        public formLichSuMua()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.formLichSuMua_Load);
        }

        // Constructor mới: Yêu cầu phải truyền vào tên đăng nhập
        public formLichSuMua(string tenDangNhap)
        {
            InitializeComponent();
            this.tenDangNhapHienTai = tenDangNhap; // Lưu lại tên đăng nhập
            this.Load += new System.EventHandler(this.formLichSuMua_Load);
        }

        private void formLichSuMua_Load(object sender, EventArgs e)
        {
            SetupListView();
            // Gọi hàm tải lịch sử từ database
            LoadPurchaseHistoryFromDatabase();
        }

        private void SetupListView()
        {
            lvLichSuMua.Columns.Clear();
            lvLichSuMua.View = View.Details;
            lvLichSuMua.FullRowSelect = true;
            lvLichSuMua.Columns.Add("Tên sản phẩm", 300);
            lvLichSuMua.Columns.Add("Loai", 100);
            lvLichSuMua.Columns.Add("Số lượng", 80);
            lvLichSuMua.Columns.Add("Giá", 100);
            lvLichSuMua.Columns.Add("Ngày mua", 200);
        }

        // Hàm đã được sửa lại để đọc từ Database
        private void LoadPurchaseHistoryFromDatabase()
        {
            lvLichSuMua.Items.Clear();

            // 1. Kiểm tra xem có tên đăng nhập không
            if (string.IsNullOrEmpty(tenDangNhapHienTai))
            {
                MessageBox.Show("Lỗi: Không xác định được người dùng để tải lịch sử.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 2. Kết nối tới database
                databaseDataContext db = new databaseDataContext();

                // 3. Truy vấn dữ liệu từ bảng LichSuMuaHangs
                // Lọc theo tên đăng nhập và sắp xếp theo ngày mới nhất
                var lichSu = db.LichSuMuaHangs
                                .Where(ls => ls.TenDangNhap == this.tenDangNhapHienTai)
                                .OrderByDescending(ls => ls.NgayMua)
                                .ToList();

                // 4. Đổ dữ liệu vào ListView
                foreach (var item in lichSu)
                {
                    // Dùng các trường từ database
                    ListViewItem lvi = new ListViewItem(item.TenSanPham);
                    lvi.SubItems.Add(item.Loai);

                    // Xử lý giá trị có thể là null (Nullable) từ database
                    lvi.SubItems.Add(item.SoLuong?.ToString() ?? "0");
                    lvi.SubItems.Add(item.GiaTien?.ToString("N0") ?? "0");
                    lvi.SubItems.Add(item.NgayMua?.ToString("g") ?? "N/A"); // 'g' là định dạng ngày giờ ngắn gọn

                    lvLichSuMua.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lịch sử mua hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}