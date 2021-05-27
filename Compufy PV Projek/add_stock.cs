using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Compufy_PV_Projek
{
    public partial class add_stock : Form
    {
        public add_stock()
        {
            InitializeComponent();
        }

        public login frm_login;
        bool kosong;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (Control tb in this.Controls)
            {
                if (tb is TextBox)
                {
                    if (tb.Text == "")
                    {
                        kosong = true;
                    }
                }
            }

            checkHarga = CheckNumber(txtHarga.Text);
            checkStok = CheckNumber(txtStok.Text);

            if (kosong == true)
            {
                MessageBox.Show("Ada field kosong!",
                    "Field Kosong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                kosong = false;
            }
            else if (checkHarga == false || checkStok == false)
            {
                MessageBox.Show("Harga dan Stok harus angka !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pictureBox1.ImageLocation == null)
            {
                DataSet ds;
                string query;

                ds = new DataSet();
                query = $"SELECT nama_kategori from Kategori where nama_kategori = '{cbKategori.Text}'";
                frm_login.executeDataSet(ds, query, "Kategori");

                if (ds.Tables["Kategori"].Rows.Count == 0)
                {
                    query = $"INSERT into kategori (nama_kategori) VALUES ('{cbKategori.Text}')";
                    frm_login.executeQuery(query);
                }

                ds = new DataSet();
                query = $"SELECT id_kategori, nama_kategori from Kategori where nama_kategori = '{cbKategori.Text}'";
                frm_login.executeDataSet(ds, query, "Kategori");

                idKat = Convert.ToInt32(ds.Tables["Kategori"].Rows[0].ItemArray[0]);

                query = $"INSERT into [Barang] (nama_barang, id_kategori, harga_barang, stok_barang, status_del) VALUES('{txtNama.Text}', '{idKat}', '{txtHarga.Text}', '{txtStok.Text}', 0)";
                frm_login.executeQuery(query);
                this.Close();
            }
            else
            {
                DataSet ds;
                string query;

                ds = new DataSet();
                query = $"SELECT nama_kategori from Kategori where nama_kategori = '{cbKategori.Text}'";
                frm_login.executeDataSet(ds, query, "Kategori");

                if (ds.Tables["Kategori"].Rows.Count == 0)
                {
                    query = $"INSERT into kategori (nama_kategori) VALUES ('{cbKategori.Text}')";
                    frm_login.executeQuery(query);
                }

                ds = new DataSet();
                query = $"SELECT id_kategori, nama_kategori from Kategori where nama_kategori = '{cbKategori.Text}'";
                frm_login.executeDataSet(ds, query, "Kategori");

                idKat = Convert.ToInt32(ds.Tables["Kategori"].Rows[0].ItemArray[0]);

                query = $"INSERT into [Barang] (nama_barang, id_kategori, harga_barang, stok_barang, gambar, status_del) VALUES('{txtNama.Text}', '{idKat}', '{txtHarga.Text}', '{txtStok.Text}', '{openFileDialog1.SafeFileName}', 0)";
                frm_login.executeQuery(query);
                this.Close();
            }
        }

        private void add_stock_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(500, 300);
            this.MaximumSize = new Size(500, 300);
            kosong = false;
            cbKategori.Items.Clear();
            loadKategoriRecursive(0);
        }

        private void loadKategoriRecursive(int idx)
        {
            DataSet ds = new DataSet();
            string query = "SELECT nama_kategori from Kategori";
            frm_login.executeDataSet(ds, query, "Kategori");

            if (idx == ds.Tables["Kategori"].Rows.Count)
            {
                return;
            }
            else
            {
                cbKategori.Items.Add(ds.Tables["Kategori"].Rows[idx].ItemArray[0]);
            }

            loadKategoriRecursive(idx + 1);
        }

        int idKat;

        private void btnFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images (*.PNG;*.JPG)|*.PNG;*.JPG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string directory = "product_picture\\";
                Directory.CreateDirectory(directory);

                if (!File.Exists(Application.StartupPath + "\\product_picture\\" + openFileDialog1.SafeFileName))
                {
                    File.Copy(openFileDialog1.FileName, directory + openFileDialog1.SafeFileName, true);
                }
                
                pictureBox1.ImageLocation = Application.StartupPath + "\\product_picture\\" + openFileDialog1.SafeFileName;
            }
            else
            {
                MessageBox.Show("No File",
                    "No File Choosen",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        bool checkHarga;
        bool checkStok;

        private bool CheckNumber(string txt)
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
    }
}
