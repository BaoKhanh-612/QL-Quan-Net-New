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
    public partial class formOrdPack : Form
    {
        private ListView.ListViewItemCollection packItems;
        public formOrdPack(ListView.ListViewItemCollection items)
        {
            InitializeComponent();
            packItems = items;
            this.Load += new System.EventHandler(this.formOrdPack_Load);
        }

        private void SetupListView()
        {
            lvHoaDon.Columns.Clear();
            lvHoaDon.View = View.Details;
            lvHoaDon.FullRowSelect = true;
            lvHoaDon.Columns.Add("Mã gói", 100);
            lvHoaDon.Columns.Add("Tên gói", 200);
            lvHoaDon.Columns.Add("Giá tiền", 100);
            lvHoaDon.Columns.Add("Số lượng", 100);
        }

        private void formOrdPack_Load(object sender, EventArgs e)
        {
            lvHoaDon.Items.Clear();
            SetupListView();
            decimal tongTien = 0;
            if (packItems != null)
            {
                foreach (ListViewItem item in packItems)
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

        private void btnCashP_Click(object sender, EventArgs e)
        {
            Action logicThanhToan = () =>
            {
                // CẬP NHẬT: Tính toán tổng tiền và tổng giờ
                decimal tongTien = 0;
                decimal tongGioChoi = 0;

                if (decimal.TryParse(txtTongTien.Text, out tongTien))
                {
                    // Tinh tong gio
                    foreach (ListViewItem item in lvHoaDon.Items)
                    {
                        string tenGoi = item.SubItems[1].Text; // "10.000 VND - 1 giờ chơi"
                        int soLuong = int.Parse(item.SubItems[3].Text);

                        decimal gioChoi = 0;
                        try
                        {
                            // Tách chuỗi để lấy số giờ
                            string[] parts = tenGoi.Split('-');
                            if (parts.Length > 1)
                            {
                                string gioPart = parts[1].Trim(); // "1 giờ chơi"
                                string[] gioParts = gioPart.Split(' '); // ["1", "giờ", "chơi"]
                                if (gioParts.Length > 0)
                                {
                                    decimal.TryParse(gioParts[0], out gioChoi);
                                }
                            }
                        }
                        catch (Exception)
                        {
                            // Bỏ qua nếu lỗi parsing
                        }
                        tongGioChoi += gioChoi * soLuong;

                        // Thêm vào lịch sử mua hàng
                        PurchaseHistory.Items.Add(new PurchaseHistoryItem
                        {
                            Name = item.SubItems[1].Text,
                            Quantity = int.Parse(item.SubItems[3].Text),
                            Price = decimal.Parse(item.SubItems[2].Text),
                            Type = "Gói chơi",
                            PurchaseDate = DateTime.Now
                        });
                    }
                }

                // CẬP NHẬT: Gọi hàm static của formUser để cập nhật
                formUser.AddPurchase(tongTien, tongGioChoi);


                MessageBox.Show("Thanh toán thành công. Đã thêm giờ chơi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Nhân viên sẽ đến thu tiền !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                formPack form = new formPack();
                form.ShowDialog();

            };
        

            formConfirmPaymentPack confirmForm = new formConfirmPaymentPack(logicThanhToan);
            confirmForm.ShowDialog();
        }

        private void btnCredit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Đang thử nghiệm. Vui lòng chọn phương thức khác !", "Thong bao ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

       
    }
}