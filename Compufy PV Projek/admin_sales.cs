using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

namespace Compufy_PV_Projek
{
    public partial class admin_sales : Form
    {
        public admin_sales()
        {
            InitializeComponent();
        }

        public login frm_login;

        private void admin_sales_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(727, 508);
            cbFilter.SelectedIndex = 0;
            cbOpsi.SelectedIndex = 4;
            radPendapatan.Checked = true;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " ";

            chartSalary.Series["Pendapatan"].IsVisibleInLegend = false;
            chartSalary.Series["JumlahTrans"].IsVisibleInLegend = false;
            chartSalary.Series["BarangLaku"].IsVisibleInLegend = false;
            chartPie.Series["Series1"]["PieLineColor"] = "Blue";

            chartSalary.Series["Pendapatan"].YValueType = ChartValueType.Int32;
            chartSalary.Series["JumlahTrans"].YValueType = ChartValueType.Int32;
            chartSalary.Series["BarangLaku"].YValueType = ChartValueType.Int32;

            chartSalary.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chartSalary.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = true;
            chartSalary.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "#,##";

            chartSalary.ChartAreas["ChartArea1"].AxisY.LabelAutoFitStyle = LabelAutoFitStyles.None;
            chartSalary.ChartAreas["ChartArea1"].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.None;
            chartSalary.ChartAreas["ChartArea1"].AxisY.LabelStyle.Font = new Font("Nirmala UI", 10);
            chartSalary.ChartAreas["ChartArea1"].AxisX.LabelStyle.Font = new Font("Nirmala UI", 10, FontStyle.Bold);

            chartSalary.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
            chartSalary.ChartAreas["ChartArea1"].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            chartSalary.ChartAreas["ChartArea1"].AxisX.ScrollBar.IsPositionedInside = false;
            chartSalary.ChartAreas["ChartArea1"].AxisX.ScaleView.SmallScrollSize = 7;
            chartSalary.ChartAreas["ChartArea1"].AxisX.ScrollBar.Size = 15;
            chartSalary.ChartAreas["ChartArea1"].AxisX.ScrollBar.BackColor = Color.WhiteSmoke;
            chartSalary.ChartAreas["ChartArea1"].AxisX.ScrollBar.ButtonColor = Color.Silver;

            if (this.Width >= 870)
            {
                chartSalary.ChartAreas["ChartArea1"].AxisX.ScaleView.ZoomReset(0);
                chartSalary.ChartAreas["ChartArea1"].AxisX.ScrollBar.Enabled = false;
            }
            else
            {
                chartSalary.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoom(0, 4);
                chartSalary.ChartAreas["ChartArea1"].AxisX.ScrollBar.Enabled = true;
            }

            LoadDummyPie();
        }

        private void LoadDummyPie()
        {
            chartPie.Series["Series1"].Points.Clear();
            chartPie.Series["Series1"].Font = new Font("Nirmala UI", 10, FontStyle.Bold);
            chartPie.Series["Series1"].Points.AddXY("NO DATA", 100);
            chartPie.Series["Series1"].Points[0].IsVisibleInLegend = false;
            chartPie.Series["Series1"]["PieLabelStyle"] = "outside";
            chartPie.ChartAreas[0].Area3DStyle.Enable3D = false;
        }

