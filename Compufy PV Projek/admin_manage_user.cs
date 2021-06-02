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
    public partial class admin_manage_user : Form
    {
        public admin_manage_user()
        {
            InitializeComponent();
        }
        Add_User frmAdd;
        public login frm_login;
        public menu_admin frm_admin;
        Update_User frmUpdate;
        public string id;
        public string username = "";
        public string password;
        public string nama;
        public string datebirth;
        public string gender;
        public string tipeuser;
        public List<string> semuagambar = new List<string>();
        public string gambar;
        public List<string> semuapassword = new List<string>();
        public List<string> semuausername = new List<string>();
        private void admin_manage_user_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(727, 508);

            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
            textBox1.Font = new Font("Nirmala UI", 10, FontStyle.Regular);
            dataGridView1.RowHeadersVisible = false;
            LoadUser();
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmAdd = new Add_User();
            frmAdd.ShowDialog();
            LoadUser();
        }

        private void LoadUser()
        {
            dataGridView1.Rows.Clear();
            semuapassword.Clear();
            semuagambar.Clear();
            semuausername.Clear();
            DataSet ds = new DataSet();
            string query = "SELECT id_user, username, password, nama_user, tgl_lahir_user, jk_user, tipe_user, isnull(gambar, '-') from Akun where status_delete = '0'";
            frm_login.executeDataSet(ds, query, "Akun");

            loadUserRecursive(ds, "Akun", 0);

            
        }

        private void loadUserRecursive(DataSet ds, string tab, int index)
        {
            if (index == ds.Tables[tab].Rows.Count)
            {
                return;
            }
            else
            {
                dataGridView1.Rows.Add(ds.Tables[tab].Rows[index].ItemArray[0], ds.Tables[tab].Rows[index].ItemArray[1], ds.Tables[tab].Rows[index].ItemArray[2], ds.Tables[tab].Rows[index].ItemArray[3], ds.Tables[tab].Rows[index].ItemArray[4], ds.Tables[tab].Rows[index].ItemArray[5], ds.Tables[tab].Rows[index].ItemArray[6]);
                if (dataGridView1.Rows[index].Cells[6].Value.ToString() == "1")
                {
                    dataGridView1.Rows[index].Cells[6].Value = "Admin";
                }
                if (dataGridView1.Rows[index].Cells[6].Value.ToString() == "2")
                {
                    dataGridView1.Rows[index].Cells[6].Value = "Kasir";
                }

                string secretpass = dataGridView1.Rows[index].Cells[2].Value.ToString();
                semuapassword.Add(dataGridView1.Rows[index].Cells[2].Value.ToString());
                semuagambar.Add(ds.Tables[tab].Rows[index].ItemArray[7].ToString());
                semuausername.Add(dataGridView1.Rows[index].Cells[1].Value.ToString());
                dataGridView1.Rows[index].Cells[2].Value = "";
                for (int j = 0; j < secretpass.Length; j++)
                {
                    dataGridView1.Rows[index].Cells[2].Value += "*";
                }
                if (ds.Tables[tab].Rows[index].ItemArray[7].ToString() == "-" && ds.Tables[tab].Rows[index].ItemArray[5].ToString() == "L")
                {
                    try
                    {
                        Bitmap original = new Bitmap(Application.StartupPath + "\\profile_picture\\profile_sample7.png");
                        Bitmap resized = new Bitmap(original, new Size(75, 75));
                        ((DataGridViewImageCell)dataGridView1.Rows[index].Cells[7]).Value = resized;
                    }
                    catch
                    {

                    }
                }
                if (ds.Tables[tab].Rows[index].ItemArray[7].ToString() == "-" && ds.Tables[tab].Rows[index].ItemArray[5].ToString() == "P")
                {
                    try
                    {
                        Bitmap original = new Bitmap(Application.StartupPath + "\\profile_picture\\profile_sample1.png");
                        Bitmap resized = new Bitmap(original, new Size(75, 75));
                        ((DataGridViewImageCell)dataGridView1.Rows[index].Cells[7]).Value = resized;
                    }
                    catch
                    {

                    }
                }
                if (ds.Tables[tab].Rows[index].ItemArray[7].ToString() != "-")
                {
                    try
                    {
                        Bitmap original = new Bitmap(Application.StartupPath + "\\profile_picture\\" + ds.Tables[tab].Rows[index].ItemArray[7]);
                        Bitmap resized = new Bitmap(original, new Size(75, 75));
                        ((DataGridViewImageCell)dataGridView1.Rows[index].Cells[7]).Value = resized;
                    }
                    catch
                    {

                    }
                }
                if (dataGridView1.Rows[index].Cells[5].Value.ToString() == "L")
                {
                    dataGridView1.Rows[index].Cells[5].Value = "Laki-Laki";
                }
                if (dataGridView1.Rows[index].Cells[5].Value.ToString() == "P")
                {
                    dataGridView1.Rows[index].Cells[5].Value = "Perempuan";
                }
                loadUserRecursive(ds, tab, index + 1);
            }
            
        }
        int idx;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idx = e.RowIndex;
                id = dataGridView1.Rows[idx].Cells[0].Value.ToString();
                username = dataGridView1.Rows[idx].Cells[1].Value.ToString();
                password = semuapassword[idx];
                nama = (dataGridView1.Rows[idx].Cells[3].Value.ToString());
                datebirth = dataGridView1.Rows[idx].Cells[4].Value.ToString();
                gender = dataGridView1.Rows[idx].Cells[5].Value.ToString();
                tipeuser = dataGridView1.Rows[idx].Cells[6].Value.ToString();
            }
            catch
            {
                idx = 0;
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate = new Update_User();
            if (username != "")
            {
                frmUpdate.frm_login = frm_login;
                frmUpdate.id = id;
                frmUpdate.username = username;
                frmUpdate.password = password;
                frmUpdate.nama = nama;
                frmUpdate.datebirth = datebirth;
                frmUpdate.gender = gender;
                frmUpdate.tipeuser = tipeuser;
                frmUpdate.gambar = gambar;
                frmUpdate.frm_admin = frm_admin;
                frmUpdate.semuauser = semuausername;
                frmUpdate.ShowDialog();
                

                LoadUser();
            }
            else
            {
                MessageBox.Show("Tidak Ada User yang diselect");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (username != "")
            {
                DialogResult dialogResult = MessageBox.Show($"Yakin mau delete [{username}] ?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    string query = $"update [Akun] set status_delete = '1' where id_user = '{id}'";
                    frm_login.executeQuery(query);
                    LoadUser();
                    username = "";
                }
            }
            else
            {
                MessageBox.Show("Tidak Ada User yang diselect");
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
            semuapassword.Clear();
            semuausername.Clear();

            if (textBox1.Text != "Search By ID/Username") {
                if (checkNumber(textBox1.Text) == false)
                {
                    DataSet ds = new DataSet();
                    string query = $"SELECT id_user, username, password, nama_user, tgl_lahir_user, jk_user, tipe_user, isnull(gambar, '-') from Akun WHERE lower(username) like '%{textBox1.Text.ToLower()}%'";
                    frm_login.executeDataSet(ds, query, "Akun");

                    loadUserRecursive(ds, "Akun", 0);

                }
                else
                {
                    DataSet ds = new DataSet();
                    string query = $"SELECT id_user, username, password, nama_user, tgl_lahir_user, jk_user, tipe_user, isnull(gambar, '-') from Akun WHERE id_user = '{textBox1.Text}'";
                    frm_login.executeDataSet(ds, query, "Akun");

                    loadUserRecursive(ds, "Akun", 0);
                }
                
            }
            else
            {
                LoadUser();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmAdd = new Add_User();
            frmAdd.frm_login = frm_login;
            frmAdd.semuauser = semuausername;
            frmAdd.ShowDialog();
            id = "";
            username = "";
            password = "";
            nama = "";
            datebirth = "";
            gender = "";
            tipeuser = "";
            gambar = "";
            LoadUser();
        }

        private void btn_restartcategory_Click(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Font = new Font("Nirmala UI", 10, FontStyle.Regular);
                textBox1.Text = "Search By ID/Username";
                textBox1.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search By ID/Username")
            {
                textBox1.Font = new Font("Nirmala UI", 10, FontStyle.Regular);
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idx = e.RowIndex;
                id = dataGridView1.Rows[idx].Cells[0].Value.ToString();
                username = dataGridView1.Rows[idx].Cells[1].Value.ToString();
                password = semuapassword[idx];
                nama = (dataGridView1.Rows[idx].Cells[3].Value.ToString());
                datebirth = dataGridView1.Rows[idx].Cells[4].Value.ToString();
                gender = dataGridView1.Rows[idx].Cells[5].Value.ToString();
                tipeuser = dataGridView1.Rows[idx].Cells[6].Value.ToString();
                gambar = semuagambar[idx];
            }
            catch
            {
                idx = 0;
            }
        }
    }
}
