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
        public formPrinter()
        {
            InitializeComponent();
        }

        private void formPrinter_Load(object sender, EventArgs e)
        {
            //truyen du lieu vao report

            ReportParameter[] para = new ReportParameter[1];
            para[0] = new ReportParameter("nguoidung", formLogin.TenDangNhap);
            this.reportViewer1.LocalReport.SetParameters(para); //nap du lieu report
            this.reportViewer1.LocalReport.DataSources.Clear();
            databaseDataContext db = new databaseDataContext();
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetLichSuMuaHang", db.LichSuMuaHangs.ToList()));
            this.reportViewer1.RefreshReport();
        }
    }
}
