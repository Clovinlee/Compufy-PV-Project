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
        public DataSet ds_kategori;

        private void admin_stock_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(727, 508);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
            dataGridView1.RowHeadersVisible = false;
            //this.FormBorderStyle = FormBorderStyle.None;
            dataGridView1.Rows.Clear();
            loadBarang();
            loadKategori();
            CustomFont();
        }

        private void loadKategori()
        {
            ds_kategori = new DataSet();
            string query = "SELECT nama_kategori from Kategori";
            frm_login.executeDataSet(ds_kategori, query, "Kategori");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmAdd = new add_stock();
            frmAdd.frm_login = frm_login;
            frmAdd.StartPosition = FormStartPosition.CenterScreen;
            frmAdd.ds_kategori = ds_kategori;
            frmAdd.ShowDialog();
            dataGridView1.Rows.Clear();
            loadBarang();
            loadKategori();
        }
        
        private void loadBarang()
        {
            DataSet ds = new DataSet();
            string query = "SELECT b.id_barang, k.nama_kategori, b.nama_barang, b.harga_barang, b.stok_barang, b.gambar from Barang b, Kategori k WHERE b.id_kategori = k.id_kategori and b.status_del = 0";
            frm_login.executeDataSet(ds, query, "Barang");

            loadBarangRecursive(ds, "Barang", 0);
        }

        private void loadBarangRecursive(DataSet ds, string namaTab, int idx)
        {
            if (idx == ds.Tables[namaTab].Rows.Count)
            {
                return;
            }
            else
            {
                string harga = Convert.ToInt32(ds.Tables[namaTab].Rows[idx].ItemArray[3]).ToString("C", new CultureInfo("id-ID"));
                string stok = ds.Tables[namaTab].Rows[idx].ItemArray[4].ToString() + " Unit";

                dataGridView1.Rows.Add(ds.Tables[namaTab].Rows[idx].ItemArray[0], ds.Tables[namaTab].Rows[idx].ItemArray[1], ds.Tables[namaTab].Rows[idx].ItemArray[2], harga, stok);

                try
                {
                    Bitmap original = new Bitmap(Application.StartupPath + "\\product_picture\\" + ds.Tables[namaTab].Rows[idx].ItemArray[5]);
                    Bitmap resized = new Bitmap(original, new Size(75, 75));
                    ((DataGridViewImageCell)dataGridView1.Rows[idx].Cells[5]).Value = resized;
                }
                catch
                {

                }

                loadBarangRecursive(ds, namaTab, idx + 1);
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
            string[] arrStok = stok.Split(' ');

            frmUpdate.frm_login = frm_login;
            frmUpdate.ds_kategori = ds_kategori;
            frmUpdate.id = id;
            frmUpdate.kategori = kategori;
            frmUpdate.txtNama.Text = nama;
            frmUpdate.txtHarga.Text = Convert.ToString(double.Parse(harga, NumberStyles.Currency));
            frmUpdate.txtStok.Text = arrStok[0];
            frmUpdate.ShowDialog();
            dataGridView1.Rows.Clear();
            loadBarang();
        }

        private bool checkNumber(string txt)
        {
            foreach (char c in txt)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (txtSearch.Text == "Search By ID/Nama" || txtSearch.Text == "")
            {
                loadBarang();
            }
            else
            {
                if (checkNumber(txtSearch.Text) == false)
                {
                    DataSet ds = new DataSet();
                    string query = $"SELECT b.id_barang, k.nama_kategori, b.nama_barang, b.harga_barang, b.stok_barang, b.gambar from Barang b, Kategori k WHERE lower(b.nama_barang) like '%{txtSearch.Text.ToLower()}%' and b.id_kategori = k.id_kategori";
                    frm_login.executeDataSet(ds, query, "Barang");

                    searchRecursive(ds, "Barang", 0);
                }
                else
                {
                    DataSet ds = new DataSet();
                    string query = $"SELECT b.id_barang, k.nama_kategori, b.nama_barang, b.harga_barang, b.stok_barang, b.gambar from Barang b, Kategori k WHERE b.id_barang = '{txtSearch.Text}' and b.id_kategori = k.id_kategori";
                    frm_login.executeDataSet(ds, query, "Barang");

                    searchRecursive1(ds, "Barang", 0);
                }
            }   
        }

        private void searchRecursive(DataSet ds, string namaTab, int idx)
        {
            if (idx == ds.Tables[namaTab].Rows.Count)
            {
                return;
            }
            else
            {
                string harga = Convert.ToInt32(ds.Tables[namaTab].Rows[idx].ItemArray[3]).ToString("C", new CultureInfo("id-ID"));
                string stok = ds.Tables[namaTab].Rows[idx].ItemArray[4].ToString() + " Unit";

                dataGridView1.Rows.Add(ds.Tables[namaTab].Rows[idx].ItemArray[0], ds.Tables[namaTab].Rows[idx].ItemArray[1], ds.Tables[namaTab].Rows[idx].ItemArray[2], harga, stok);

                try
                {
                    Bitmap original = new Bitmap(Application.StartupPath + "\\product_picture\\" + ds.Tables[namaTab].Rows[idx].ItemArray[5]);
                    Bitmap resized = new Bitmap(original, new Size(75, 75));
                    ((DataGridViewImageCell)dataGridView1.Rows[idx].Cells[5]).Value = resized;
                }
                catch
                {

                }

                searchRecursive(ds, namaTab, idx + 1);
            } 
        }

        private void searchRecursive1(DataSet ds, string namaTab, int idx)
        {
            if (idx == ds.Tables[namaTab].Rows.Count)
            {
                return;
            }
            else
            {
                string harga = Convert.ToInt32(ds.Tables[namaTab].Rows[idx].ItemArray[3]).ToString("C", new CultureInfo("id-ID"));
                string stok = ds.Tables[namaTab].Rows[idx].ItemArray[4].ToString() + " Unit";

                dataGridView1.Rows.Add(ds.Tables[namaTab].Rows[idx].ItemArray[0], ds.Tables[namaTab].Rows[idx].ItemArray[1], ds.Tables[namaTab].Rows[idx].ItemArray[2], harga, stok);

                try
                {
                    Bitmap original = new Bitmap(Application.StartupPath + "\\product_picture\\" + ds.Tables[namaTab].Rows[idx].ItemArray[5]);
                    Bitmap resized = new Bitmap(original, new Size(75, 75));
                    ((DataGridViewImageCell)dataGridView1.Rows[idx].Cells[5]).Value = resized;
                }
                catch
                {

                }

                searchRecursive1(ds, namaTab, idx + 1);
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
            dataGridView1.Rows.Clear();
            loadBarang();
            txtSearch.Text = "Search By ID/Nama";
            txtSearch.ForeColor = SystemColors.ScrollBar;
        }

        int idx;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            idx = e.RowIndex;
            string namaBarang = dataGridView1.Rows[idx].Cells[2].Value.ToString();

            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show($"Yakin mendelete {namaBarang}?", "Delete Barang", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string query = $"Update [Barang] set status_del = 1 where id_barang = '{Convert.ToInt32(dataGridView1.Rows[idx].Cells[0].Value)}'";
                    frm_login.executeQuery(query);
                    dataGridView1.Rows.Clear();
                    loadBarang();
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
