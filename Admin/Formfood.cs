using System;
using System.Linq;
using System.Windows.Forms;
using Quan_Li_Tiem_Net; // Để dùng formFood, MonAn, databaseDataContext

namespace Quan_Li_Tiem_Net.Admin
{
    public partial class Formfood : Form
    {
        // Form user để gọi ReloadData sau khi admin sửa
        private readonly formFood _userForm;

        // Lưu Mã món ăn đang được chọn
        private string _selectedMaMonAn = null;

        public Formfood(formFood userForm) // Nhận formFood từ bên ngoài
        {
            InitializeComponent();
            _userForm = userForm;

            // Gắn event (sự kiện)
            this.Load += Formfood_Load;
            dgvMonAn.CellClick += DgvMonAn_CellClick;

            // SỬA Ở ĐÂY: Đổi tên nút cho khớp với file Designer
            // Nút "Thêm mới" của bạn tên là "btnThem"
            // Nút "Chỉnh sửa" của bạn tên là "button1"
            btnThem.Click += btnThemMoi_Click; // Nút "Thêm mới" (tên btnThem, gọi hàm ThemMoi)
            button1.Click += BtnSua_Click;     // Nút "Chỉnh sửa" (tên button1, gọi hàm Sua)
            btnXoa.Click += BtnXoa_Click;      // Nút "Xóa"

            btnQuayVe.Click += BtnQuayVe_Click;
        }

        // ====== QUẢN LÝ TRẠNG THÁI FORM ======

        // Chuyển form về trạng thái "Thêm mới"
        private void ChuanBiThemMoi()
        {
            _selectedMaMonAn = null;
            txtMaMonAn.Clear();
            txtTenMonAn.Clear();
            txtGiaTien.Clear();

            txtMaMonAn.ReadOnly = false; // CHO PHÉP NHẬP MÃ MỚI
            txtMaMonAn.Focus();

            // SỬA Ở ĐÂY: Đổi tên nút
            btnThem.Enabled = true;     // Bật nút "Thêm mới" (tên btnThem)
            button1.Enabled = false;    // Tắt nút "Chỉnh sửa" (tên button1)
            btnXoa.Enabled = false;     // Tắt nút "Xóa"
        }

        // Chuyển form sang trạng thái "Sửa/Xóa" (sau khi click grid)
        private void ChuanBiSuaXoa()
        {
            txtMaMonAn.ReadOnly = true; // KHÓA MÃ LẠI

            // SỬA Ở ĐÂY: Đổi tên nút
            btnThem.Enabled = false;    // Tắt nút "Thêm mới" (tên btnThem)
            button1.Enabled = true;     // Bật nút "Chỉnh sửa" (tên button1)
            btnXoa.Enabled = true;      // Bật nút "Xóa"
        }

        // ====== LOAD DỮ LIỆU ======
        private void Formfood_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            ChuanBiThemMoi(); // Mặc định là trạng thái "Thêm mới"
        }

        private void LoadDuLieu()
        {
            using (databaseDataContext db = new databaseDataContext())
            {
                dgvMonAn.DataSource = db.MonAns
                                         .OrderBy(p => p.MaMonAn)
                                         .ToList();
            }
        }

        // ====== CLICK VÀO GRID -> CHUYỂN SANG CHẾ ĐỘ SỬA ======
        private void DgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (idrow < 0) return;

            // Dùng Convert.ToString() để lấy giá trị an toàn
            string ma = Convert.ToString(dgvMonAn.Rows[idrow].Cells["MaMonAn"].Value);

            txtMaMonAn.Text = ma;
            txtTenMonAn.Text = Convert.ToString(dgvMonAn.Rows[idrow].Cells["TenMonAn"].Value);
            txtGiaTien.Text = Convert.ToString(dgvMonAn.Rows[idrow].Cells["GiaTien"].Value);

            // Lưu mã đang chọn và chuyển trạng thái
            _selectedMaMonAn = ma;
            ChuanBiSuaXoa(); // Chuyển sang chế độ Sửa/Xóa
        }

        // ====== NÚT THÊM MỚI (btnThem) ======
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // 1. Validate (Kiểm tra)
            string ma = txtMaMonAn.Text.Trim();
            string ten = txtTenMonAn.Text.Trim();
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(txtGiaTien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã, Tên và Giá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtGiaTien.Text, out decimal gia))
            {
                MessageBox.Show("Giá tiền không hợp lệ. Vui lòng nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (gia < 0)
            {
                MessageBox.Show("Giá tiền không được phép là số âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 2. Thêm vào CSDL
            using (databaseDataContext db = new databaseDataContext())
            {
                // Kiểm tra trùng mã
                if (db.MonAns.Any(p => p.MaMonAn == ma))
                {
                    MessageBox.Show("Mã món ăn này đã tồn tại. Vui lòng chọn mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng mới
                MonAn monan = new MonAn
                {
                    MaMonAn = ma,
                    TenMonAn = ten,
                    GiaTien = gia.ToString() // Lưu giá_dạng_string vào CSDL
                };

                db.MonAns.InsertOnSubmit(monan);
                db.SubmitChanges();
            }

            // 3. Tải lại dữ liệu
            LoadDuLieu();
            _userForm?.ReloadData(); // Cập nhật bên User

            MessageBox.Show("Thêm món ăn mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ChuanBiThemMoi(); // Reset form về trạng thái thêm mới
        }


        // ====== NÚT CHỈNH SỬA (button1) ======
        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_selectedMaMonAn))
            {
                MessageBox.Show("Không có món ăn nào được chọn để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (databaseDataContext db = new databaseDataContext())
            {
                MonAn monan = db.MonAns.SingleOrDefault(p => p.MaMonAn == _selectedMaMonAn);
                if (monan == null)
                {
                    MessageBox.Show("Không tìm thấy mã món ăn trong CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                monan.TenMonAn = txtTenMonAn.Text.Trim();

                if (!decimal.TryParse(txtGiaTien.Text, out decimal gia))
                {
                    MessageBox.Show("Giá tiền không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (gia < 0)
                {
                    MessageBox.Show("Giá tiền không được phép là số âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                monan.GiaTien = gia.ToString();

                db.SubmitChanges();
            }

            // Tải lại
            LoadDuLieu();
            _userForm?.ReloadData(); // Cập nhật bên User

            MessageBox.Show("Cập nhật món ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ChuanBiThemMoi(); // Reset form
        }

        // ====== NÚT XÓA (btnXoa) ======
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_selectedMaMonAn))
            {
                MessageBox.Show("Không có món ăn nào được chọn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa món ăn này không?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            using (databaseDataContext db = new databaseDataContext())
            {
                MonAn monan = db.MonAns.SingleOrDefault(p => p.MaMonAn == _selectedMaMonAn);
                if (monan == null)
                {
                    MessageBox.Show("Không tìm thấy mã món ăn trong CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                db.MonAns.DeleteOnSubmit(monan);
                db.SubmitChanges();
            }

            // Tải lại
            LoadDuLieu();
            _userForm?.ReloadData(); // Cập nhật bên User

            MessageBox.Show("Xóa món ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ChuanBiThemMoi(); // Reset form
        }

        // ====== NÚT QUAY VỀ ======
        private void BtnQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}