using Microsoft.Reporting.WinForms;
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
    public partial class formPrinter : Form
    {
        // Biến này chỉ để lưu loại cần in
        private string _loaiCanIn;

        // Xóa constructor cũ (nếu có)

        // Constructor MỚI: Chỉ nhận "loai"
        public formPrinter(string loai)
        {
            InitializeComponent();
            this._loaiCanIn = loai;
        }

        private void formPrinter_Load(object sender, EventArgs e)
        {
            // SỬA LỖI: Lấy tên đăng nhập từ biến static của formLogin
            // Giống như code gốc của bạn, cách này đảm bảo luôn có giá trị
            string tenDangNhapHienTai = formLogin.TenDangNhap;

            // 1. Truyền tham số tên người dùng (nguoidung) vào report
            ReportParameter[] para = new ReportParameter[1];
            para[0] = new ReportParameter("nguoidung", tenDangNhapHienTai); // Đã có giá trị
            this.reportViewer1.LocalReport.SetParameters(para);

            // 2. Kết nối database
            databaseDataContext db = new databaseDataContext();

            // 3. Lọc dữ liệu theo tên đăng nhập
            var query = db.LichSuMuaHangs
                          .Where(ls => ls.TenDangNhap == tenDangNhapHienTai);

            // 4. Nếu loại cần in KHÔNG PHẢI là "Tất cả", thì lọc thêm
            if (this._loaiCanIn != "Tất cả")
            {
                query = query.Where(ls => ls.Loai == this._loaiCanIn);
            }

            // 5. Lấy danh sách kết quả ĐÃ ĐƯỢC LỌC
            var duLieuDaLoc = query.OrderByDescending(ls => ls.NgayMua).ToList();

            // 6. Nạp danh sách ĐÃ LỌC vào report
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetLichSuMuaHang", duLieuDaLoc));

            // 7. Làm mới report để hiển thị
            this.reportViewer1.RefreshReport();
        }
    }
}