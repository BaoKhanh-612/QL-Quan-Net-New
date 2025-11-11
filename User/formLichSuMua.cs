using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Tiem_Net.User
{
    public partial class formLichSuMua : Form
    {
        public formLichSuMua()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.formLichSuMua_Load);
        }

        private void formLichSuMua_Load(object sender, EventArgs e)
        {
            SetupListView();
            LoadPurchaseHistory();
        }

        private void SetupListView()
        {
            lvLichSuMua.Columns.Clear();
            lvLichSuMua.View = View.Details;
            lvLichSuMua.FullRowSelect = true;
            lvLichSuMua.Columns.Add("Tên sản phẩm", 300);
            lvLichSuMua.Columns.Add("Loại", 100);
            lvLichSuMua.Columns.Add("Số lượng", 80);
            lvLichSuMua.Columns.Add("Giá", 100);
            lvLichSuMua.Columns.Add("Ngày mua", 150);
        }

        private void LoadPurchaseHistory()
        {
            lvLichSuMua.Items.Clear();
            foreach (var item in PurchaseHistory.Items)
            {
                ListViewItem lvi = new ListViewItem(item.Name);
                lvi.SubItems.Add(item.Type);
                lvi.SubItems.Add(item.Quantity.ToString());
                lvi.SubItems.Add(item.Price.ToString("N0"));
                lvi.SubItems.Add(item.PurchaseDate.ToString("g"));
                lvLichSuMua.Items.Add(lvi);
            }
        }
    }
}
