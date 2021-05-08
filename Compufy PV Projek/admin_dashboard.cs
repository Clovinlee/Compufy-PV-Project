﻿using System;
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
    public partial class admin_dashboard : Form
    {
        public admin_dashboard()
        {
            InitializeComponent();
        }

        public login frm_login;
        string member_terbaru;
        int baranglow = 99999;
        string namalow;
        string idlow;
        int totaltransaksi = 0;
        int totaldiskon = 0;
        int totalpendapatan = 0;
        int totaltoday = 0;
        int totalyesterday = 0;
        int total2hari = 0;
        int total3hari = 0;
        int total4hari = 0;
        int total5hari = 0;
        int total6hari = 0;
        DateTime yesterday = DateTime.Today.AddDays(-1);

        private void admin_dashboard_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(727, 508);
            loaddashboard();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        /*private void panel5_Paint(object sender, PaintEventArgs e)
        {
            List<int> temp = new List<int> { totaltoday,totalyesterday };
            int max = temp.Max();
            Graphics g = e.Graphics;
            if (totaltoday == 0 && totalyesterday == 0) {
                g.FillRectangle(Brushes.LightBlue, 0, 5, 60 , 75);
                g.FillRectangle(Brushes.LightSalmon, 0, 85, 60, 75);
                label14.Text = "Rp 0";
                label15.Text = "";
                
            }
            else
            {
                if (totaltoday == 0)
                {
                    g.FillRectangle(Brushes.LightBlue, 0, 5, 60, 75);
                    g.FillRectangle(Brushes.LightSalmon, 0, 85, totalyesterday / max * 400, 75);
                    label14.Text = "Rp 0";
                    label15.Text = "Rp " + totalyesterday.ToString("#,##");
                    
                }
                if (totalyesterday == 0)
                {
                    g.FillRectangle(Brushes.LightBlue, 0, 5, totaltoday / max * 400, 75);
                    g.FillRectangle(Brushes.LightSalmon, 0, 85, 60 , 75);
                    label15.Text = "Rp " + totaltoday.ToString("#,##");
                    label14.Text = "Rp 0";
                    
                    
                }
                else
                {
                    g.FillRectangle(Brushes.LightBlue, 0, 5, totaltoday / max * 400, 75);
                    g.FillRectangle(Brushes.LightSalmon, 0, 85, totalyesterday / max * 400, 75);
                    label14.Text = "Rp 0";
                    label15.Text = "Rp " + max.ToString("#,##");
                    
                }
            }
        }*/

        public void loaddashboard()
        {
            DataSet ds = new DataSet();
            string query = "SELECT * from Member";
            frm_login.executeDataSet(ds, query, "Member");

            label1.Text = ds.Tables["Member"].Rows.Count.ToString() + " Member";
            for (int i = 0; i < ds.Tables["Member"].Rows.Count; i++)
            {
                member_terbaru = ds.Tables["Member"].Rows[i].ItemArray[1].ToString();
            }
            label4.Text = member_terbaru;

            ds = new DataSet();
            query = "SELECT nama_barang, stok_barang, id_barang from Barang";
            frm_login.executeDataSet(ds, query, "Barang");
            for (int i = 0; i < ds.Tables["Barang"].Rows.Count; i++)
            {
                if (Convert.ToInt32(ds.Tables["Barang"].Rows[i].ItemArray[1]) <= baranglow)
                {
                    baranglow = Convert.ToInt32(ds.Tables["Barang"].Rows[i].ItemArray[1]);
                    namalow = ds.Tables["Barang"].Rows[i].ItemArray[0].ToString();
                    idlow = ds.Tables["Barang"].Rows[i].ItemArray[2].ToString();
                }
            }
            label6.Text = namalow;
            label8.Text = Convert.ToString(baranglow);
            label28.Text = "ID: " + idlow;

            ds = new DataSet();
            query = "SELECT total_trans, diskon from h_transaksi";
            frm_login.executeDataSet(ds, query, "h_transaksi");
            for (int i = 0; i < ds.Tables["h_transaksi"].Rows.Count; i++)
            {
                totaltransaksi += Convert.ToInt32(ds.Tables["h_transaksi"].Rows[i].ItemArray[0]);
                totaldiskon += Convert.ToInt32(ds.Tables["h_transaksi"].Rows[i].ItemArray[1]);
            }
            totalpendapatan = totaltransaksi - totaldiskon;
            label11.Text = Convert.ToInt32(totaltransaksi).ToString("#,##");
            label21.Text = Convert.ToInt32(totaldiskon).ToString("#,##");
            label25.Text = Convert.ToInt32(totalpendapatan).ToString("#,##");

            /*ds = new DataSet();
            query = $"SELECT h.tgl_trans, SUM(total_trans) from h_transaksi h where FORMAT(h.tgl_trans, 'dd/MM/yyyy ') = FORMAT(DATEADD(day, 0, CAST(GETDATE() AS date)), 'dd/MM/yyyy ') group by h.tgl_trans";
            frm_login.executeDataSet(ds, query, "Sum Hari Ini");
            if (ds.Tables["Sum Hari Ini"] != null)
            {
                try
                {
                    totaltoday = Convert.ToInt32(ds.Tables["Sum Hari Ini"].Rows[0].ItemArray[1]);
                    
                }
                catch
                {

                }
            }


            ds = new DataSet();
            query = $"SELECT h.tgl_trans, SUM(total_trans) from h_transaksi h where FORMAT(h.tgl_trans, 'dd/MM/yyyy ') = FORMAT(DATEADD(day, -1, CAST(GETDATE() AS date)), 'dd/MM/yyyy ') group by h.tgl_trans";
            frm_login.executeDataSet(ds, query, "Sum Kemarin");
            if (ds.Tables["Sum Kemarin"] != null)
            {
                try
                {
                    totalyesterday = Convert.ToInt32(ds.Tables["Sum Kemarin"].Rows[0].ItemArray[1]);
                    
                }
                catch
                {

                }
            }*/
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series1"].MarkerSize = 10;
            
            chart1.Series["Series1"].MarkerStyle = MarkerStyle.Circle;
            chart1.Series["Series1"].BorderWidth = 4;
            
            ds = new DataSet();
            query = $"select d.thedate, isnull(SUM(h.total_trans),0) from (SELECT FORMAT(DATEADD(day, 0, CAST(GETDATE() AS date)), 'dd/MM/yyyy ')  as thedate union all SELECT FORMAT(DATEADD(day, -1, CAST(GETDATE() AS date)), 'dd/MM/yyyy ')  union all SELECT FORMAT(DATEADD(day, -2, CAST(GETDATE() AS date)), 'dd/MM/yyyy ')  union all SELECT FORMAT(DATEADD(day, -3, CAST(GETDATE() AS date)), 'dd/MM/yyyy ')  union all SELECT FORMAT(DATEADD(day, -4, CAST(GETDATE() AS date)), 'dd/MM/yyyy ')  union all SELECT FORMAT(DATEADD(day, -5, CAST(GETDATE() AS date)), 'dd/MM/yyyy ')  union all SELECT FORMAT(DATEADD(day, -6, CAST(GETDATE() AS date)), 'dd/MM/yyyy ') ) d left join h_transaksi h on convert(datetime,h.tgl_trans,103) = d.thedate Group By d.thedate";
            frm_login.executeDataSet(ds, query, "Pendapatan");
            for (int i = 0; i < ds.Tables["Pendapatan"].Rows.Count; i++)
            {
                string pendapatan = Convert.ToInt32(ds.Tables["Pendapatan"].Rows[i].ItemArray[1]).ToString("#,##");

                chart1.Series["Series1"].Points.AddXY(ds.Tables["Pendapatan"].Rows[i].ItemArray[0], pendapatan);
            }
            chart1.Size = new Size(700, 250);
            chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "#,##";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
