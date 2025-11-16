using Quan_Li_Tiem_Net.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Quan_Li_Tiem_Net
{
    public partial class formUser : Form
    {
        // 1. Biến này PHẢI được gán giá trị từ formLogin
        public string currentUsername;

        // THÊM MỚI: Biến theo dõi tổng số tiền/thời gian ĐÃ TỪNG NẠP
        // Dùng để tính tỷ giá trung bình
        public static decimal TotalMoneyEverDeposited = 0;
        public static double TotalSecondsEverPurchased = 0;

        // THÊM MỚI: Biến theo dõi số dư HIỆN TẠI (sẽ đếm ngược)
        public static decimal CurrentMoneyBalance = 0;
        public static double CurrentTimeSeconds = 0;

        // THÊM MỚI: Tỷ giá (VND / giây)
        private static decimal CostPerSecond = 0;

        // Khai báo Timer
        private Timer gameTimer;

        public formUser()
        {
            InitializeComponent();

            // Khởi tạo và cấu hình Timer
            gameTimer = new Timer();
            gameTimer.Interval = 1000; // 1000 milliseconds = 1 giây
            gameTimer.Tick += new EventHandler(timerGioChoi_Tick); // Gắn sự kiện Tick

            UpdateAllDisplays(); // Cập nhật hiển thị khi form tải

            // THÊM MỚI: Khởi động timer nếu có giờ và nó chưa chạy
            if (CurrentTimeSeconds > 0 && !gameTimer.Enabled)
            {
                gameTimer.Start();
            }
        }

        // CẬP NHẬT: Hàm xử lý sự kiện Tick của Timer
        private void timerGioChoi_Tick(object sender, EventArgs e)
        {
            if (CurrentTimeSeconds > 0)
            {
                // Giảm 1 giây
                CurrentTimeSeconds--;

                // CẬP NHẬT: Giảm tiền dựa trên tỷ giá
                CurrentMoneyBalance -= CostPerSecond;

                // Đảm bảo tiền không bị âm do lỗi làm tròn
                if (CurrentMoneyBalance < 0)
                {
                    CurrentMoneyBalance = 0;
                }

                UpdateAllDisplays(); // Cập nhật lại cả 2 Label
            }
            else
            {
                // Hết giờ
                gameTimer.Stop();
                CurrentTimeSeconds = 0;
                CurrentMoneyBalance = 0; // Reset cả tiền về 0 khi hết giờ

                UpdateAllDisplays(); // Cập nhật hiển thị (về 0)
                MessageBox.Show("Bạn đã hết giờ chơi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // CẬP NHẬT: Đổi tên thành UpdateAllDisplays
        private void UpdateAllDisplays()
        {
            // 1. Cập nhật Label Giờ Chơi
            TimeSpan time = TimeSpan.FromSeconds(CurrentTimeSeconds);
            lblGioChoi.Text = string.Format("{0:D2}:{1:D2}:{2:D2}",
                                            (int)time.TotalHours,
                                            time.Minutes,
                                            time.Seconds);

            // 2. Cập nhật Label Tiền Nạp
            lblSoTienNap.Text = CurrentMoneyBalance.ToString("N0") + " VND";
        }

        // THAY ĐỔI: Hàm này (UpdateUserInfoDisplay) giờ chỉ gọi UpdateAllDisplays
        // Nó được gọi khi quay lại từ formPack
        private void UpdateUserInfoDisplay()
        {
            UpdateAllDisplays();

            // Khởi động timer nếu có giờ và nó chưa chạy
            if (CurrentTimeSeconds > 0 && !gameTimer.Enabled)
            {
                gameTimer.Start();
            }
        }

        // CẬP NHẬT: Hàm static để thêm giờ và tiền
        public static void AddPurchase(decimal amount, decimal hours)
        {
            double secondsPurchased = (double)(hours * 3600);

            // 1. Cộng vào tổng số đã từng nạp (để tính tỷ giá)
            TotalMoneyEverDeposited += amount;
            TotalSecondsEverPurchased += secondsPurchased;

            // 2. Cộng vào số dư hiện tại (để đếm ngược)
            CurrentMoneyBalance += amount;
            CurrentTimeSeconds += secondsPurchased;

            // 3. Cập nhật lại tỷ giá trung bình
            if (TotalSecondsEverPurchased > 0)
            {
                // Tính tỷ giá mới
                CostPerSecond = TotalMoneyEverDeposited / (decimal)TotalSecondsEverPurchased;
            }
        }


        private void mónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formFood form = new formFood();
            form.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gameTimer != null)
            {
                gameTimer.Stop();
                gameTimer.Dispose();
            }
            
            this.Hide();
            formMain form = new formMain();
            form.ShowDialog();

        }

        private void góiGiờChơiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPack form = new formPack();
            form.ShowDialog();

            // Cập nhật và hiển thị lại, timer sẽ tự khởi động nếu cần
            UpdateUserInfoDisplay();
            this.Show();
        }

        private void lịchSửMuaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            formLichSuMua frm = new formLichSuMua(currentUsername);
            frm.ShowDialog();
        }

        private void cấuHìnhMáyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPCprop form = new formPCprop();
            form.ShowDialog();
        }

        private void formUser_Load(object sender, EventArgs e)
        {
            lblTenNguoiDung.Text = currentUsername;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void đồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDrink form = new formDrink();
            form.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tạo instance của formChangePassUser
            // và truyền tên đăng nhập hiện tại (_currentUsername) vào
            formChangePassUser fChangePass = new formChangePassUser(this.currentUsername);

            // Hiển thị form
            fChangePass.ShowDialog();
        }

        private void inHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPrinter form = new formPrinter();
            form.Show();

        }
    }
}