using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Drawing.Text;
using System.IO;

namespace Compufy_PV_Projek
{
    public partial class admin_stock : Form
    {
        public admin_stock()
        {
            InitializeComponent();
        }

        add_stock frmAdd;
        update_stock frmUpdate;
        public login frm_login;

        private void admin_stock_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(727, 508);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 11, FontStyle.Bold);
            //this.FormBorderStyle = FormBorderStyle.None;
            LoadBarang();
            CustomFont();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmAdd = new add_stock();
            frmAdd.frm_login = frm_login;
            frmAdd.ShowDialog();
            LoadBarang();
        }

        private void LoadBarang()
        {
            dataGridView1.Rows.Clear();

            DataSet ds = new DataSet();
            string query = "SELECT b.id_barang, k.nama_kategori, b.nama_barang, b.harga_barang, b.stok_barang, b.gambar from Barang b, Kategori k WHERE b.id_kategori = k.id_kategori";
            frm_login.executeDataSet(ds, query, "Barang");

            for (int i = 0; i < ds.Tables["Barang"].Rows.Count; i++)
            {
                string harga = Convert.ToInt32(ds.Tables["Barang"].Rows[i].ItemArray[3]).ToString("C", new CultureInfo("id-ID"));
                string stok = ds.Tables["Barang"].Rows[i].ItemArray[4].ToString() + " Unit";

                dataGridView1.Rows.Add(ds.Tables["Barang"].Rows[i].ItemArray[0], ds.Tables["Barang"].Rows[i].ItemArray[1], ds.Tables["Barang"].Rows[i].ItemArray[2], harga, stok);

                try
                {
                    Bitmap original = new Bitmap(Application.StartupPath + "\\product_picture\\" + ds.Tables["Barang"].Rows[i].ItemArray[5]);
                    Bitmap resized = new Bitmap(original, new Size(75, 75));
                    ((DataGridViewImageCell)dataGridView1.Rows[i].Cells[5]).Value = resized;
                }
                catch
                {

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate = new update_stock();
            string id = Convert.ToString(dataGridView1.Rows[idx].Cells[0].Value);
            string kategori = Convert.ToString(dataGridView1.Rows[idx].Cells[1].Value);
            string nama = Convert.ToString(dataGridView1.Rows[idx].Cells[2].Value);
            string harga = Convert.ToString(dataGridView1.Rows[idx].Cells[3].Value);
            string stok = Convert.ToString(dataGridView1.Rows[idx].Cells[4].Value);

            frmUpdate.frm_login = frm_login;
            frmUpdate.id = id;
            frmUpdate.cbKategori.Text = kategori;
            frmUpdate.txtNama.Text = nama;
            frmUpdate.txtHarga.Text = harga;
            frmUpdate.txtStok.Text = stok;
            frmUpdate.ShowDialog();
            LoadBarang();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            DataSet ds = new DataSet();
            string query = $"SELECT b.id_barang, k.nama_kategori, b.nama_barang, b.harga_barang, b.stok_barang, b.gambar from Barang b, Kategori k WHERE lower(b.nama_barang) like '%{txtSearch.Text.ToLower()}%' and b.id_kategori = k.id_kategori";
            frm_login.executeDataSet(ds, query, "Barang");

            for (int i = 0; i < ds.Tables["Barang"].Rows.Count; i++)
            {
                dataGridView1.Rows.Add(ds.Tables["Barang"].Rows[i].ItemArray[0], ds.Tables["Barang"].Rows[i].ItemArray[1], ds.Tables["Barang"].Rows[i].ItemArray[2], ds.Tables["Barang"].Rows[i].ItemArray[3], ds.Tables["Barang"].Rows[i].ItemArray[4]);

                try
                {
                    Bitmap original = new Bitmap(Application.StartupPath + "\\product_picture\\" + ds.Tables["Barang"].Rows[i].ItemArray[5]);
                    Bitmap resized = new Bitmap(original, new Size(75, 75));
                    ((DataGridViewImageCell)dataGridView1.Rows[i].Cells[5]).Value = resized;
                }
                catch
                {

                }
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search By ID/Nama")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search By ID/Nama";
                txtSearch.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            LoadBarang();
        }

        int idx;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;

            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("Yakin mendelete barang ini?", "Delete Barang", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string query = $"DELETE from [Barang] where id_barang = '{Convert.ToInt32(dataGridView1.Rows[idx].Cells[0].Value)}'";
                    frm_login.executeQuery(query);
                    LoadBarang();
                }
            }
        }

        PrivateFontCollection pfc;

        private void CustomFont()
        {
            pfc = new PrivateFontCollection();
            pfc.AddFontFile(Path.Combine(Application.StartupPath, "HeydingsControls-GBlZ.ttf"));
            Font heydings = new Font(pfc.Families[0], 24);
            dataGridView1.Columns[6].DefaultCellStyle.Font = heydings;
        }
    }
}
