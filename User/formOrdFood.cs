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
    public partial class formOrderFood : Form
    {
        private ListView.ListViewItemCollection foodItems;
        public formOrderFood(ListView.ListViewItemCollection items)
        {
            InitializeComponent();
            foodItems = items;
            this.Load += new System.EventHandler(this.formOrderF_Load);
        }

        private void SetupListView()
        {
            lvHoaDon.Columns.Clear();
            lvHoaDon.View = View.Details;
            lvHoaDon.FullRowSelect = true;
            lvHoaDon.Columns.Add("Mã món ăn", 100);
            lvHoaDon.Columns.Add("Tên món ăn", 200);
            lvHoaDon.Columns.Add("Giá tiền", 100);
            lvHoaDon.Columns.Add("Số lượng", 100);
        }

        private void formOrderF_Load(object sender, EventArgs e)
        {
            SetupListView();
            decimal tongTien = 0;
            if (foodItems != null)
            {
                foreach (ListViewItem item in foodItems)
                {
                    lvHoaDon.Items.Add((ListViewItem)item.Clone());
                    if (decimal.TryParse(item.SubItems[2].Text, out decimal giaTien) && int.TryParse(item.SubItems[3].Text, out int soLuong))
                    {
                        tongTien += giaTien * soLuong;
                    }
                }
            }
            txtTongTien.Text = tongTien.ToString();
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        // SỬA LẠI TOÀN BỘ HÀM NÀY
        private void btnCashF_Click(object sender, EventArgs e)
        {
            // 1. Lấy tên đăng nhập từ biến static của formLogin
            string tenDangNhapHienTai = formLogin.TenDangNhap;

            // 2. Kiểm tra
            if (string.IsNullOrEmpty(tenDangNhapHienTai))
            {
                MessageBox.Show("Lỗi: Không tìm thấy người dùng đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Tạo "Hành động" (Action) để lưu vào database
            Action saveOrderAction = () =>
            {
                try
                {
                    databaseDataContext db = new databaseDataContext();

                    // 4. Duyệt qua danh sách và LƯU VÀO DATABASE
                    // (thay thế cho PurchaseHistory.Items)
                    foreach (ListViewItem item in lvHoaDon.Items)
                    {
                        // Dùng 'LichSuMuaHang' (từ database.designer.cs)
                        LichSuMuaHang newItem = new LichSuMuaHang();
                        newItem.TenDangNhap = tenDangNhapHienTai; // Dùng tên đăng nhập
                        newItem.TenSanPham = item.SubItems[1].Text; // Tên món
                        newItem.Loai = "Món ăn";
                        newItem.SoLuong = int.Parse(item.SubItems[3].Text);
                        newItem.GiaTien = decimal.Parse(item.SubItems[2].Text);
                        newItem.NgayMua = DateTime.Now;

                        db.LichSuMuaHangs.InsertOnSubmit(newItem);
                    }

                    // 5. Lưu tất cả thay đổi
                    db.SubmitChanges();

                    MessageBox.Show("Thanh toán thành công! Nhân viên sẽ đến mang món và thu tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form Order lại
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu vào lịch sử mua hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            // 6. Mở form xác nhận VÀ TRUYỀN HÀNH ĐỘNG vào
            formConfirmPaymentFood form = new formConfirmPaymentFood(saveOrderAction);
            form.ShowDialog();
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang thử nghiệm. Vui lòng chọn phương thức khác !", "Thong bao ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}