        private void LoadPieChart()
        {
            chartPie.Series["Series1"].Points.Clear();
            chartPie.Series["Series1"].Font = new Font("Nirmala UI", 8, FontStyle.Bold);
            chartPie.ChartAreas[0].Area3DStyle.Enable3D = true;
            chartPie.ChartAreas[0].Area3DStyle.Inclination = 0;

            int desktop = 0;
            int smartphone = 0;
            int laptop = 0;
            int accesories = 0;
            int total = 0;

            DataSet ds = new DataSet();
            string date = dateTimePicker1.Value.Date.ToString("MM/dd/yyyy");
            string query = $"select b.nama_barang, b.harga_barang * d.jumlah_barang, k.nama_kategori from barang b, d_transaksi d, h_transaksi h, kategori k where d.id_barang = b.id_barang and d.id_trans = h.id_trans and b.id_kategori = k.id_kategori and convert(varchar, h.tgl_trans, 101) = '{date}'";
            frm_login.executeDataSet(ds, query, "Kategori");

            for (int i = 0; i < ds.Tables["Kategori"].Rows.Count; i++)
            {
                total += Convert.ToInt32(ds.Tables["Kategori"].Rows[i].ItemArray[1]);

                if (ds.Tables["Kategori"].Rows[i].ItemArray[2].ToString() == "Desktop")
                {
                    desktop += Convert.ToInt32(ds.Tables["Kategori"].Rows[i].ItemArray[1]);
                }
                else if (ds.Tables["Kategori"].Rows[i].ItemArray[2].ToString() == "Smartphone")
                {
                    smartphone += Convert.ToInt32(ds.Tables["Kategori"].Rows[i].ItemArray[1]);
                }
                else if (ds.Tables["Kategori"].Rows[i].ItemArray[2].ToString() == "Laptop")
                {
                    laptop += Convert.ToInt32(ds.Tables["Kategori"].Rows[i].ItemArray[1]);
                }
                else
                {
                    accesories += Convert.ToInt32(ds.Tables["Kategori"].Rows[i].ItemArray[1]);
                }
            }

            double checkDesktop = Convert.ToDouble(desktop) / Convert.ToDouble(total) * 100;
            double checkSmartphone = Convert.ToDouble(smartphone) / Convert.ToDouble(total) * 100;
            double checkLaptop = Convert.ToDouble(laptop) / Convert.ToDouble(total) * 100;
            double checkAcc = Convert.ToDouble(accesories) / Convert.ToDouble(total) * 100;

            int ctr = 0;

            if (chartPie.Series["Series1"].Points.Count == 1)
            {
                chartPie.Series["Series1"]["PieLabelStyle"] = "outside";
            }
            else
            {
                chartPie.Series["Series1"]["PieLabelStyle"] = "inside";

                if (checkDesktop != 0)
                {
                    chartPie.Series["Series1"].Points.AddXY(checkDesktop.ToString("0.0") + "%", desktop);
                    chartPie.Series["Series1"].Points[ctr].LegendText = "Desktop";
                    
                    if (checkDesktop < 12)
                    {
                        chartPie.Series["Series1"].Points[ctr]["PieLabelStyle"] = "outside";
                    }

                    ctr++;
                }
                if (checkSmartphone != 0)
                {
                    chartPie.Series["Series1"].Points.AddXY(checkSmartphone.ToString("0.0") + "%", smartphone);
                    chartPie.Series["Series1"].Points[ctr].LegendText = "Smartphone";

                    if (checkSmartphone < 12)
                    {
                        chartPie.Series["Series1"].Points[ctr]["PieLabelStyle"] = "outside";
                    }

                    ctr++;
                }
                if (checkLaptop != 0)
                {
                    chartPie.Series["Series1"].Points.AddXY(checkLaptop.ToString("0.0") + "%", laptop);
                    chartPie.Series["Series1"].Points[ctr].LegendText = "Laptop";

                    if (checkLaptop < 12)
                    {
                        chartPie.Series["Series1"].Points[ctr]["PieLabelStyle"] = "outside";
                    }

                    ctr++;
                }
                if (checkAcc != 0)
                {
                    chartPie.Series["Series1"].Points.AddXY(checkAcc.ToString("0.0") + "%", accesories);
                    chartPie.Series["Series1"].Points[ctr].LegendText = "Accesories";

                    if (checkAcc < 12)
                    {
                        chartPie.Series["Series1"].Points[ctr]["PieLabelStyle"] = "outside";
                    }

                    ctr++;
                }
            }       
        }

        int pendHarian;

        private void LoadHarian()
        {
            DataSet ds = new DataSet();
            string date = dateTimePicker1.Value.Date.ToString("MM/dd/yyyy");
            string query = $"select tab1.tgl, tab1.total, tab1.trans, tab2.jumlah from (SELECT h.tgl_Trans as tgl, SUM(h.total_trans) as total, count(h.id_trans) as trans from h_transaksi h group by h.tgl_trans) tab1, (SELECT h.tgl_trans as tgl, SUM(d.jumlah_barang) as jumlah from h_transaksi h, d_transaksi d where h.id_trans = d.id_trans group by h.tgl_trans) tab2 where tab1.tgl = tab2.tgl and convert(varchar, tab1.tgl, 101) = '{date}'";
            frm_login.executeDataSet(ds, query, "Harian");

            if (ds.Tables["Harian"].Rows.Count == 0)
            {
                lblPdpt.Text = "Rp0";
                lblTrans.Text = "0 Transaksi";
                lblBrg.Text = "0 Unit";
                LoadDummyPie();
            }
            else
            {
                pendHarian = Convert.ToInt32(ds.Tables["Harian"].Rows[0].ItemArray[1]);
                string pendapatan = Convert.ToInt32(ds.Tables["Harian"].Rows[0].ItemArray[1]).ToString("C", new CultureInfo("id-ID"));

                lblPdpt.Text = pendapatan;
                lblTrans.Text = ds.Tables["Harian"].Rows[0].ItemArray[2].ToString() + " Transaksi";
                lblBrg.Text = ds.Tables["Harian"].Rows[0].ItemArray[3].ToString() + " Unit";
                LoadPieChart();
            }
        }

