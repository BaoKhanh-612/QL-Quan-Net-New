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
        // Biến để lưu thông tin đơn hàng
        private string tenSanPham;
        private int soLuong;
        private decimal giaTien;
        private string tenDangNhap;

        // Khai báo một biến để lưu trữ hành động (logic) cần thực thi
        private Action paymentAction;

        // Cập nhật constructor để nhận hành động từ form gọi
        public formConfirmPaymentPack(Action onConfirm)
        {
            InitializeComponent();
            this.paymentAction = onConfirm;
        }

        // Constructor mới để nhận dữ liệu
        public formConfirmPaymentPack(string tenSanPham, int soLuong, decimal giaTien, string tenDangNhap)
        {
            InitializeComponent();
            this.tenSanPham = tenSanPham;
            this.soLuong = soLuong;       // (Gói chơi thường số lượng là 1)
            this.giaTien = giaTien;
            this.tenDangNhap = tenDangNhap; // Bạn cần truyền tên đăng nhập vào đây
        }


        private void btnCo_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các thông tin cần thiết đã có chưa
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(tenSanPham))
            {
                MessageBox.Show("Lỗi: Không có thông tin gói chơi hoặc người dùng để thanh toán.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 1. Tạo đối tượng kết nối database (giả sử tên là databaseDataContext)
                databaseDataContext db = new databaseDataContext();

                // 2. Tạo đối tượng LichSuMuaHang mới
                LichSuMuaHang newItem = new LichSuMuaHang();
                newItem.TenDangNhap = this.tenDangNhap;
                newItem.TenSanPham = this.tenSanPham;
                newItem.Loai = "Gói chơi"; // Loại sản phẩm
                newItem.SoLuong = this.soLuong;
                newItem.GiaTien = this.giaTien;
                newItem.NgayMua = DateTime.Now; // Lấy ngày giờ hiện tại

                // 3. Thêm vào database và lưu thay đổi
                db.LichSuMuaHangs.InsertOnSubmit(newItem);
                db.SubmitChanges();

                // 4. Thông báo thành công
                MessageBox.Show("Thanh toán gói chơi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5. Đóng form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu vào lịch sử mua hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}