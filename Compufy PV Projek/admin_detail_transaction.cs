using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Compufy_PV_Projek
{
    public partial class admin_detail_transaction : Form
    {
        public admin_detail_transaction()
        {
            InitializeComponent();
        }

        public login frm_login;
        public int id;

        private void admin_detail_transaction_Load(object sender, EventArgs e)
        {
            LoadLabel();
            LoadDetail();
            this.MaximumSize = new Size(601, 560);
            this.MinimumSize = new Size(601, 560);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
        }

        private void LoadLabel()
        {
            dataGridView1.Rows.Clear();

            DataSet ds = new DataSet();
            string query = $"SELECT h.id_trans, h.tgl_trans, a.nama_user, isnull(m.nama_member, '-'), isnull(h.no_kartu, '-'), h.total_trans, h.bayar, h.diskon from h_transaksi h left join akun a on h.id_user = a.id_user left join member m on h.id_member = m.id_member where h.id_trans = {id}";
            frm_login.executeDataSet(ds, query, "Trans");

            int total = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[5]) - Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[7]);
            int kembalian = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[6]) - total;

            lbl_id.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            lbl_tanggal.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            lbl_kasir.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            lbl_member.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();

            string kartuKreditDariDB = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            string kartuKredit = "";

            if (kartuKreditDariDB != "-" && kartuKreditDariDB != "" && kartuKreditDariDB != " ")
            {
                for (int x = 1; x < 13; x++)
                {
                    kartuKredit += kartuKreditDariDB[x - 1];
                    if (x % 4 == 0 && x != 12)
                    {
                        kartuKredit += "-";
                    }
                }
            }
            else
            {
                kartuKredit = "-";
            }
            
            lbl_nokartu.Text = kartuKredit;
            lbl_total.Text = "Rp" + total.ToString("#,##");
            lbl_bayar.Text = "Rp" + Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[6]).ToString("#,##");
            lbl_diskon.Text = "Rp" + Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[7]).ToString("#,##");

            if (kembalian == 0)
            {
                lbl_kembalian.Text = "Rp0";
            }
            else
            {
                lbl_kembalian.Text = "Rp" + kembalian.ToString("#,##");
            } 
        }

        private void LoadDetail()
        {
            dataGridView1.Rows.Clear();

            DataSet ds = new DataSet();
            string query = $"SELECT b.nama_barang, b.harga_barang, d.jumlah_barang, b.harga_barang * d.jumlah_barang from Barang b, d_transaksi d WHERE b.id_barang = d.id_barang and d.id_trans = {id}";
            frm_login.executeDataSet(ds, query, "Barang");

            for (int i = 0; i < ds.Tables["Barang"].Rows.Count; i++)
            {
                string harga = Convert.ToInt32(ds.Tables["Barang"].Rows[i].ItemArray[1]).ToString("C", new CultureInfo("id-ID"));
                string jumlah = ds.Tables["Barang"].Rows[i].ItemArray[2].ToString() + " Unit";
                string total = (Convert.ToInt32(ds.Tables["Barang"].Rows[i].ItemArray[1]) * Convert.ToInt32(ds.Tables["Barang"].Rows[i].ItemArray[2])).ToString("C", new CultureInfo("id-ID"));

                dataGridView1.Rows.Add(ds.Tables["Barang"].Rows[i].ItemArray[0], harga, jumlah, total);
            }
        }

        private void btnNota_Click(object sender, EventArgs e)
        {
            string q = $"SELECT m.nama_member, h.bayar, h.metode_trans FROM h_transaksi h LEFT JOIN member m ON m.id_member = h.id_member WHERE h.id_trans = {id}";
            DataSet ds_temp = new DataSet();
            frm_login.executeDataSet(ds_temp, q, "h_tb");
            q = $"SELECT id_barang FROM d_transaksi WHERE id_trans = {id}";
            frm_login.executeDataSet(ds_temp, q, "d_tb");
            List<string> id_barang = new List<string>();
            foreach (DataRow r in ds_temp.Tables["d_tb"].Rows)
            {
                id_barang.Add(r[0].ToString());
            }

            kasir_nota frm_nota = new kasir_nota();
            frm_nota.id_barang = id_barang;

            DataRow dr = ds_temp.Tables["h_tb"].Rows[0];
            frm_nota.nama_member = dr[0].ToString();
            frm_nota.bayar = Convert.ToDecimal(dr[1]);
            frm_nota.metode = dr[2].ToString();
            frm_nota.h_id = id;
            frm_nota.frm_login = frm_login;
            frm_nota.Show();
        }
    }
}