        private void LoadPendapatan()
        {
            chartSalary.Series["Pendapatan"].Points.Clear();

            chartSalary.Series["Pendapatan"].MarkerSize = 15;
            chartSalary.Series["Pendapatan"].MarkerStyle = MarkerStyle.Circle;
            chartSalary.Series["Pendapatan"].MarkerColor = Color.Black;
            chartSalary.Series["Pendapatan"].BorderWidth = 5;
            chartSalary.ChartAreas["ChartArea1"].AxisX.LineWidth = 0;

            if (cbFilter.SelectedIndex == 0)
            {
                DataSet ds = new DataSet();
                string query = $"SELECT substring(tab1.bulan, 0, 4), isnull(tab2.total, 0) from (SELECT DATENAME(MONTH, DATEADD(MM, s.number, CONVERT(DATETIME, 0))) AS bulan FROM master.dbo.spt_values s WHERE[type] = 'P' AND s.number BETWEEN 0 AND 11) tab1 left join (SELECT Convert(varchar, DATENAME(MONTH, DATEADD(MONTH, 0, tgl_trans))) as bulan, SUM(total_trans) as total from h_transaksi where year(tgl_trans) = {cbOpsi.Text} group by Convert(varchar, DATENAME(MONTH, DATEADD(MONTH, 0, tgl_trans)))) tab2 on tab1.bulan = tab2.bulan";
                frm_login.executeDataSet(ds, query, "Pendapatan");

                chartSalary.ChartAreas["ChartArea1"].AxisX.Interval = 1;

                for (int i = 0; i < ds.Tables["Pendapatan"].Rows.Count; i++)
                {
                    string pendapatan = Convert.ToInt32(ds.Tables["Pendapatan"].Rows[i].ItemArray[1]).ToString("#,##");

                    chartSalary.Series["Pendapatan"].Points.AddXY(ds.Tables["Pendapatan"].Rows[i].ItemArray[0], pendapatan);
                }

                chartSalary.Titles["Title"].Text = $"Data Pendapatan {cbFilter.Text} tahun {cbOpsi.Text}";
            }
            else if (cbFilter.SelectedIndex == 1)
            {
                DataSet ds = new DataSet();
                string query = $"SELECT year(tgl_trans), SUM(total_trans) from h_transaksi group by year(tgl_trans) order by 1 asc";
                frm_login.executeDataSet(ds, query, "Pendapatan");

                for (int i = 0; i < ds.Tables["Pendapatan"].Rows.Count; i++)
                {
                    string pendapatan = Convert.ToInt32(ds.Tables["Pendapatan"].Rows[i].ItemArray[1]).ToString("#,##");

                    chartSalary.Series["Pendapatan"].Points.AddXY(ds.Tables["Pendapatan"].Rows[i].ItemArray[0].ToString(), pendapatan);
                }

                chartSalary.Titles["Title"].Text = $"Data Pendapatan {cbFilter.Text}";
            }
        }

