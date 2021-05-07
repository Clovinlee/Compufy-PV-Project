using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        int totaltransaksi = 0;
        int totaldiskon = 0;
        int totalpendapatan = 0;
        int totaltoday = 0;
        int totalyesterday = 0;
        DateTime yesterday = DateTime.Today.AddDays(-1);

        private void admin_dashboard_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(727, 508);
            loaddashboard();




        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void chartSalary_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            List<int> temp = new List<int> { totaltoday,totalyesterday };
            int max = temp.Max();
            Graphics g = e.Graphics;
            if (totaltoday == totalyesterday) {
                g.FillRectangle(Brushes.DarkBlue, 0, 5, 60 , 75);
                g.FillRectangle(Brushes.Gray, 0, 85, 60, 75);
                label15.Text = "";
            }
            else
            {
                g.FillRectangle(Brushes.DarkBlue, 0, 5, totaltoday / max * 400, 75);
                g.FillRectangle(Brushes.Gray, 0, 85, totalyesterday/max * 400, 75);
                label15.Text = max.ToString();
            }
        }

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


            query = "SELECT nama_barang, stok_barang from Barang";
            frm_login.executeDataSet(ds, query, "Barang");
            for (int i = 0; i < ds.Tables["Barang"].Rows.Count; i++)
            {
                if (Convert.ToInt32(ds.Tables["Barang"].Rows[i].ItemArray[1]) <= baranglow)
                {
                    baranglow = Convert.ToInt32(ds.Tables["Barang"].Rows[i].ItemArray[1]);
                    namalow = ds.Tables["Barang"].Rows[i].ItemArray[0].ToString();
                }
            }
            label6.Text = namalow;
            label8.Text = Convert.ToString(baranglow);

            query = "SELECT total_trans, diskon from h_transaksi";
            frm_login.executeDataSet(ds, query, "h_transaksi");
            for (int i = 0; i < ds.Tables["h_transaksi"].Rows.Count; i++)
            {
                totaltransaksi += Convert.ToInt32(ds.Tables["h_transaksi"].Rows[i].ItemArray[0]);
                totaldiskon += Convert.ToInt32(ds.Tables["h_transaksi"].Rows[i].ItemArray[1]);
            }
            totalpendapatan = totaltransaksi - totaldiskon;
            label11.Text = Convert.ToInt32(totalpendapatan).ToString("#,##");

            query = $"SELECT h.tgl_trans, SUM(total_trans) from h_transaksi h where FORMAT(h.tgl_trans, 'dd/MM/yyyy ') = FORMAT(getDate(), 'dd/MM/yyyy ') group by h.tgl_trans";
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
            }
        }
    }
}
