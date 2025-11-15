using System;
using System.Linq;
using System.Windows.Forms;
using Quan_Li_Tiem_Net; // để dùng formPack, GoiChoi, databaseDataContext

namespace Quan_Li_Tiem_Net.Admin
{
    public partial class Formgoichoi : Form
    {
        // Form user (formPack) để gọi ReloadData sau khi admin sửa
        private readonly formPack _userForm;

        // Lưu Mã gói đang được chọn
        private string _selectedMaGoi = null;

        public Formgoichoi(formPack userForm)
        {
            InitializeComponent();
            _userForm = userForm;

            // Gắn event (sự kiện) cho các nút và grid
            this.Load += Formgoichoi_Load;
            dgvGoi.CellClick += DgvGoiChoi_CellClick;

            // 3 Nút chức năng
            button1.Click += button1_Click;     // Nút "Thêm"
            btnThem.Click += BtnThem_Click;     // Nút "Chỉnh sửa"
            btnXoa.Click += BtnXoa_Click;       // Nút "Xóa"

            btnQuayVe.Click += BtnQuayVe_Click;
        }

        // ====== QUẢN LÝ TRẠNG THÁI FORM ======

        // Chuyển form về trạng thái "Thêm mới"
        private void ChuanBiThemMoi()
        {
            _selectedMaGoi = null;
            txtMaGoi.Clear();
            txtTenGoi.Clear();
            txtGiaTien.Clear();

            txtMaGoi.ReadOnly = false; // CHO PHÉP NHẬP MÃ MỚI
            txtMaGoi.Focus();

            // Bật/tắt các nút
            button1.Enabled = true;     // Bật nút "Thêm"
            btnThem.Enabled = false;    // Tắt nút "Chỉnh sửa"
            btnXoa.Enabled = false;     // Tắt nút "Xóa"
        }

        // Chuyển form sang trạng thái "Sửa/Xóa" (sau khi click grid)
        private void ChuanBiSuaXoa()
        {
            txtMaGoi.ReadOnly = true; // KHÓA MÃ LẠI

            // Bật/tắt các nút
            button1.Enabled = false;    // Tắt nút "Thêm"
            btnThem.Enabled = true;     // Bật nút "Chỉnh sửa"
            btnXoa.Enabled = true;      // Bật nút "Xóa"
        }


        // ====== LOAD DỮ LIỆU ======
        private void Formgoichoi_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            ChuanBiThemMoi(); // Mặc định là trạng thái "Thêm mới"
        }

        private void LoadDuLieu()
        {
            using (databaseDataContext db = new databaseDataContext())
            {
                // Tải dữ liệu từ bảng GoiChois
                dgvGoi.DataSource = db.GoiChois
                                         .OrderBy(p => p.MaGoi)
                                         .ToList();
            }
        }

        // ====== CLICK VÀO GRID -> CHUYỂN SANG CHẾ ĐỘ SỬA ======
        private void DgvGoiChoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (idrow < 0) return;

            string ma = Convert.ToString(dgvGoi.Rows[idrow].Cells["MaGoi"].Value);
            txtMaGoi.Text = ma;
            txtTenGoi.Text = Convert.ToString(dgvGoi.Rows[idrow].Cells["TenGoi"].Value);
            txtGiaTien.Text = Convert.ToString(dgvGoi.Rows[idrow].Cells["GiaTien"].Value);

            // Lưu mã đang chọn và chuyển trạng thái
            _selectedMaGoi = ma;
            ChuanBiSuaXoa(); // Chuyển sang chế độ Sửa/Xóa
        }

        // ====== NÚT THÊM MỚI (button1) ======
        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Validate (Kiểm tra)
            string ma = txtMaGoi.Text.Trim();
            string ten = txtTenGoi.Text.Trim();
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(txtGiaTien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã gói, Tên gói và Giá tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (db.GoiChois.Any(p => p.MaGoi == ma))
                {
                    MessageBox.Show("Mã gói này đã tồn tại. Vui lòng chọn mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng mới
                GoiChoi goi = new GoiChoi
                {
                    MaGoi = ma,
                    TenGoi = ten,
                    GiaTien = gia.ToString() // Lưu giá_dạng_string vào CSDL
                };

                db.GoiChois.InsertOnSubmit(goi);
                db.SubmitChanges();
            }

            // 3. Tải lại dữ liệu
            LoadDuLieu();
            _userForm?.ReloadData(); // Cập nhật bên User

            MessageBox.Show("Thêm gói chơi mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ChuanBiThemMoi(); // Reset form về trạng thái thêm mới
        }


        // ====== NÚT CHỈNH SỬA (btnThem) ======
        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_selectedMaGoi))
            {
                MessageBox.Show("Không có gói nào được chọn để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (databaseDataContext db = new databaseDataContext())
            {
                GoiChoi goi = db.GoiChois.SingleOrDefault(p => p.MaGoi == _selectedMaGoi);
                if (goi == null)
                {
                    MessageBox.Show("Không tìm thấy mã gói trong CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                goi.TenGoi = txtTenGoi.Text.Trim();

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
                goi.GiaTien = gia.ToString();

                db.SubmitChanges();
            }

            // Tải lại
            LoadDuLieu();
            _userForm?.ReloadData();

            MessageBox.Show("Cập nhật gói chơi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ChuanBiThemMoi(); // Reset form
        }

        // ====== NÚT XÓA (btnXoa) ======
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_selectedMaGoi))
            {
                MessageBox.Show("Không có gói nào được chọn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa gói chơi này không?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            using (databaseDataContext db = new databaseDataContext())
            {
                GoiChoi goi = db.GoiChois.SingleOrDefault(p => p.MaGoi == _selectedMaGoi);
                if (goi == null)
                {
                    MessageBox.Show("Không tìm thấy mã gói trong CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                db.GoiChois.DeleteOnSubmit(goi);
                db.SubmitChanges();
            }

            // Tải lại
            LoadDuLieu();
            _userForm?.ReloadData();

            MessageBox.Show("Xóa gói chơi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ChuanBiThemMoi(); // Reset form
        }

        // ====== NÚT QUAY VỀ ======
        private void BtnQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaGoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenGoi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}