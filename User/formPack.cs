using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quan_Li_Tiem_Net
{
    public partial class formPack : Form
    {
        private bool isListViewSetup = false;
        public formPack()
        {
            InitializeComponent();
            lvGoiChoi.SelectedIndexChanged += new EventHandler(lvGoiChoi_SelectedIndexChanged);
            numericUpDown1.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
            btnThem.Click += new EventHandler(btnThem_Click);
            btnXoa.Click += new EventHandler(btnXoa_Click);
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            formUser form = new formUser();
            form.ShowDialog();
        }

        private void dgvGoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (idrow == -1) return;
            hienthiDuLieuDong(idrow);
        }
        private void hienthiDuLieuDong(int idrow)
        {
            databaseDataContext db = new databaseDataContext();
            string magoi = dgvGoi.Rows[idrow].Cells[0].Value.ToString();
            GoiChoi goi = db.GoiChois.Where(p => p.MaGoi == magoi).SingleOrDefault();
            if (goi != null)
            {
                txtMaGoi.Text = goi.MaGoi;
                txtTenGoi.Text = goi.TenGoi;
                txtGiaTien.Text = goi.GiaTien;
            }
        }

        private void formPack_Load(object sender, EventArgs e)
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
            lvGoiChoi.Columns.Clear();
            lvGoiChoi.View = View.Details;
            lvGoiChoi.FullRowSelect = true;
            lvGoiChoi.Columns.Add("Mã gói", 100);
            lvGoiChoi.Columns.Add("Tên gói", 230);
            lvGoiChoi.Columns.Add("Giá tiền", 150);
            lvGoiChoi.Columns.Add("Số lượng", 100);
        }

        private void loadDuLieu()
        {
            databaseDataContext db = new databaseDataContext();
            dgvGoi.DataSource = db.GoiChois.OrderBy(p => p.MaGoi);
            if (db.GoiChois.ToList().Count > 0)
                hienthiDuLieuDong(0);
        }
        // ====== THÊM HÀM NÀY VÀO ======
        // Hàm này để form Admin (Formgoichoi) có thể gọi
        public void ReloadData()
        {
            loadDuLieu(); // Gọi lại hàm tải dữ liệu
        }
        // ====== KẾT THÚC THÊM ======
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaGoi.Text))
            {
                MessageBox.Show("Vui lòng chọn một gói để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the item already exists in the listView
            foreach (ListViewItem item in lvGoiChoi.Items)
            {
                if (item.SubItems[0].Text == txtMaGoi.Text)
                {
                    MessageBox.Show("Gói đã có sẵn. Vui lòng chọn một gói để thay đổi số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // Add the new item to the listView
            ListViewItem lvi = new ListViewItem(txtMaGoi.Text);
            lvi.SubItems.Add(txtTenGoi.Text);
            lvi.SubItems.Add(txtGiaTien.Text);
            lvi.SubItems.Add(numericUpDown1.Value.ToString());
            lvGoiChoi.Items.Add(lvi);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvGoiChoi.SelectedItems.Count > 0)
            {
                lvGoiChoi.Items.Remove(lvGoiChoi.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một gói để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lvGoiChoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGoiChoi.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvGoiChoi.SelectedItems[0];
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
            if (lvGoiChoi.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvGoiChoi.SelectedItems[0];
                selectedItem.SubItems[3].Text = numericUpDown1.Value.ToString();
            }
        }

        private void btnMuaGoi_Click(object sender, EventArgs e)
        {
            if (lvGoiChoi.Items.Count == 0)
            {
                MessageBox.Show("Hãy chọn gói chơi để mua gói", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                formOrdPack form = new formOrdPack(lvGoiChoi.Items);
                form.ShowDialog();
            }
            
        }

        
    }
}
