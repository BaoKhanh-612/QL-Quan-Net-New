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
    public partial class formOrderFood : Form
    {
        private ListView.ListViewItemCollection foodItems;
        public formOrderFood(ListView.ListViewItemCollection items)
        {
            InitializeComponent();
            foodItems = items;
            this.Load += new System.EventHandler(this.formOrderF_Load);
        }

        private void SetupListView()
        {
            lvHoaDon.Columns.Clear();
            lvHoaDon.View = View.Details;
            lvHoaDon.FullRowSelect = true;
            lvHoaDon.Columns.Add("Mã món ăn", 100);
            lvHoaDon.Columns.Add("Tên món ăn", 200);
            lvHoaDon.Columns.Add("Giá tiền", 100);
            lvHoaDon.Columns.Add("Số lượng", 100);
        }

        private void formOrderF_Load(object sender, EventArgs e)
        {
            SetupListView();
            decimal tongTien = 0;
            if (foodItems != null)
            {
                foreach (ListViewItem item in foodItems)
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

        private void btnCashF_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvHoaDon.Items)
            {
                PurchaseHistory.Items.Add(new PurchaseHistoryItem
                {
                    Name = item.SubItems[1].Text,
                    Quantity = int.Parse(item.SubItems[3].Text),
                    Price = decimal.Parse(item.SubItems[2].Text),
                    Type = "Món ăn",
                    PurchaseDate = DateTime.Now
                });
            }

            formConfirmPaymentFood form = new formConfirmPaymentFood();
            form.ShowDialog();
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang thử nghiệm. Vui lòng chọn phương thức khác !", "Thong bao ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
