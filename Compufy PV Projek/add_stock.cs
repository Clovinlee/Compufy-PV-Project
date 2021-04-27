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

            if (kosong == true)
            {
                MessageBox.Show("Ada field kosong!",
                    "Field Kosong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                kosong = false;
            }
            else if (pictureBox1.ImageLocation == null)
            {
                if (MessageBox.Show("Gambar kosong, yakin menambah stok ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string query = $"INSERT into [Barang] (nama_barang, id_kategori, harga_barang, stok_barang, gambar) VALUES('{txtNama.Text}', '{cbKategori.SelectedIndex + 1}', '{txtHarga.Text}', '{txtStok.Text}', '{openFileDialog1.SafeFileName}')";
                    frm_login.executeQuery(query);
                    this.Close();
                }
            }
            else
            {
                string query = $"INSERT into [Barang] (nama_barang, id_kategori, harga_barang, stok_barang, gambar) VALUES('{txtNama.Text}', '{cbKategori.SelectedIndex + 1}', '{txtHarga.Text}', '{txtStok.Text}', '{openFileDialog1.SafeFileName}')";
                frm_login.executeQuery(query);
                this.Close();
            }
        }

        private void add_stock_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(500, 300);
            this.MaximumSize = new Size(500, 300);
            kosong = false;
            loadKategori();
        }

        private void loadKategori()
        {
            cbKategori.Items.Clear();

            DataSet ds = new DataSet();
            string query = "SELECT nama_kategori from Kategori";
            frm_login.executeDataSet(ds, query, "Kategori");

            for (int i = 0; i < ds.Tables["Kategori"].Rows.Count; i++)
            {
                cbKategori.Items.Add(ds.Tables["Kategori"].Rows[i].ItemArray[0]);
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" + "All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string directory = "product_picture\\";
                Directory.CreateDirectory(directory);
                File.Copy(openFileDialog1.FileName, directory + openFileDialog1.SafeFileName, true);

                pictureBox1.ImageLocation = Application.StartupPath + "\\product_picture\\" + openFileDialog1.SafeFileName;
            }
            else
            {
                MessageBox.Show("No File",
                    "No File Choosen",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
