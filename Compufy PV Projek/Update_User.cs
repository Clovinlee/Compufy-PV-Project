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
using System.Data.SqlClient;

namespace Compufy_PV_Projek
{
    public partial class Update_User : Form
    {
        public Update_User()
        {
            InitializeComponent();
        }
        public List<string> semuauser;
        public login frm_login;
        public admin_manage_user amu;
        public menu_admin frm_admin;
        public string id;
        public string username;
        public string password;
        public string nama;
        public string datebirth;
        public string gender;
        public string tipeuser;
        bool chckimg = false;
        public string chckgender;
        public string tgl1 = "";
        public string gambar;
        SqlConnection conn;
        string connStr;

        DataSet ds;
        SqlCommand query;

        private void Update_User_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(439, 377);
            this.MaximumSize = new Size(439, 377);
            txtUsername.Text = username;
            textBox1.Text = password;
            txtNama.Text = nama;
            dateTimePicker1.Value = Convert.ToDateTime(datebirth);
            cbGender.Text = gender;

            comboBox1.Text = tipeuser;
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            if (gambar != "-")
            {
                pictureBox1.ImageLocation = Application.StartupPath + "\\profile_picture\\" + gambar;
            }
            
        }
        bool chck = false;
        public string chcktipe;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tgl1 = dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
            if (txtUsername.Text == "" || textBox1.Text == "" || txtNama.Text == "" || cbGender.Text == "" || comboBox1.Text == "")
            {
                chck = true;
            }
            if (cbGender.Text == "Laki-Laki")
            {
                chckgender = "L";
            }
            if (cbGender.Text == "Perempuan")
            {
                chckgender = "P";
            }
            if (comboBox1.Text == "Admin")
            {
                chcktipe = "1";
            }
            if (comboBox1.Text == "Kasir")
            {
                chcktipe = "2";
            }
            if (chckimg == true && chck == false)
                {
                if (semuauser.Contains(txtUsername.Text) && username != txtUsername.Text)
                {
                    MessageBox.Show("User Sudah Ada");
                }
                else
                {
                    try
                    {
                        string query = $"UPDATE [Akun] set username = '{txtUsername.Text}', password = '{textBox1.Text}', nama_user = '{txtNama.Text}', tgl_lahir_user = '{tgl1}', jk_user = '{chckgender}', tipe_user = '{chcktipe}', gambar = '{openFileDialog1.SafeFileName}' WHERE id_user = {id}";
                        frm_login.executeQuery(query);
                        string qu = $"SELECT id_user, username, password, nama_user, tgl_lahir_user, jk_user, tipe_user, isnull(gambar, '-') as gambar FROM [Akun] WHERE username = '{username}' AND password = '{password}' and status_delete = 0";
                        ds = new DataSet();
                        frm_login.executeDataSet(ds, qu, "akun");
                        if (frm_admin.lbl_namauser.Text == ds.Tables["akun"].Rows[0]["nama_user"].ToString())
                        {
                            frm_admin.usergambar = ds.Tables["akun"].Rows[0]["gambar"].ToString();
                        }
                        frm_admin.pl_avatar.Invalidate();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("User Sudah Ada");
                    }
                }
                }
                else if (chckimg == false && chck == false)
                {
                if (semuauser.Contains(txtUsername.Text) && username != txtUsername.Text)
                {
                    MessageBox.Show("User Sudah Ada");
                }
                else
                {
                    try
                    {
                        string query = $"UPDATE [Akun] set username = '{txtUsername.Text}', password = '{textBox1.Text}', nama_user = '{txtNama.Text}', tgl_lahir_user = '{tgl1}', jk_user = '{chckgender}', tipe_user = '{chcktipe}' WHERE id_user = {id}";
                        frm_login.executeQuery(query);
                        frm_admin.pl_avatar.Invalidate();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("User Sudah Ada");
                    }
                }
                }
            else
            {
                MessageBox.Show("Field Kosong");
                chck = false; 
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images (*.PNG;*.JPG)|*.PNG;*.JPG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string directory = "profile_picture\\";
                Directory.CreateDirectory(directory);

                if (!File.Exists(Application.StartupPath + "\\profile_picture\\" + openFileDialog1.SafeFileName))
                {
                    File.Copy(openFileDialog1.FileName, directory + openFileDialog1.SafeFileName, true);
                }

                pictureBox1.ImageLocation = Application.StartupPath + "\\profile_picture\\" + openFileDialog1.SafeFileName;
                chckimg = true;
            }
            else
            {
                
            }

        }

        private void btnFile_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images (*.PNG;*.JPG)|*.PNG;*.JPG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string directory = "profile_picture\\";
                Directory.CreateDirectory(directory);

                if (!File.Exists(Application.StartupPath + "\\profile_picture\\" + openFileDialog1.SafeFileName))
                {
                    File.Copy(openFileDialog1.FileName, directory + openFileDialog1.SafeFileName, true);
                }

                pictureBox1.ImageLocation = Application.StartupPath + "\\profile_picture\\" + openFileDialog1.SafeFileName;
                chckimg = true;
            }
            else
            {
                
            }
        }
    }
}
