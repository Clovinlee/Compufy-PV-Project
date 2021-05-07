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
    public partial class lblOpsi : Form
    {
        public lblOpsi()
        {
            InitializeComponent();
        }

        public login frm_login;

        private void admin_sales_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(727, 508);
            cbFilter.SelectedIndex = 0;
            cbOpsi.SelectedIndex = 0;
            radPendapatan.Checked = true;
            chartSalary.Series["JumlahTrans"].IsVisibleInLegend = false;
            chartSalary.Series["BarangLaku"].IsVisibleInLegend = false;
            chartSalary.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chartSalary.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = true;
            LoadCBHarian();
            LoadPieChart();
        }

        private void LoadPieChart()
        {
            chartPie.Series["Series1"].Points.AddXY("Desktop", 500000);
            chartPie.Series["Series1"].Points.AddXY("Smartphone", 250000);
            chartPie.Series["Series1"].Points.AddXY("Laptop", 750000);
            chartPie.Series["Series1"].Points.AddXY("Accesories", 150000);
        }

        private void LoadCBHarian()
        {
            DataSet ds = new DataSet();
            string query = $"SELECT distinct Convert(varchar, tgl_trans, 106), tgl_trans from h_transaksi order by 2 asc";
            frm_login.executeDataSet(ds, query, "Tgl");

            for (int i = 0; i < ds.Tables["Tgl"].Rows.Count; i++)
            {
                cbTanggal.Items.Add(ds.Tables["Tgl"].Rows[i].ItemArray[0]);
            }
        }

        private void LoadHarian()
        {
            DataSet ds = new DataSet();
            string query = $"select tab1.tgl, tab1.total, tab1.trans, tab2.jumlah from (SELECT h.tgl_Trans as tgl, SUM(h.total_trans) as total, count(h.id_trans) as trans from h_transaksi h group by h.tgl_trans) tab1, (SELECT h.tgl_trans as tgl, SUM(d.jumlah_barang) as jumlah from h_transaksi h, d_transaksi d where h.id_trans = d.id_trans group by h.tgl_trans) tab2 where tab1.tgl = tab2.tgl and tab1.tgl = Convert(date, '{cbTanggal.Text}')";
            frm_login.executeDataSet(ds, query, "Harian");

            string pendapatan = Convert.ToInt32(ds.Tables["Harian"].Rows[0].ItemArray[1]).ToString("C", new CultureInfo("id-ID"));

            lblPdpt.Text = "Pendapatan : " + pendapatan;
            lblTrans.Text = "Jumlah Transaksi : " + ds.Tables["Harian"].Rows[0].ItemArray[2].ToString() + " Transaksi";
            lblBrg.Text = "Barang Laku : " + ds.Tables["Harian"].Rows[0].ItemArray[3].ToString() + " Unit";
        }

        private void LoadPendapatan()
        {
            chartSalary.Series["Pendapatan"].Points.Clear();
            chartSalary.Series["Pendapatan"].IsVisibleInLegend = true;
            chartSalary.Series["Pendapatan"].MarkerSize = 15;
            chartSalary.Series["Pendapatan"].MarkerStyle = MarkerStyle.Circle;
            chartSalary.Series["Pendapatan"].BorderWidth = 4;
            
            if (cbFilter.SelectedIndex == 0)
            {
                DataSet ds = new DataSet();
                string query = $"SELECT Convert(varchar, DATENAME(MONTH, DATEADD(MONTH, 0, tgl_trans))), SUM(total_trans) from h_transaksi where year(tgl_trans) = '{cbOpsi.Text}' group by Convert(varchar, DATENAME(MONTH, DATEADD(MONTH, 0, tgl_trans)))";
                frm_login.executeDataSet(ds, query, "Pendapatan");

                for (int i = 0; i < ds.Tables["Pendapatan"].Rows.Count; i++)
                {
                    chartSalary.Series["Pendapatan"].Points.AddXY(ds.Tables["Pendapatan"].Rows[i].ItemArray[0], ds.Tables["Pendapatan"].Rows[i].ItemArray[1]);
                }
            }
            else if (cbFilter.SelectedIndex == 1)
            {
                chartSalary.Series["Pendapatan"].XValueType = ChartValueType.String;

                DataSet ds = new DataSet();
                string query = $"SELECT year(tgl_trans), SUM(total_trans) from h_transaksi group by year(tgl_trans) order by 1 asc";
                frm_login.executeDataSet(ds, query, "Pendapatan");

                for (int i = 0; i < ds.Tables["Pendapatan"].Rows.Count; i++)
                {
                    chartSalary.Series["Pendapatan"].Points.AddXY(ds.Tables["Pendapatan"].Rows[i].ItemArray[0].ToString(), ds.Tables["Pendapatan"].Rows[i].ItemArray[1]);
                }
            }
        }

        private void LoadTrans()
        {
            chartSalary.Series["JumlahTrans"].Points.Clear();
            chartSalary.Series["JumlahTrans"].IsVisibleInLegend = true;
            chartSalary.Series["JumlahTrans"].MarkerSize = 15;
            chartSalary.Series["JumlahTrans"].MarkerStyle = MarkerStyle.Circle;
            chartSalary.Series["JumlahTrans"].BorderWidth = 4;

            if (cbFilter.SelectedIndex == 0)
            {
                DataSet ds = new DataSet();
                string query = $"SELECT Convert(varchar, DATENAME(MONTH, DATEADD(MONTH, 0, tgl_trans))), count(id_trans) from h_transaksi where year(tgl_trans) = {cbOpsi.Text} group by Convert(varchar, DATENAME(MONTH, DATEADD(MONTH, 0, tgl_trans)))";
                frm_login.executeDataSet(ds, query, "Trans");

                for (int i = 0; i < ds.Tables["Trans"].Rows.Count; i++)
                {
                    chartSalary.Series["JumlahTrans"].Points.AddXY(ds.Tables["Trans"].Rows[i].ItemArray[0], ds.Tables["Trans"].Rows[i].ItemArray[1]);
                }
            }
            else if (cbFilter.SelectedIndex == 1)
            {
                DataSet ds = new DataSet();
                string query = $"SELECT year(tgl_trans), Count(id_trans) from h_transaksi group by year(tgl_trans) order by 1 asc";
                frm_login.executeDataSet(ds, query, "Trans");

                for (int i = 0; i < ds.Tables["Trans"].Rows.Count; i++)
                {
                    chartSalary.Series["JumlahTrans"].Points.AddXY(ds.Tables["Trans"].Rows[i].ItemArray[0], ds.Tables["Trans"].Rows[i].ItemArray[1]);
                }
            }
        }

        private void LoadBarang()
        {
            chartSalary.Series["BarangLaku"].Points.Clear();
            chartSalary.Series["BarangLaku"].IsVisibleInLegend = true;
            chartSalary.Series["BarangLaku"].MarkerSize = 15;
            chartSalary.Series["BarangLaku"].MarkerStyle = MarkerStyle.Circle;
            chartSalary.Series["BarangLaku"].BorderWidth = 4;

            if (cbFilter.SelectedIndex == 0)
            {
                DataSet ds = new DataSet();
                string query = $"SELECT CONVERT(varchar, DATENAME(MONTH, DATEADD(MONTH, 0, h.tgl_trans))), sum(d.jumlah_barang) from h_transaksi h, d_transaksi d where h.id_trans = d.id_trans and year(tgl_trans) = {cbOpsi.Text} group by CONVERT(varchar, DATENAME(MONTH, DATEADD(MONTH, 0, h.tgl_trans)))";
                frm_login.executeDataSet(ds, query, "Barang");

                for (int i = 0; i < ds.Tables["Barang"].Rows.Count; i++)
                {
                    chartSalary.Series["BarangLaku"].Points.AddXY(ds.Tables["Barang"].Rows[i].ItemArray[0], ds.Tables["Barang"].Rows[i].ItemArray[1]);
                }
            }
            else if (cbFilter.SelectedIndex == 1)
            {
                DataSet ds = new DataSet();
                string query = $"SELECT year(h.tgl_trans), SUM(d.jumlah_barang) from d_transaksi d, h_transaksi h where h.id_trans = d.id_trans group by year(tgl_trans) order by 1 asc";
                frm_login.executeDataSet(ds, query, "Barang");

                for (int i = 0; i < ds.Tables["Barang"].Rows.Count; i++)
                {
                    chartSalary.Series["BarangLaku"].Points.AddXY(ds.Tables["Barang"].Rows[i].ItemArray[0], ds.Tables["Barang"].Rows[i].ItemArray[1]);
                }
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

        private void cbTanggal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTanggal.SelectedIndex != -1)
            {
                LoadHarian();
            }
        }
    }
}
