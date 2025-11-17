namespace Quan_Li_Tiem_Net.Admin
{
    partial class FormThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTieuDeLineChart = new System.Windows.Forms.Label();
            this.pnlLineChart = new System.Windows.Forms.Panel();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGiaoDich = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlPieChart = new System.Windows.Forms.Panel();
            this.lblTieuDePieChart = new System.Windows.Forms.Label();
            this.pnlCharts = new System.Windows.Forms.Panel();
            this.btnXemThongKe = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblLocTheoThoiGian = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlLineChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGiaoDich)).BeginInit();
            this.pnlPieChart.SuspendLayout();
            this.pnlCharts.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDeLineChart
            // 
            this.lblTieuDeLineChart.BackColor = System.Drawing.SystemColors.Control;
            this.lblTieuDeLineChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDeLineChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeLineChart.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDeLineChart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDeLineChart.Name = "lblTieuDeLineChart";
            this.lblTieuDeLineChart.Size = new System.Drawing.Size(748, 60);
            this.lblTieuDeLineChart.TabIndex = 0;
            this.lblTieuDeLineChart.Text = "BIỂU ĐỒ DOANH THU THEO THỜI GIAN";
            this.lblTieuDeLineChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLineChart
            // 
            this.pnlLineChart.BackColor = System.Drawing.Color.White;
            this.pnlLineChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLineChart.Controls.Add(this.chartDoanhThu);
            this.pnlLineChart.Controls.Add(this.lblTieuDeLineChart);
            this.pnlLineChart.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLineChart.Location = new System.Drawing.Point(0, 0);
            this.pnlLineChart.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLineChart.Name = "pnlLineChart";
            this.pnlLineChart.Size = new System.Drawing.Size(750, 676);
            this.pnlLineChart.TabIndex = 0;
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            this.chartDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(0, 60);
            this.chartDoanhThu.Margin = new System.Windows.Forms.Padding(4);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "DoanhThu";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(748, 614);
            this.chartDoanhThu.TabIndex = 1;
            this.chartDoanhThu.Text = "chart1";
            // 
            // chartGiaoDich
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGiaoDich.ChartAreas.Add(chartArea2);
            this.chartGiaoDich.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartGiaoDich.Legends.Add(legend2);
            this.chartGiaoDich.Location = new System.Drawing.Point(0, 60);
            this.chartGiaoDich.Margin = new System.Windows.Forms.Padding(4);
            this.chartGiaoDich.Name = "chartGiaoDich";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "DoAn";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "DoUong";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "GoiChoi";
            this.chartGiaoDich.Series.Add(series2);
            this.chartGiaoDich.Series.Add(series3);
            this.chartGiaoDich.Series.Add(series4);
            this.chartGiaoDich.Size = new System.Drawing.Size(1021, 614);
            this.chartGiaoDich.TabIndex = 1;
            this.chartGiaoDich.Text = "chart1";
            // 
            // pnlPieChart
            // 
            this.pnlPieChart.BackColor = System.Drawing.Color.White;
            this.pnlPieChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPieChart.Controls.Add(this.chartGiaoDich);
            this.pnlPieChart.Controls.Add(this.lblTieuDePieChart);
            this.pnlPieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPieChart.Location = new System.Drawing.Point(750, 0);
            this.pnlPieChart.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPieChart.Name = "pnlPieChart";
            this.pnlPieChart.Size = new System.Drawing.Size(1023, 676);
            this.pnlPieChart.TabIndex = 1;
            // 
            // lblTieuDePieChart
            // 
            this.lblTieuDePieChart.BackColor = System.Drawing.SystemColors.Control;
            this.lblTieuDePieChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDePieChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDePieChart.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDePieChart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDePieChart.Name = "lblTieuDePieChart";
            this.lblTieuDePieChart.Size = new System.Drawing.Size(1021, 60);
            this.lblTieuDePieChart.TabIndex = 0;
            this.lblTieuDePieChart.Text = "THỐNG KÊ SỐ LƯỢNG GIAO DỊCH";
            this.lblTieuDePieChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCharts
            // 
            this.pnlCharts.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCharts.Controls.Add(this.pnlPieChart);
            this.pnlCharts.Controls.Add(this.pnlLineChart);
            this.pnlCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCharts.Location = new System.Drawing.Point(0, 180);
            this.pnlCharts.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCharts.Name = "pnlCharts";
            this.pnlCharts.Size = new System.Drawing.Size(1773, 676);
            this.pnlCharts.TabIndex = 5;
            // 
            // btnXemThongKe
            // 
            this.btnXemThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemThongKe.Location = new System.Drawing.Point(1050, 30);
            this.btnXemThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemThongKe.Name = "btnXemThongKe";
            this.btnXemThongKe.Size = new System.Drawing.Size(202, 42);
            this.btnXemThongKe.TabIndex = 3;
            this.btnXemThongKe.Text = "XEM THỐNG KÊ";
            this.btnXemThongKe.UseVisualStyleBackColor = true;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(775, 38);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(230, 30);
            this.dtpDenNgay.TabIndex = 2;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(400, 38);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(230, 30);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.Location = new System.Drawing.Point(660, 42);
            this.lblDenNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(111, 25);
            this.lblDenNgay.TabIndex = 0;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuNgay.Location = new System.Drawing.Point(295, 42);
            this.lblTuNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(98, 25);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // lblLocTheoThoiGian
            // 
            this.lblLocTheoThoiGian.AutoSize = true;
            this.lblLocTheoThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocTheoThoiGian.Location = new System.Drawing.Point(20, 40);
            this.lblLocTheoThoiGian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocTheoThoiGian.Name = "lblLocTheoThoiGian";
            this.lblLocTheoThoiGian.Size = new System.Drawing.Size(227, 29);
            this.lblLocTheoThoiGian.TabIndex = 0;
            this.lblLocTheoThoiGian.Text = "Lọc theo thời gian:";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.btnXemThongKe);
            this.pnlFilter.Controls.Add(this.dtpDenNgay);
            this.pnlFilter.Controls.Add(this.dtpTuNgay);
            this.pnlFilter.Controls.Add(this.lblDenNgay);
            this.pnlFilter.Controls.Add(this.lblTuNgay);
            this.pnlFilter.Controls.Add(this.lblLocTheoThoiGian);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 80);
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1773, 100);
            this.pnlFilter.TabIndex = 4;
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayVe.Location = new System.Drawing.Point(1313, 18);
            this.btnQuayVe.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(150, 42);
            this.btnQuayVe.TabIndex = 0;
            this.btnQuayVe.Text = "QUAY VỀ";
            this.btnQuayVe.UseVisualStyleBackColor = true;
            this.btnQuayVe.Click += new System.EventHandler(this.btnQuayVe_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(550, 20);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(426, 39);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "THỐNG KÊ DOANH THU";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTop.Controls.Add(this.btnQuayVe);
            this.pnlTop.Controls.Add(this.lblTieuDe);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1773, 80);
            this.pnlTop.TabIndex = 3;
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1773, 856);
            this.Controls.Add(this.pnlCharts);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlTop);
            this.Name = "FormThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongKe";
            this.pnlLineChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGiaoDich)).EndInit();
            this.pnlPieChart.ResumeLayout(false);
            this.pnlCharts.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDeLineChart;
        private System.Windows.Forms.Panel pnlLineChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGiaoDich;
        private System.Windows.Forms.Panel pnlPieChart;
        private System.Windows.Forms.Label lblTieuDePieChart;
        private System.Windows.Forms.Panel pnlCharts;
        private System.Windows.Forms.Button btnXemThongKe;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblLocTheoThoiGian;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel pnlTop;
    }
}