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
    public partial class admin_manage_member : Form
    {
        public admin_manage_member()
        {
            InitializeComponent();
        }
        Add_Member frmAdd;
        public login frm_login;
        Update_Member frmUpdate;
        public string id;
        public string nama = "";
        public string nohp;
        public string tanggallahir;
        public string tanggaldaftar;
        public string gender;
        public string alamat;
        private void admin_manage_member_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(727, 508);

            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
            textBox1.Font = new Font("Nirmala UI", 10, FontStyle.Regular);
            dataGridView1.RowHeadersVisible = false;
            LoadMember();
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmAdd.ShowDialog();
            LoadMember();
        }

        private void LoadMember()
        {
            dataGridView1.Rows.Clear();

            DataSet ds = new DataSet();
            string query = "SELECT * from Member where status_delete = '0'";
            frm_login.executeDataSet(ds, query, "Member");
            loadMemberRecursive(ds, "Member", 0);

        }

        private void loadMemberRecursive(DataSet ds, string tab, int index)
        {
            if (index == ds.Tables[tab].Rows.Count)
            {
                return;
            }
            else
            {
                dataGridView1.Rows.Add(ds.Tables[tab].Rows[index].ItemArray[0], ds.Tables[tab].Rows[index].ItemArray[1], ds.Tables[tab].Rows[index].ItemArray[2], ds.Tables[tab].Rows[index].ItemArray[3], ds.Tables[tab].Rows[index].ItemArray[4], ds.Tables[tab].Rows[index].ItemArray[5], ds.Tables[tab].Rows[index].ItemArray[6]);
                if (dataGridView1.Rows[index].Cells[5].Value.ToString() == "L")
                {
                    dataGridView1.Rows[index].Cells[5].Value = "Laki-Laki";
                }
                if (dataGridView1.Rows[index].Cells[5].Value.ToString() == "P")
                {
                    dataGridView1.Rows[index].Cells[5].Value = "Perempuan";
                }
                loadMemberRecursive(ds, tab, index + 1);
            }
        }
        int idx;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
            id = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            nama = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            nohp = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            tanggallahir = Convert.ToString(dataGridView1.Rows[idx].Cells[3].Value);
            tanggaldaftar = Convert.ToString(dataGridView1.Rows[idx].Cells[4].Value);
            gender = dataGridView1.Rows[idx].Cells[5].Value.ToString();
            alamat = dataGridView1.Rows[idx].Cells[6].Value.ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin mau delete Member ini ?", "Delete Member", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                string query = $"DELETE [Member] where id_member = '{id}'";
                frm_login.executeQuery(query);
                LoadMember();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmAdd = new Add_Member();
            frmAdd.frm_login = frm_login;
            frmAdd.ShowDialog();
            LoadMember();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (nama != "")
            {
                frmUpdate = new Update_Member();
                frmUpdate.id = id;
                frmUpdate.nama = nama;
                frmUpdate.nohp = nohp;
                frmUpdate.tanggallahir = tanggallahir;
                frmUpdate.tanggaldaftar = tanggaldaftar;
                frmUpdate.gender = gender;
                frmUpdate.alamat = alamat;
                frmUpdate.frm_login = frm_login;
                frmUpdate.ShowDialog();

                LoadMember();
            }
            else
            {
                MessageBox.Show("User Belum Dipilih");
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Yakin mau delete [{nama}] ?", "Delete Member", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                string query = $"update [Member] set status_delete = '1' where id_member = '{id}'";
                frm_login.executeQuery(query);
                LoadMember();
            }
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

            if (textBox1.Text != "Search By ID/Nama")
            {
                if (checkNumber(textBox1.Text) == false)
                {
                    DataSet ds = new DataSet();
                    string query = $"SELECT * from Member WHERE lower(nama_member) like '%{textBox1.Text.ToLower()}%'";
                    frm_login.executeDataSet(ds, query, "Member");
                    loadMemberRecursive(ds, "Member", 0);
                }
                else
                {
                    DataSet ds = new DataSet();
                    string query = $"SELECT * from Member WHERE id_member = '{textBox1.Text}'";
                    frm_login.executeDataSet(ds, query, "Member");
                    loadMemberRecursive(ds, "Member", 0);
                }
            }
            else
            {
                LoadMember();
            }
        }

        private void btn_restartcategory_Click(object sender, EventArgs e)
        {
            LoadMember();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search By ID/Nama")
            {
                textBox1.Font = new Font("Nirmala UI", 10, FontStyle.Regular);
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Font = new Font("Nirmala UI", 10, FontStyle.Regular);
                textBox1.Text = "Search By ID/Nama";
                textBox1.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idx = e.RowIndex;
                id = dataGridView1.Rows[idx].Cells[0].Value.ToString();
                nama = dataGridView1.Rows[idx].Cells[1].Value.ToString();
                nohp = dataGridView1.Rows[idx].Cells[2].Value.ToString();
                tanggallahir = Convert.ToString(dataGridView1.Rows[idx].Cells[3].Value);
                tanggaldaftar = Convert.ToString(dataGridView1.Rows[idx].Cells[4].Value);
                gender = dataGridView1.Rows[idx].Cells[5].Value.ToString();
                alamat = dataGridView1.Rows[idx].Cells[6].Value.ToString();
            }
            catch
            {
                idx = 0;
            }
        }
    }
}
