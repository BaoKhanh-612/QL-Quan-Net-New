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
            foreach (ListViewItem item in lvHoaDon.Items)
            {
                PurchaseHistory.Items.Add(new PurchaseHistoryItem
                {
                    Name = item.SubItems[1].Text,
                    Quantity = int.Parse(item.SubItems[3].Text),
                    Price = decimal.Parse(item.SubItems[2].Text),
                    Type = "Đồ uống",
                    PurchaseDate = DateTime.Now
                });
            }

            formConfirmPaymentDrink form = new formConfirmPaymentDrink();
            form.ShowDialog();

        }
    }
}
