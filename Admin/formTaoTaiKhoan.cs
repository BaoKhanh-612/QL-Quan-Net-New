using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Thêm thư viện BCrypt.Net
using BCrypt.Net; // <-- THAY ĐỔI

namespace Quan_Li_Tiem_Net
{
    public partial class formTaoTaiKhoan : Form
    {
        // Biến lưu tài khoản đang chọn (dùng cho việc sửa)
        private string _selectedTenDangNhap = null;

        public formTaoTaiKhoan()
        {
            InitializeComponent();

            // Gắn sự kiện Load
            this.Load += formTaoTaiKhoan_Load;

            // Gắn sự kiện cho các nút
            // btnThem sẽ dùng để "Thêm mới" hoặc "Làm mới"
            this.btnThem.Click += btnThem_Click;

            // btnXoa (nút bạn muốn) giờ sẽ là "Chỉnh sửa"
            this.btnsua.Click += btnSua_Click;

            // Gắn sự kiện click cho bảng
            this.dgvDanhSachTaiKhoan.CellClick += dgvDanhSachTaiKhoan_CellClick;
        }

        // === HÀM TẢI DỮ LIỆU (Sửa đổi) ===
        private void LoadData()
        {
            try
            {
                using (databaseDataContext db = new databaseDataContext())
                {
                    var dsTaiKhoan = from tk in db.TaiKhoans
                                     select new
                                     {
                                         tk.TenDangNhap,
                                         tk.LoaiTaiKhoan
                                     };

                    dgvDanhSachTaiKhoan.DataSource = dsTaiKhoan.ToList();

                    dgvDanhSachTaiKhoan.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";
                    dgvDanhSachTaiKhoan.Columns["LoaiTaiKhoan"].HeaderText = "Loại Tài Khoản";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Đặt lại form về chế độ "Thêm mới"
            ChuanBiThemMoi();
        }

        // === HÀM SỰ KIỆN LOAD ===
        private void formTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData(); // Tải dữ liệu ngay khi form mở
        }

        // === HÀM MỚI: XỬ LÝ KHI CLICK VÀO BẢNG (Sửa đổi) ===
        private void dgvDanhSachTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dgvDanhSachTaiKhoan.Rows[e.RowIndex];

                if (row.Cells["TenDangNhap"].Value != null)
                {
                    // 1. Lấy tên đăng nhập
                    _selectedTenDangNhap = row.Cells["TenDangNhap"].Value.ToString();

                    // 2. Chuyển form sang chế độ "Sửa"
                    txtTenDangNhap.Text = _selectedTenDangNhap;
                    txtTenDangNhap.ReadOnly = true; // Không cho sửa Tên đăng nhập (Khóa chính)

                    // 3. Xóa ô mật khẩu để chờ nhập mới
                    txtMatKhau.Clear();
                    txtXacNhanMatKhau.Clear();
                }
            }
        }

        // === HÀM NÚT THÊM (Sửa đổi) ===
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Nếu form đang ở chế độ "Sửa" (ReadOnly = true)
            // thì nút "Thêm" sẽ có chức năng "Làm mới" form
            if (txtTenDangNhap.ReadOnly)
            {
                ChuanBiThemMoi();
                return;
            }

            // --- Nếu không, thì đây là chức năng "Thêm" bình thường ---
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string xacNhanMatKhau = txtXacNhanMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (matKhau != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu và mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (databaseDataContext db = new databaseDataContext())
                {
                    bool daTonTai = db.TaiKhoans.Any(tk => tk.TenDangNhap == tenDangNhap);
                    if (daTonTai)
                    {
                        MessageBox.Show("Tên đăng nhập này đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Băm mật khẩu trước khi lưu
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(matKhau); // <-- THAY ĐỔI

                        TaiKhoan taiKhoanMoi = new TaiKhoan
                        {
                            TenDangNhap = tenDangNhap,
                            MatKhau = hashedPassword, // <-- THAY ĐỔI
                            LoaiTaiKhoan = "User"
                        };

                        db.TaiKhoans.InsertOnSubmit(taiKhoanMoi);
                        db.SubmitChanges();
                        MessageBox.Show("Tạo tài khoản user thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadData(); // Tải lại bảng và làm mới form
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // === HÀM NÚT SỬA (Thay thế hoàn toàn code nút Xóa) ===
        private void btnSua_Click(object sender, EventArgs e)
        {
            // A. Kiểm tra xem có đang ở chế độ "Sửa" không
            if (string.IsNullOrEmpty(_selectedTenDangNhap) || !txtTenDangNhap.ReadOnly)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản từ danh sách để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // B. Kiểm tra an toàn: Không cho sửa tài khoản "admin"
            if (_selectedTenDangNhap.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Không thể sửa tài khoản Admin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // C. Lấy và xác thực mật khẩu mới
            string matKhau = txtMatKhau.Text.Trim();
            string xacNhanMatKhau = txtXacNhanMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(xacNhanMatKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới và xác nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (matKhau != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu và mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // D. Tiến hành cập nhật
            try
            {
                using (databaseDataContext db = new databaseDataContext())
                {
                    // Tìm tài khoản
                    TaiKhoan tkSua = db.TaiKhoans.SingleOrDefault(tk => tk.TenDangNhap == _selectedTenDangNhap);

                    if (tkSua != null)
                    {
                        // Băm mật khẩu mới trước khi cập nhật
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(matKhau); // <-- THAY ĐỔI
                        tkSua.MatKhau = hashedPassword; // <-- THAY ĐỔI
                        db.SubmitChanges();

                        MessageBox.Show("Đã cập nhật mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadData(); // Tải lại bảng và làm mới form
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật tài khoản: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // === HÀM TIỆN ÍCH ===
        private void ChuanBiThemMoi()
        {
            // Reset về trạng thái "Thêm mới"
            _selectedTenDangNhap = null;
            txtTenDangNhap.ReadOnly = false;
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtXacNhanMatKhau.Clear();
            dgvDanhSachTaiKhoan.ClearSelection(); // Bỏ chọn trên bảng
        }

        private void btnexit1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}