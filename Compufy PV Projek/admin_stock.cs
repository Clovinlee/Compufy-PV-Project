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
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
            dataGridView1.RowHeadersVisible = false;
            //this.FormBorderStyle = FormBorderStyle.None;
            dataGridView1.Rows.Clear();
            LoadBarangRecursive(0);
            CustomFont();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmAdd = new add_stock();
            frmAdd.frm_login = frm_login;
            frmAdd.StartPosition = FormStartPosition.CenterScreen;
            frmAdd.ShowDialog();
            dataGridView1.Rows.Clear();
            LoadBarangRecursive(0);
        }

        private void LoadBarangRecursive(int idx)
        {
            DataSet ds = new DataSet();
            string query = "SELECT b.id_barang, k.nama_kategori, b.nama_barang, b.harga_barang, b.stok_barang, b.gambar from Barang b, Kategori k WHERE b.id_kategori = k.id_kategori and b.status_del = 0";
            frm_login.executeDataSet(ds, query, "Barang");

            if (idx == ds.Tables["Barang"].Rows.Count)
            {
                return;
            }
            else
            {
                string harga = Convert.ToInt32(ds.Tables["Barang"].Rows[idx].ItemArray[3]).ToString("C", new CultureInfo("id-ID"));
                string stok = ds.Tables["Barang"].Rows[idx].ItemArray[4].ToString() + " Unit";

                dataGridView1.Rows.Add(ds.Tables["Barang"].Rows[idx].ItemArray[0], ds.Tables["Barang"].Rows[idx].ItemArray[1], ds.Tables["Barang"].Rows[idx].ItemArray[2], harga, stok);

                try
                {
                    Bitmap original = new Bitmap(Application.StartupPath + "\\product_picture\\" + ds.Tables["Barang"].Rows[idx].ItemArray[5]);
                    Bitmap resized = new Bitmap(original, new Size(75, 75));
                    ((DataGridViewImageCell)dataGridView1.Rows[idx].Cells[5]).Value = resized;
                }
                catch
                {

                }

                LoadBarangRecursive(idx + 1);
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
            frmUpdate.id = id;
            frmUpdate.kategori = kategori;
            frmUpdate.txtNama.Text = nama;
            frmUpdate.txtHarga.Text = Convert.ToString(double.Parse(harga, NumberStyles.Currency));
            frmUpdate.txtStok.Text = arrStok[0];
            frmUpdate.ShowDialog();
            dataGridView1.Rows.Clear();
            LoadBarangRecursive(0);
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
                LoadBarangRecursive(0);
            }
            else
            {
                if (checkNumber(txtSearch.Text) == false)
                {
                    searchRecursive(0);
                }
                else
                {
                    searchRecursive1(0);
                }
            }   
        }

        private void searchRecursive(int idx)
        {
            DataSet ds = new DataSet();
            string query = $"SELECT b.id_barang, k.nama_kategori, b.nama_barang, b.harga_barang, b.stok_barang, b.gambar from Barang b, Kategori k WHERE lower(b.nama_barang) like '%{txtSearch.Text.ToLower()}%' and b.id_kategori = k.id_kategori";
            frm_login.executeDataSet(ds, query, "Barang");

            if (idx == ds.Tables["Barang"].Rows.Count)
            {
                return;
            }
            else
            {
                string harga = Convert.ToInt32(ds.Tables["Barang"].Rows[idx].ItemArray[3]).ToString("C", new CultureInfo("id-ID"));
                string stok = ds.Tables["Barang"].Rows[idx].ItemArray[4].ToString() + " Unit";

                dataGridView1.Rows.Add(ds.Tables["Barang"].Rows[idx].ItemArray[0], ds.Tables["Barang"].Rows[idx].ItemArray[1], ds.Tables["Barang"].Rows[idx].ItemArray[2], harga, stok);

                try
                {
                    Bitmap original = new Bitmap(Application.StartupPath + "\\product_picture\\" + ds.Tables["Barang"].Rows[idx].ItemArray[5]);
                    Bitmap resized = new Bitmap(original, new Size(75, 75));
                    ((DataGridViewImageCell)dataGridView1.Rows[idx].Cells[5]).Value = resized;
                }
                catch
                {

                }

                searchRecursive(idx + 1);
            } 
        }

        private void searchRecursive1(int idx)
        {
            DataSet ds = new DataSet();
            string query = $"SELECT b.id_barang, k.nama_kategori, b.nama_barang, b.harga_barang, b.stok_barang, b.gambar from Barang b, Kategori k WHERE b.id_barang = '{txtSearch.Text}' and b.id_kategori = k.id_kategori";
            frm_login.executeDataSet(ds, query, "Barang");

            if (idx == ds.Tables["Barang"].Rows.Count)
            {
                return;
            }
            else
            {
                string harga = Convert.ToInt32(ds.Tables["Barang"].Rows[idx].ItemArray[3]).ToString("C", new CultureInfo("id-ID"));
                string stok = ds.Tables["Barang"].Rows[idx].ItemArray[4].ToString() + " Unit";

                dataGridView1.Rows.Add(ds.Tables["Barang"].Rows[idx].ItemArray[0], ds.Tables["Barang"].Rows[idx].ItemArray[1], ds.Tables["Barang"].Rows[idx].ItemArray[2], harga, stok);

                try
                {
                    Bitmap original = new Bitmap(Application.StartupPath + "\\product_picture\\" + ds.Tables["Barang"].Rows[idx].ItemArray[5]);
                    Bitmap resized = new Bitmap(original, new Size(75, 75));
                    ((DataGridViewImageCell)dataGridView1.Rows[idx].Cells[5]).Value = resized;
                }
                catch
                {

                }

                searchRecursive1(idx + 1);
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
            LoadBarangRecursive(0);
            txtSearch.Text = "Search By ID/Nama";
            txtSearch.ForeColor = SystemColors.ScrollBar;
        }

        int idx;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;

            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("Yakin mendelete barang ini?", "Delete Barang", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string query = $"Update [Barang] set status_del = 1 where id_barang = '{Convert.ToInt32(dataGridView1.Rows[idx].Cells[0].Value)}'";
                    frm_login.executeQuery(query);
                    dataGridView1.Rows.Clear();
                    LoadBarangRecursive(0);
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
