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
    public partial class formFood : Form
    {
        private bool isListViewSetup = false;
        public formFood()
        {
            InitializeComponent();
            listView1.SelectedIndexChanged += new EventHandler(listView1_SelectedIndexChanged);
            numericUpDown1.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
        }

        private void formFood_Load(object sender, EventArgs e)
        {
            loadDuLieu();
            if (!isListViewSetup)
            {
                SetupListView();
                isListViewSetup = true;
            }
        }

        private void SetupListView()
        {
            listView1.Columns.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Mã món ăn", 100);
            listView1.Columns.Add("Tên món ăn", 230);
            listView1.Columns.Add("Giá tiền", 150);
            listView1.Columns.Add("Số lượng", 100);
            
        }

        private void loadDuLieu()
        {
            databaseDataContext db = new databaseDataContext();
            dgvMonAn.DataSource = db.MonAns.OrderBy(p => p.MaMonAn);
            if (db.MonAns.ToList().Count > 0)
                hienthiDuLieuDong(0);
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (idrow == -1) return;
            hienthiDuLieuDong(idrow);
        }

        private void hienthiDuLieuDong(int idrow)
        {
            databaseDataContext db = new databaseDataContext();
            string mamonan = dgvMonAn.Rows[idrow].Cells[0].Value.ToString();
            MonAn monan = db.MonAns.Where(p => p.MaMonAn == mamonan).SingleOrDefault();
            if (monan != null)
            {
                txtMaMonAn.Text = mamonan.ToString();
                txtTenMonAn.Text = monan.TenMonAn;
                txtGiaTien.Text = monan.GiaTien.ToString();
            }
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            formUser form = new formUser();
            form.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMonAn.Text))
            {
                MessageBox.Show("Vui lòng chọn một món ăn để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the item already exists in the listView
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text == txtMaMonAn.Text)
                {
                    MessageBox.Show("Món đã có sẵn. Vui lòng chọn món ăn để thay đổi số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // Add the new item to the listView
            ListViewItem lvi = new ListViewItem(txtMaMonAn.Text);
            lvi.SubItems.Add(txtTenMonAn.Text);
            lvi.SubItems.Add(txtGiaTien.Text);
            lvi.SubItems.Add(numericUpDown1.Value.ToString());
            listView1.Items.Add(lvi);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món ăn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Hãy chọn món ăn để đặt món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                formOrderFood form = new formOrderFood(listView1.Items);
                form.ShowDialog();
            }
        }

        
    }
}
