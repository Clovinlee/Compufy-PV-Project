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
    public partial class add_stock : Form
    {
        public add_stock()
        {
            InitializeComponent();
        }

        public login frm_login;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = $"INSERT into [Barang] (nama_barang, id_kategori, harga_barang, stok_barang) VALUES('{txtNama.Text}', '{cbKategori.SelectedIndex + 1}', '{txtHarga.Text}', '{txtStok.Text}')";
            frm_login.executeQuery(query);
            this.Close();
        }

        private void add_stock_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(550, 290);
            this.MaximumSize = new Size(550, 290);
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblDirectory.Text = openFileDialog1.FileName;
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
