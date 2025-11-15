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
    public partial class formOrdPack : Form
    {
        private ListView.ListViewItemCollection packItems;
        public formOrdPack(ListView.ListViewItemCollection items)
        {
            InitializeComponent();
            packItems = items;
            this.Load += new System.EventHandler(this.formOrdPack_Load);
        }

        private void SetupListView()
        {
            lvHoaDon.Columns.Clear();
            lvHoaDon.View = View.Details;
            lvHoaDon.FullRowSelect = true;
            lvHoaDon.Columns.Add("Mã gói", 100);
            lvHoaDon.Columns.Add("Tên gói", 200);
            lvHoaDon.Columns.Add("Giá tiền", 100);
            lvHoaDon.Columns.Add("Số lượng", 100);
        }

        private void formOrdPack_Load(object sender, EventArgs e)
        {
            lvHoaDon.Items.Clear();
            SetupListView();
            decimal tongTien = 0;
            if (packItems != null)
            {
                foreach (ListViewItem item in packItems)
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

        // SỬA LẠI HÀM NÀY
        private void btnCashP_Click(object sender, EventArgs e)
        {
            // 1. Lấy tên đăng nhập từ biến static
            string tenDangNhapHienTai = formLogin.TenDangNhap;

            // 2. Kiểm tra
            if (string.IsNullOrEmpty(tenDangNhapHienTai))
            {
                MessageBox.Show("Lỗi: Không tìm thấy người dùng đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Action logicThanhToan = () =>
            {
                decimal tongTien = 0;
                decimal tongGioChoi = 0;

                if (decimal.TryParse(txtTongTien.Text, out tongTien))
                {
                    try // Thêm try-catch để bắt lỗi database
                    {
                        databaseDataContext db = new databaseDataContext(); // Mở kết nối DB

                        foreach (ListViewItem item in lvHoaDon.Items)
                        {
                            string tenGoi = item.SubItems[1].Text;
                            int soLuong = int.Parse(item.SubItems[3].Text);

                            decimal gioChoi = 0;
                            try
                            {
                                string[] parts = tenGoi.Split('-');
                                if (parts.Length > 1)
                                {
                                    string gioPart = parts[1].Trim();
                                    string[] gioParts = gioPart.Split(' ');
                                    if (gioParts.Length > 0)
                                    {
                                        decimal.TryParse(gioParts[0], out gioChoi);
                                    }
                                }
                            }
                            catch (Exception) { }
                            tongGioChoi += gioChoi * soLuong;

                            // 3. THAY THẾ PurchaseHistory.Items BẰNG LOGIC DB
                            LichSuMuaHang newItem = new LichSuMuaHang();
                            newItem.TenDangNhap = tenDangNhapHienTai; // Dùng tên đăng nhập
                            newItem.TenSanPham = item.SubItems[1].Text;
                            newItem.Loai = "Gói chơi";
                            newItem.SoLuong = int.Parse(item.SubItems[3].Text);
                            newItem.GiaTien = decimal.Parse(item.SubItems[2].Text);
                            newItem.NgayMua = DateTime.Now;

                            db.LichSuMuaHangs.InsertOnSubmit(newItem);
                        }

                        // 4. LƯU VÀO DATABASE
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu vào lịch sử mua hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Dừng lại nếu lỗi
                    }
                }

                // 5. Code cũ của bạn giữ nguyên
                formUser.AddPurchase(tongTien, tongGioChoi);
                MessageBox.Show("Thanh toán thành công. Đã thêm giờ chơi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Nhân viên sẽ đến thu tiền !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                formPack form = new formPack();
                form.ShowDialog();
            };

            formConfirmPaymentPack confirmForm = new formConfirmPaymentPack(logicThanhToan);
            confirmForm.ShowDialog();
        }

        private void btnCredit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Đang thử nghiệm. Vui lòng chọn phương thức khác !", "Thong bao ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}