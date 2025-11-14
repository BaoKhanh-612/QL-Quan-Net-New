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

        // Biến này sẽ lưu Mã đồ uống đang được chọn, an toàn hơn là đọc từ textbox
        private string _selectedMaDoUong = null;

        public FormDrrink(formDrink userForm)
        {
            InitializeComponent();
            _userForm = userForm;

            // Gắn event - ĐÃ ĐỔI TÊN THEO QUY TẮC PASCALCASE
            this.Load += FormDrrink_Load;
            dgvDoUong.CellClick += DgvDoUong_CellClick; // đổi tên
            btnThem.Click += BtnThem_Click;     // đổi tên (nút CHỈNH SỬA)
            btnXoa.Click += BtnXoa_Click;       // đổi tên (nút XÓA)
            btnQuayVe.Click += BtnQuayVe_Click; // tên này đã đúng
        }

        // ====== LOAD DỮ LIỆU LÊN GRID ADMIN ======
        private void FormDrrink_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            // Khóa textbox Mã, vì Admin chỉ nên sửa Tên và Giá
            txtMaDoUong.ReadOnly = true;
            txtMaDoUong.Text = "(Vui lòng chọn món từ lưới)";
        }

        private void LoadDuLieu()
        {
            using (databaseDataContext db = new databaseDataContext())
            {
                dgvDoUong.DataSource = db.DoUongs
                                         .OrderBy(p => p.MaDoUong)
                                         .ToList();
            }
            // Reset lại lựa chọn
            _selectedMaDoUong = null;
            txtMaDoUong.Text = "(Vui lòng chọn món từ lưới)";
            txtTenDoUong.Clear();
            txtGiaTien.Clear();
        }

        // ====== CLICK VÀO GRID -> ĐỔ LÊN TEXTBOX ======
        // Đã đổi tên hàm
        private void DgvDoUong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (idrow < 0) return;

            // **CÁCH VIẾT KHÁC (1):**
            // Dùng Convert.ToString() thay vì .Value?.ToString()
            // Cách này cũng an toàn, xử lý null tốt và có thể "làm mới" lỗi của IDE
            string ma = Convert.ToString(dgvDoUong.Rows[idrow].Cells["MaDoUong"].Value);

            txtMaDoUong.Text = ma;
            txtTenDoUong.Text = Convert.ToString(dgvDoUong.Rows[idrow].Cells["TenDoUong"].Value);
            txtGiaTien.Text = Convert.ToString(dgvDoUong.Rows[idrow].Cells["GiaTien"].Value);

            // **CÁCH VIẾT KHÁC (2):**
            // Lưu mã đang chọn vào biến riêng, không phụ thuộc vào .Text của textbox
            _selectedMaDoUong = ma;
        }

        // ====== NÚT CHỈNH SỬA ======
        // Đã đổi tên hàm
        private void BtnThem_Click(object sender, EventArgs e)
        {
            // **CÁCH VIẾT KHÁC (2) - Áp dụng:**
            // Kiểm tra biến riêng thay vì textbox
            if (string.IsNullOrWhiteSpace(_selectedMaDoUong))
            {
                MessageBox.Show("Vui lòng chọn đồ uống cần chỉnh sửa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (databaseDataContext db = new databaseDataContext())
            {
                // Tìm bằng biến riêng
                DoUong douong = db.DoUongs.SingleOrDefault(p => p.MaDoUong == _selectedMaDoUong);

                if (douong == null)
                {
                    MessageBox.Show("Không tìm thấy mã đồ uống trong CSDL", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cập nhật tên
                douong.TenDoUong = txtTenDoUong.Text.Trim();

                // **CÁCH VIẾT KHÁC (3):**
                // Tách biệt việc khai báo và gán giá trị 'gia'
                // Đây là dòng 79-86 của bạn, được viết lại một chút
                decimal gia; // 1. Khai báo
                if (!decimal.TryParse(txtGiaTien.Text, out gia)) // 2. Gán
                {
                    MessageBox.Show("Giá tiền không hợp lệ", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                douong.GiaTien = gia.ToString(); ; // 3. Sử dụng

                db.SubmitChanges();
            }

            // Logic quan trọng giữ nguyên:
            LoadDuLieu();
            _userForm?.ReloadData();

            MessageBox.Show("Cập nhật đồ uống thành công", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ====== NÚT XÓA ======
        // Đã đổi tên hàm
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            // **CÁCH VIẾT KHÁC (2) - Áp dụng:**
            // Kiểm tra biến riêng thay vì textbox
            if (string.IsNullOrWhiteSpace(_selectedMaDoUong))
            {
                MessageBox.Show("Vui lòng chọn đồ uống cần xóa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa đồ uống này không?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            using (databaseDataContext db = new databaseDataContext())
            {
                // Tìm bằng biến riêng
                DoUong douong = db.DoUongs.SingleOrDefault(p => p.MaDoUong == _selectedMaDoUong);

                if (douong == null)
                {
                    MessageBox.Show("Không tìm thấy mã đồ uống trong CSDL", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                db.DoUongs.DeleteOnSubmit(douong);
                db.SubmitChanges(); // Bạn dùng Context.SubmitChanges() cũng được, cách này cũng vậy
            }

            // Logic quan trọng giữ nguyên:
            LoadDuLieu();
            _userForm?.ReloadData();

            MessageBox.Show("Xóa đồ uống thành công", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ====== NÚT QUAY VỀ ======
        private void BtnQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}