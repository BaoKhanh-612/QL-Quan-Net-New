using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace Quan_Li_Tiem_Net
{
    public partial class formPCprop : Form
    {
        public formPCprop()
        {
            InitializeComponent();
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            formUser form = new formUser();
            form.ShowDialog();
        }

        private void formPCprop_Load(object sender, EventArgs e)
        {
            // Gán tên máy
            lblTenMay.Text = System.Environment.MachineName;

            // Lấy thông tin CPU 
            string tenCPU = LayTenCPU();
            lblCPUInfo.Text = tenCPU;  

            // Lấy thông tin GPU 
            string tenGPU = LayTenGPU();
            lblGPUInfo.Text = tenGPU; 

            // Lấy thông tin RAM
            string tongRAM = LayTongRAM();
            lblRAMInfo.Text = tongRAM; 

        }

        // Hàm trợ giúp để lấy tên CPU
        public string LayTenCPU()
        {
            string cpuInfo = string.Empty;
            try
            {
                ManagementClass mc = new ManagementClass("win32_processor");
                ManagementObjectCollection moc = mc.GetInstances();

                foreach (ManagementObject mo in moc)
                {
                    if (cpuInfo == "")
                    {
                        // Lấy thuộc tính "Name" của CPU
                        cpuInfo = mo.Properties["Name"].Value.ToString();
                    }
                }
            }
            catch (Exception)
            {
                cpuInfo = "Không thể lấy thông tin CPU";
                // Ghi lại lỗi nếu cần
                // MessageBox.Show(ex.Message);
            }
            return cpuInfo;
        }

        // Hàm lấy tên Card đồ họa (GPU)
        public string LayTenGPU()
        {
            string gpuInfo = string.Empty;
            try
            {
                // Lớp WMI cho card màn hình
                ManagementClass mc = new ManagementClass("Win32_VideoController");
                ManagementObjectCollection moc = mc.GetInstances();

                foreach (ManagementObject mo in moc)
                {
                    string gpuName = mo.Properties["Name"].Value?.ToString();

                    if (!string.IsNullOrEmpty(gpuName))
                    {
                        // Nếu đã có thông tin GPU trước đó, thêm dấu phân cách
                        if (!string.IsNullOrEmpty(gpuInfo))
                        {
                            gpuInfo += " | ";
                        }
                        gpuInfo += gpuName;
                    }
                }
            }
            catch (Exception )
            {
                gpuInfo = "Không thể lấy thông tin GPU";
                // Bạn có thể ghi log lỗi ở đây nếu cần
                // System.Diagnostics.Debug.WriteLine(ex.Message);
            }

            // Trả về "N/A" nếu không tìm thấy thông tin
            return string.IsNullOrEmpty(gpuInfo) ? "N/A" : gpuInfo;
        }

        // Hàm lấy tổng dung lượng RAM
        public string LayTongRAM()
        {
            string ramInfo = "N/A";
            try
            {
                // Lớp WMI cho thông tin hệ thống chung
                ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    // TotalPhysicalMemory trả về giá trị bằng Bytes
                    object memObj = mo["TotalPhysicalMemory"];
                    if (memObj != null)
                    {
                        double ramBytes = Convert.ToDouble(memObj);
                        // Chuyển đổi Bytes sang Gigabytes (GB)
                        double ramGB = ramBytes / (1024 * 1024 * 1024);

                        // Làm tròn đến 2 chữ số thập phân và thêm " GB"
                        ramInfo = $"{Math.Round(ramGB, 2)} GB";

                        // Chỉ có một đối tượng ComputerSystem nên ta break luôn
                        break;
                    }
                }
            }
            catch (Exception )
            {
                ramInfo = "Không thể lấy thông tin RAM";
                // Bạn có thể ghi log lỗi ở đây nếu cần
                // System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return ramInfo;
        }
    }
}