        private void LoadTrans()
        {
            chartSalary.Series["JumlahTrans"].Points.Clear();
            chartSalary.Series["JumlahTrans"].MarkerSize = 15;
            chartSalary.Series["JumlahTrans"].MarkerStyle = MarkerStyle.Circle;
            chartSalary.Series["JumlahTrans"].MarkerColor = Color.Black;
            chartSalary.Series["JumlahTrans"].BorderWidth = 5;

            if (cbFilter.SelectedIndex == 0)
            {
                DataSet ds = new DataSet();
                string query = $"select substring(tab1.bulan, 0, 4), isnull(tab2.trans, 0) from (SELECT DATENAME(MONTH, DATEADD(MM, s.number, CONVERT(DATETIME, 0))) AS bulan FROM master.dbo.spt_values s WHERE[type] = 'P' AND s.number BETWEEN 0 AND 11) tab1 left join(SELECT Convert(varchar, DATENAME(MONTH, DATEADD(MONTH, 0, tgl_trans))) as bulan, count(id_trans) as trans from h_transaksi where year(tgl_trans) = {cbOpsi.Text} group by Convert(varchar, DATENAME(MONTH, DATEADD(MONTH, 0, tgl_trans)))) tab2 on tab1.bulan = tab2.bulan";
                frm_login.executeDataSet(ds, query, "Trans");

                for (int i = 0; i < ds.Tables["Trans"].Rows.Count; i++)
                {
                    chartSalary.Series["JumlahTrans"].Points.AddXY(ds.Tables["Trans"].Rows[i].ItemArray[0], ds.Tables["Trans"].Rows[i].ItemArray[1]);
                }

                chartSalary.Titles["Title"].Text = $"Data Jumlah Transaksi {cbFilter.Text} tahun {cbOpsi.Text}";
            }
            else if (cbFilter.SelectedIndex == 1)
            {
                DataSet ds = new DataSet();
                string query = $"SELECT year(tgl_trans), Count(id_trans) from h_transaksi group by year(tgl_trans) order by 1 asc";
                frm_login.executeDataSet(ds, query, "Trans");

                for (int i = 0; i < ds.Tables["Trans"].Rows.Count; i++)
                {
                    chartSalary.Series["JumlahTrans"].Points.AddXY(ds.Tables["Trans"].Rows[i].ItemArray[0].ToString(), ds.Tables["Trans"].Rows[i].ItemArray[1]);
                }

                chartSalary.Titles["Title"].Text = $"Data Jumlah Transaksi {cbFilter.Text}";
            }
        }

        private void LoadBarang()
        {
            chartSalary.Series["BarangLaku"].Points.Clear();
            chartSalary.Series["BarangLaku"].MarkerSize = 15;
            chartSalary.Series["BarangLaku"].MarkerColor = Color.Black;
            chartSalary.Series["BarangLaku"].MarkerStyle = MarkerStyle.Circle;
            chartSalary.Series["BarangLaku"].BorderWidth = 5;

            if (cbFilter.SelectedIndex == 0)
            {
                DataSet ds = new DataSet();
                string query = $"select substring(tab1.bulan, 0, 4), isnull(tab2.barang, 0) from (SELECT DATENAME(MONTH, DATEADD(MM, s.number, CONVERT(DATETIME, 0))) AS bulan FROM master.dbo.spt_values s WHERE[type] = 'P' AND s.number BETWEEN 0 AND 11) tab1 left join (SELECT CONVERT(varchar, DATENAME(MONTH, DATEADD(MONTH, 0, h.tgl_trans))) as bulan, sum(d.jumlah_barang) as barang from h_transaksi h, d_transaksi d where h.id_trans = d.id_trans and year(tgl_trans) = {cbOpsi.Text} group by CONVERT(varchar, DATENAME(MONTH, DATEADD(MONTH, 0, h.tgl_trans)))) tab2 on tab1.bulan = tab2.bulan";
                frm_login.executeDataSet(ds, query, "Barang");

                for (int i = 0; i < ds.Tables["Barang"].Rows.Count; i++)
                {
                    chartSalary.Series["BarangLaku"].Points.AddXY(ds.Tables["Barang"].Rows[i].ItemArray[0], ds.Tables["Barang"].Rows[i].ItemArray[1]);
                }

                chartSalary.Titles["Title"].Text = $"Data Barang Terjual {cbFilter.Text} tahun {cbOpsi.Text}";
            }
            else if (cbFilter.SelectedIndex == 1)
            {
                DataSet ds = new DataSet();
                string query = $"SELECT year(h.tgl_trans), SUM(d.jumlah_barang) from d_transaksi d, h_transaksi h where h.id_trans = d.id_trans group by year(tgl_trans) order by 1 asc";
                frm_login.executeDataSet(ds, query, "Barang");

                for (int i = 0; i < ds.Tables["Barang"].Rows.Count; i++)
                {
                    chartSalary.Series["BarangLaku"].Points.AddXY(ds.Tables["Barang"].Rows[i].ItemArray[0].ToString(), ds.Tables["Barang"].Rows[i].ItemArray[1]);
                }

                chartSalary.Titles["Title"].Text = $"Data Barang Terjual {cbFilter.Text}";
            }
        }

