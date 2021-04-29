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
    public partial class update_stock : Form
    {
        public update_stock()
        {
            InitializeComponent();
        }

        public login frm_login;
        public string id;

        private void update_stock_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(500, 300);
            this.MaximumSize = new Size(500, 300);
            kosong = false;
            loadKategori();
            cbKategori.SelectedIndex = cbKategori.Items.IndexOf(cbKategori.Text);
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

        bool kosong;
        bool checkHarga;
        bool checkStok;

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
                if (MessageBox.Show("Yakin update tanpa gambar ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string query = $"UPDATE [Barang] set nama_barang = '{txtNama.Text}', id_kategori = '{cbKategori.SelectedIndex + 1}', harga_barang = '{txtHarga.Text}', stok_barang = '{txtStok.Text}', gambar = '{openFileDialog1.SafeFileName}' where id_barang = {id}";
                    frm_login.executeQuery(query);
                    this.Close();
                }
            }
            else
            {
                string query = $"UPDATE [Barang] set nama_barang = '{txtNama.Text}', id_kategori = '{cbKategori.SelectedIndex + 1}', harga_barang = '{txtHarga.Text}', stok_barang = '{txtStok.Text}', gambar = '{openFileDialog1.SafeFileName}' where id_barang = {id}";
                frm_login.executeQuery(query);
                this.Close();
            }
        }

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
