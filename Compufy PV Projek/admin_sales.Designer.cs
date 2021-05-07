namespace Compufy_PV_Projek
{
    partial class lblOpsi
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSalary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbOpsi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPdpt = new System.Windows.Forms.Label();
            this.lblTrans = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBrg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.radPendapatan = new System.Windows.Forms.RadioButton();
            this.radTrans = new System.Windows.Forms.RadioButton();
            this.radBarang = new System.Windows.Forms.RadioButton();
            this.cbTanggal = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalary)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSalary
            // 
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartSalary.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chartSalary.Legends.Add(legend1);
            this.chartSalary.Location = new System.Drawing.Point(25, 119);
            this.chartSalary.Name = "chartSalary";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.Name = "Pendapatan";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "JumlahTrans";
            series2.YValuesPerPoint = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "BarangLaku";
            series3.YValuesPerPoint = 2;
            this.chartSalary.Series.Add(series1);
            this.chartSalary.Series.Add(series2);
            this.chartSalary.Series.Add(series3);
            this.chartSalary.Size = new System.Drawing.Size(378, 367);
            this.chartSalary.TabIndex = 0;
            this.chartSalary.Text = "Pilih Tanggal";
            title1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title";
            title1.Text = "Data Penjualan";
            this.chartSalary.Titles.Add(title1);
            // 
            // cbOpsi
            // 
            this.cbOpsi.AutoCompleteCustomSource.AddRange(new string[] {
            "Jan"});
            this.cbOpsi.FormattingEnabled = true;
            this.cbOpsi.Location = new System.Drawing.Point(65, 48);
            this.cbOpsi.Name = "cbOpsi";
            this.cbOpsi.Size = new System.Drawing.Size(150, 28);
            this.cbOpsi.TabIndex = 1;
            this.cbOpsi.SelectedIndexChanged += new System.EventHandler(this.cbOpsi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipe";
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Bulanan",
            "Tahunan"});
            this.cbFilter.Location = new System.Drawing.Point(65, 14);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(150, 28);
            this.cbFilter.TabIndex = 3;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbJenis_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Opsi";
            // 
            // lblPdpt
            // 
            this.lblPdpt.AutoSize = true;
            this.lblPdpt.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPdpt.Location = new System.Drawing.Point(21, 142);
            this.lblPdpt.Name = "lblPdpt";
            this.lblPdpt.Size = new System.Drawing.Size(94, 20);
            this.lblPdpt.TabIndex = 8;
            this.lblPdpt.Text = "Pendapatan :";
            // 
            // lblTrans
            // 
            this.lblTrans.AutoSize = true;
            this.lblTrans.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrans.Location = new System.Drawing.Point(21, 171);
            this.lblTrans.Name = "lblTrans";
            this.lblTrans.Size = new System.Drawing.Size(125, 20);
            this.lblTrans.TabIndex = 10;
            this.lblTrans.Text = "Jumlah Transaksi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pilih Tanggal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrg
            // 
            this.lblBrg.AutoSize = true;
            this.lblBrg.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrg.Location = new System.Drawing.Point(22, 202);
            this.lblBrg.Name = "lblBrg";
            this.lblBrg.Size = new System.Drawing.Size(97, 20);
            this.lblBrg.TabIndex = 11;
            this.lblBrg.Text = "Barang Laku :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.cbTanggal);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblBrg);
            this.panel1.Controls.Add(this.lblPdpt);
            this.panel1.Controls.Add(this.lblTrans);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(416, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 469);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Statistik Harian ";
            // 
            // radPendapatan
            // 
            this.radPendapatan.AutoSize = true;
            this.radPendapatan.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPendapatan.Location = new System.Drawing.Point(238, 12);
            this.radPendapatan.Name = "radPendapatan";
            this.radPendapatan.Size = new System.Drawing.Size(105, 24);
            this.radPendapatan.TabIndex = 13;
            this.radPendapatan.TabStop = true;
            this.radPendapatan.Text = "Pendapatan";
            this.radPendapatan.UseVisualStyleBackColor = true;
            this.radPendapatan.CheckedChanged += new System.EventHandler(this.radPendapatan_CheckedChanged);
            // 
            // radTrans
            // 
            this.radTrans.AutoSize = true;
            this.radTrans.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTrans.Location = new System.Drawing.Point(238, 43);
            this.radTrans.Name = "radTrans";
            this.radTrans.Size = new System.Drawing.Size(136, 24);
            this.radTrans.TabIndex = 14;
            this.radTrans.TabStop = true;
            this.radTrans.Text = "Jumlah Transaksi";
            this.radTrans.UseVisualStyleBackColor = true;
            this.radTrans.CheckedChanged += new System.EventHandler(this.radTrans_CheckedChanged);
            // 
            // radBarang
            // 
            this.radBarang.AutoSize = true;
            this.radBarang.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBarang.Location = new System.Drawing.Point(238, 72);
            this.radBarang.Name = "radBarang";
            this.radBarang.Size = new System.Drawing.Size(108, 24);
            this.radBarang.TabIndex = 15;
            this.radBarang.TabStop = true;
            this.radBarang.Text = "Barang Laku";
            this.radBarang.UseVisualStyleBackColor = true;
            this.radBarang.CheckedChanged += new System.EventHandler(this.radBarang_CheckedChanged);
            // 
            // cbTanggal
            // 
            this.cbTanggal.FormattingEnabled = true;
            this.cbTanggal.Location = new System.Drawing.Point(121, 80);
            this.cbTanggal.Name = "cbTanggal";
            this.cbTanggal.Size = new System.Drawing.Size(138, 28);
            this.cbTanggal.TabIndex = 13;
            this.cbTanggal.SelectedIndexChanged += new System.EventHandler(this.cbTanggal_SelectedIndexChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(26, 244);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(250, 179);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // lblOpsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(720, 498);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.radBarang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartSalary);
            this.Controls.Add(this.cbOpsi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radTrans);
            this.Controls.Add(this.radPendapatan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "lblOpsi";
            this.Text = "Pilih Tanggal";
            this.Load += new System.EventHandler(this.admin_sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSalary)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalary;
        private System.Windows.Forms.ComboBox cbOpsi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPdpt;
        private System.Windows.Forms.Label lblTrans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBrg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radPendapatan;
        private System.Windows.Forms.RadioButton radTrans;
        private System.Windows.Forms.RadioButton radBarang;
        private System.Windows.Forms.ComboBox cbTanggal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}