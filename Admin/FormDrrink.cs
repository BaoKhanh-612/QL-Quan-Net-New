using System;
using System.Linq;
using System.Windows.Forms;
using Quan_Li_Tiem_Net;   // để dùng formDrink, DoUong, databaseDataContext

namespace Quan_Li_Tiem_Net.Admin
{
    public partial class FormDrrink : Form
    {
        // Form user để gọi ReloadData sau khi admin sửa
        private readonly formDrink _userForm;

        // Lưu Mã đồ uống đang được chọn
        private string _selectedMaDoUong = null;

        public FormDrrink(formDrink userForm)
        {
            InitializeComponent();
            _userForm = userForm;

            // Gắn event (sự kiện)
            this.Load += FormDrrink_Load;
            dgvDoUong.CellClick += DgvDoUong_CellClick;

            // 3 Nút chức năng (Giả sử nút mới tên là btnThemMoi)
            btnThemMoi.Click += btnThemMoi_Click; // Nút "Thêm mới"
            btnThem.Click += BtnThem_Click;     // Nút "Chỉnh sửa"
            btnXoa.Click += BtnXoa_Click;       // Nút "Xóa"

            btnQuayVe.Click += BtnQuayVe_Click;
        }

        // ====== QUẢN LÝ TRẠNG THÁI FORM ======

        // Chuyển form về trạng thái "Thêm mới"
        private void ChuanBiThemMoi()
        {
            _selectedMaDoUong = null;
            txtMaDoUong.Clear();
            txtTenDoUong.Clear();
            txtGiaTien.Clear();

            txtMaDoUong.ReadOnly = false; // CHO PHÉP NHẬP MÃ MỚI
            txtMaDoUong.Focus();

            // Bật/tắt các nút
            btnThemMoi.Enabled = true;     // Bật nút "Thêm mới"
            btnThem.Enabled = false;       // Tắt nút "Chỉnh sửa"
            btnXoa.Enabled = false;        // Tắt nút "Xóa"
        }

        // Chuyển form sang trạng thái "Sửa/Xóa" (sau khi click grid)
        private void ChuanBiSuaXoa()
        {
            txtMaDoUong.ReadOnly = true; // KHÓA MÃ LẠI

            // Bật/tắt các nút
            btnThemMoi.Enabled = false;    // Tắt nút "Thêm mới"
            btnThem.Enabled = true;        // Bật nút "Chỉnh sửa"
            btnXoa.Enabled = true;         // Bật nút "Xóa"
        }

        // ====== LOAD DỮ LIỆU ======
        private void FormDrrink_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            ChuanBiThemMoi(); // Mặc định là trạng thái "Thêm mới"
        }

        private void LoadDuLieu()
        {
            using (databaseDataContext db = new databaseDataContext())
            {
                dgvDoUong.DataSource = db.DoUongs
                                         .OrderBy(p => p.MaDoUong)
                                         .ToList();
            }
        }

        // ====== CLICK VÀO GRID -> CHUYỂN SANG CHẾ ĐỘ SỬA ======
        private void DgvDoUong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (idrow < 0) return;

            // Dùng Convert.ToString() để lấy giá trị an toàn
            string ma = Convert.ToString(dgvDoUong.Rows[idrow].Cells["MaDoUong"].Value);

            txtMaDoUong.Text = ma;
            txtTenDoUong.Text = Convert.ToString(dgvDoUong.Rows[idrow].Cells["TenDoUong"].Value);
            txtGiaTien.Text = Convert.ToString(dgvDoUong.Rows[idrow].Cells["GiaTien"].Value);

            // Lưu mã đang chọn và chuyển trạng thái
            _selectedMaDoUong = ma;
            ChuanBiSuaXoa(); // Chuyển sang chế độ Sửa/Xóa
        }

        // ====== NÚT THÊM MỚI (btnThemMoi) ======
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // 1. Validate (Kiểm tra)
            string ma = txtMaDoUong.Text.Trim();
            string ten = txtTenDoUong.Text.Trim();
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
                if (db.DoUongs.Any(p => p.MaDoUong == ma))
                {
                    MessageBox.Show("Mã đồ uống này đã tồn tại. Vui lòng chọn mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng mới
                DoUong douong = new DoUong
                {
                    MaDoUong = ma,
                    TenDoUong = ten,
                    GiaTien = gia.ToString() // Lưu giá_dạng_string vào CSDL
                };

                db.DoUongs.InsertOnSubmit(douong);
                db.SubmitChanges();
            }

            // 3. Tải lại dữ liệu
            LoadDuLieu();
            _userForm?.ReloadData(); // Cập nhật bên User

            MessageBox.Show("Thêm đồ uống mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ChuanBiThemMoi(); // Reset form về trạng thái thêm mới
        }


        // ====== NÚT CHỈNH SỬA (btnThem) ======
        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_selectedMaDoUong))
            {
                MessageBox.Show("Không có đồ uống nào được chọn để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (databaseDataContext db = new databaseDataContext())
            {
                DoUong douong = db.DoUongs.SingleOrDefault(p => p.MaDoUong == _selectedMaDoUong);
                if (douong == null)
                {
                    MessageBox.Show("Không tìm thấy mã đồ uống trong CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                douong.TenDoUong = txtTenDoUong.Text.Trim();

                if (!decimal.TryParse(txtGiaTien.Text, out decimal gia))
                {
                    MessageBox.Show("Giá tiền không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ****** ĐÃ THÊM CHECK GIÁ ÂM VÀO ĐÂY ******
                if (gia < 0)
                {
                    MessageBox.Show("Giá tiền không được phép là số âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // *****************************************

                douong.GiaTien = gia.ToString();

                db.SubmitChanges();
            }

            // Tải lại
            LoadDuLieu();
            _userForm?.ReloadData();

            MessageBox.Show("Cập nhật đồ uống thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ChuanBiThemMoi(); // Reset form
        }

        // ====== NÚT XÓA (btnXoa) ======
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_selectedMaDoUong))
            {
                MessageBox.Show("Không có đồ uống nào được chọn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa đồ uống này không?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            using (databaseDataContext db = new databaseDataContext())
            {
                DoUong douong = db.DoUongs.SingleOrDefault(p => p.MaDoUong == _selectedMaDoUong);
                if (douong == null)
                {
                    MessageBox.Show("Không tìm thấy mã đồ uống trong CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                db.DoUongs.DeleteOnSubmit(douong);
                db.SubmitChanges();
            }

            // Tải lại
            LoadDuLieu();
            _userForm?.ReloadData();

            MessageBox.Show("Xóa đồ uống thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ChuanBiThemMoi(); // Reset form
        }

        // ====== NÚT QUAY VỀ ======
        private void BtnQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}