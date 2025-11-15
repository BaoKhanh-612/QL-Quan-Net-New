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
    public partial class formDrink : Form
    {
        private bool isListViewSetup = false;
        public formDrink()
        {
            InitializeComponent();
            listView1.SelectedIndexChanged += new EventHandler(listView1_SelectedIndexChanged);
            numericUpDown1.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
        }

        private void formDrink_Load(object sender, EventArgs e)
        {
            ReloadData();   // dùng hàm public mới
            if (!isListViewSetup)
            {
                SetupListView();
                isListViewSetup = true;
            }
        }
        public void ReloadData()
        {
            loadDuLieu();   // gọi hàm cũ
        }
        private void SetupListView()
        {
            listView1.Columns.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Mã đồ uống", 100);
            listView1.Columns.Add("Tên đồ uống", 230);
            listView1.Columns.Add("Giá tiền", 150);
            listView1.Columns.Add("Số lượng", 100);

        }

        private void loadDuLieu()
        {
            databaseDataContext db = new databaseDataContext();
            dgvDoUong.DataSource = db.DoUongs.OrderBy(p => p.MaDoUong);
            if (db.DoUongs.ToList().Count > 0)
                hienthiDuLieuDong(0);
        }

        private void dgvDoUong_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (idrow == -1) return;
            hienthiDuLieuDong(idrow);
        }

        private void hienthiDuLieuDong(int idrow)
        {
            databaseDataContext db = new databaseDataContext();
            string madouong = dgvDoUong.Rows[idrow].Cells[0].Value.ToString();
            DoUong douong = db.DoUongs.Where(p => p.MaDoUong == madouong).SingleOrDefault();
            if (douong != null)
            {
                txtMaDoUong.Text = madouong.ToString();
                txtTenDoUong.Text = douong.TenDoUong;
                txtGiaTien.Text = douong.GiaTien.ToString();
            }
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            formUser form = new formUser();
            form.ShowDialog();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDoUong.Text))
            {
                MessageBox.Show("Vui lòng chọn một đồ uống để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the item already exists in the listView
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text == txtMaDoUong.Text)
                {
                    MessageBox.Show("Món đã có sẵn. Vui lòng chọn món ăn để thay đổi số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // Add the new item to the listView
            ListViewItem lvi = new ListViewItem(txtMaDoUong.Text);
            lvi.SubItems.Add(txtTenDoUong.Text);
            lvi.SubItems.Add(txtGiaTien.Text);
            lvi.SubItems.Add(numericUpDown1.Value.ToString());
            listView1.Items.Add(lvi);
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                if (decimal.TryParse(selectedItem.SubItems[3].Text, out decimal quantity))
                {
                    // Temporarily remove the event handler to prevent a loop
                    numericUpDown1.ValueChanged -= numericUpDown1_ValueChanged;
                    numericUpDown1.Value = quantity;
                    // Re-add the event handler
                    numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                selectedItem.SubItems[3].Text = numericUpDown1.Value.ToString();
            }
        }

        private void btnDatMon_Click_1(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Hãy chọn đồ uống để đặt món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                formOrderDrink form = new formOrderDrink(listView1.Items);
                form.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đồ uống để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