        private void LoadCB()
        {
            cbOpsi.Items.Clear();

            if (cbFilter.SelectedIndex == 0)
            {
                cbOpsi.Enabled = true;
                DataSet ds = new DataSet();
                string query = "SELECT distinct YEAR(tgl_trans) from h_transaksi order by 1 asc";
                frm_login.executeDataSet(ds, query, "Tahun");

                for (int i = 0; i < ds.Tables["Tahun"].Rows.Count; i++)
                {
                    cbOpsi.Items.Add(ds.Tables["Tahun"].Rows[i].ItemArray[0]);
                }

                cbOpsi.SelectedIndex = 0;
            }
            else if (cbFilter.SelectedIndex == 1)
            {
                cbOpsi.Text = "";
                cbOpsi.Enabled = false;
            }           
        }

        private void cbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCB();

            if (CheckStatus(radPendapatan) == true)
            {
                LoadPendapatan();
            }
            if (CheckStatus(radTrans) == true)
            {
                LoadTrans();
            }
            if (CheckStatus(radBarang) == true)
            {
                LoadBarang();
            }

            if (this.Width >= 870)
            {
                chartSalary.ChartAreas["ChartArea1"].AxisX.ScaleView.ZoomReset(0);
                chartSalary.ChartAreas["ChartArea1"].AxisX.ScrollBar.Enabled = false;
            }
            else
            {
                chartSalary.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoom(0, 4);
                chartSalary.ChartAreas["ChartArea1"].AxisX.ScrollBar.Enabled = true;
            }
        }

        private void cbOpsi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckStatus(radPendapatan) == true)
            {
                LoadPendapatan();
            }
            if (CheckStatus(radTrans) == true)
            {
                LoadTrans();
            }
            if (CheckStatus(radBarang) == true)
            {
                LoadBarang();
            }
        }

        private bool CheckStatus(RadioButton rad)
        {
            if (cbFilter.SelectedIndex == 0 && cbOpsi.SelectedIndex != -1 && rad.Checked)
            {
                return true;
            }
            else if (cbFilter.SelectedIndex == 1 && rad.Checked)
            {
                return true;
            }
            return false;
        }

        private void radPendapatan_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckStatus(radPendapatan) == true)
            {
                LoadPendapatan();
            }
            else
            {
                chartSalary.Series["Pendapatan"].Points.Clear();
                chartSalary.Series["Pendapatan"].IsVisibleInLegend = false;
            }
        }

        private void radTrans_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckStatus(radTrans) == true)
            {
                LoadTrans();
            }
            else
            {
                chartSalary.Series["JumlahTrans"].Points.Clear();
                chartSalary.Series["JumlahTrans"].IsVisibleInLegend = false;
            }
        }

        private void radBarang_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckStatus(radBarang) == true)
            {
                LoadBarang();
            }
            else
            {
                chartSalary.Series["BarangLaku"].Points.Clear();
                chartSalary.Series["BarangLaku"].IsVisibleInLegend = false;
            }
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Long;
            LoadHarian();
        }

        private void admin_sales_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width >= 870)
            {
                chartSalary.ChartAreas["ChartArea1"].AxisX.ScaleView.ZoomReset(0);
                chartSalary.ChartAreas["ChartArea1"].AxisX.ScrollBar.Enabled = false;
            }
            else
            {
                chartSalary.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoom(0, 4);
                chartSalary.ChartAreas["ChartArea1"].AxisX.ScrollBar.Enabled = true;
            }
        }

        private void chartSalary_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                DataPoint dataPoint = (DataPoint)e.HitTestResult.Object;

                if (radPendapatan.Checked)
                {
                    e.Text = "Rp " + dataPoint.YValues[0].ToString("#,##");
                }
                else if (radTrans.Checked)
                {
                    e.Text = dataPoint.YValues[0].ToString() + " Transaksi";
                }
                else if (radBarang.Checked)
                {
                    e.Text = dataPoint.YValues[0].ToString() + " Unit";
                }
            }
        }
    }
}
