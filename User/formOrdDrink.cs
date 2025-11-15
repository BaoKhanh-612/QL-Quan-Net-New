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
    public partial class formOrderDrink : Form
    {
        private ListView.ListViewItemCollection drinkItems;
        public formOrderDrink(ListView.ListViewItemCollection items)
        {
            InitializeComponent();
            drinkItems = items;
            this.Load += new System.EventHandler(this.formOrderD_Load);
        }

        private void SetupListView()
        {
            lvHoaDon.Columns.Clear();
            lvHoaDon.View = View.Details;
            lvHoaDon.FullRowSelect = true;
            lvHoaDon.Columns.Add("Mã đồ uống", 100);
            lvHoaDon.Columns.Add("Tên đồ uống", 200);
            lvHoaDon.Columns.Add("Giá tiền", 100);
            lvHoaDon.Columns.Add("Số lượng", 100);
        }

        private void formOrderD_Load(object sender, EventArgs e)
        {
            SetupListView();
            decimal tongTien = 0;
            if (drinkItems != null)
            {
                foreach (ListViewItem item in drinkItems)
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

    
        private void btnCredit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Đang thử nghiệm. Vui lòng chọn phương thức khác !", "Thong bao ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCashD_Click_1(object sender, EventArgs e)
        {
            // 1. ĐẶT DÒNG CỦA BẠN Ở ĐÂY
            string tenDangNhapHienTai = formLogin.TenDangNhap;

            // 2. Kiểm tra
            if (string.IsNullOrEmpty(tenDangNhapHienTai))
            {
                MessageBox.Show("Lỗi: Không tìm thấy người dùng đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Tạo một "Hành động" (Action) để lưu vào database
            Action saveOrderAction = () =>
            {
                try
                {
                    databaseDataContext db = new databaseDataContext();

                    // 4. Duyệt qua danh sách và LƯU VÀO DATABASE
                    foreach (ListViewItem item in lvHoaDon.Items)
                    {
                        // Dùng 'LichSuMuaHang' (từ database.designer.cs)
                        LichSuMuaHang newItem = new LichSuMuaHang();
                        newItem.TenDangNhap = tenDangNhapHienTai; // Dùng tên đăng nhập
                        newItem.TenSanPham = item.SubItems[1].Text;
                        newItem.Loai = "Đồ uống";
                        newItem.SoLuong = int.Parse(item.SubItems[3].Text);
                        newItem.GiaTien = decimal.Parse(item.SubItems[2].Text);
                        newItem.NgayMua = DateTime.Now;

                        db.LichSuMuaHangs.InsertOnSubmit(newItem);
                    }

                    // 5. Lưu tất cả thay đổi
                    db.SubmitChanges();

                    MessageBox.Show("Thanh toán thành công! Nhân viên sẽ đến mang đồ uống và thu tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form Order lại
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu vào lịch sử mua hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            // 6. Mở form xác nhận VÀ TRUYỀN HÀNH ĐỘNG vào
            // (Bạn phải sửa formConfirmPaymentDrink để nhận Action này - xem bên dưới)
            formConfirmPaymentDrink form = new formConfirmPaymentDrink(saveOrderAction);
            form.ShowDialog();

        }
    }
}
