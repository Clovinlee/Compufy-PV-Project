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

namespace Compufy_PV_Projek
{
    public partial class admin_stock : Form
    {
        public admin_stock()
        {
            InitializeComponent();
        }

        add_stock frmAdd;
        public login frm_login;

        private void admin_stock_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(727, 508);
            frmAdd = new add_stock();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 11, FontStyle.Bold);
            //this.FormBorderStyle = FormBorderStyle.None;

            LoadBarang();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmAdd.frm_login = frm_login;
            frmAdd.ShowDialog();
            LoadBarang();
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

        private void LoadBarang()
        {
            dataGridView1.Rows.Clear();
            cbKategori.Items.Clear();

            DataSet ds = new DataSet();
            string query = "SELECT b.id_barang, k.nama_kategori, b.nama_barang, b.harga_barang, b.stok_barang from Barang b, Kategori k WHERE b.id_kategori = k.id_kategori";
            frm_login.executeDataSet(ds, query, "Barang");

            for (int i = 0; i < ds.Tables["Barang"].Rows.Count; i++)
            {
                dataGridView1.Rows.Add(ds.Tables["Barang"].Rows[i].ItemArray[0], ds.Tables["Barang"].Rows[i].ItemArray[1], ds.Tables["Barang"].Rows[i].ItemArray[2], ds.Tables["Barang"].Rows[i].ItemArray[3], ds.Tables["Barang"].Rows[i].ItemArray[4]);

                if (!cbKategori.Items.Contains(ds.Tables["Barang"].Rows[i].ItemArray[1]))
                {
                    cbKategori.Items.Add(ds.Tables["Barang"].Rows[i].ItemArray[1]);
                }
            } 
        }

        int idx;
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idx = e.RowIndex;
            txtID.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            txtNama.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            cbKategori.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            txtHarga.Text = dataGridView1.Rows[idx].Cells[3].Value.ToString();
            txtStok.Text = dataGridView1.Rows[idx].Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE [Barang] set nama_barang = '{txtNama.Text}', id_kategori = '{(cbKategori.SelectedIndex + 1).ToString()}', harga_barang = '{txtHarga.Text}', stok_barang = '{txtStok.Text}' WHERE id_barang = '{txtID.Text}'";
            frm_login.executeQuery(query);
            LoadBarang();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin mau delete barang ini ?", "Delete Barang", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                string query = $"DELETE [Barang] where id_barang = '{txtID.Text}'";
                frm_login.executeQuery(query);
                LoadBarang();
            }  
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (txtSearch.Text == "Search By ID/Nama" || txtSearch.Text == "")
            {
                LoadBarang();
            }
            else
            {
                DataSet ds = new DataSet();
                string query = $"SELECT b.id_barang, k.nama_kategori, b.nama_barang, b.harga_barang, b.stok_barang from Barang b, Kategori k WHERE b.id_barang like '%{txtSearch.Text}%' or b.nama_barang like '%{txtSearch.Text}%'";
                frm_login.executeDataSet(ds, query, "Barang");

                for (int i = 0; i < ds.Tables["Barang"].Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(ds.Tables["Barang"].Rows[i].ItemArray[0], ds.Tables["Barang"].Rows[i].ItemArray[1], ds.Tables["Barang"].Rows[i].ItemArray[2], ds.Tables["Barang"].Rows[i].ItemArray[3], ds.Tables["Barang"].Rows[i].ItemArray[4]);

                    if (!cbKategori.Items.Contains(ds.Tables["Barang"].Rows[i].ItemArray[1]))
                    {
                        cbKategori.Items.Add(ds.Tables["Barang"].Rows[i].ItemArray[1]);
                    }
                }

                txtSearch.Focus();
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
    }
}
