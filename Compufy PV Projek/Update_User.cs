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
    public partial class Update_User : Form
    {
        public Update_User()
        {
            InitializeComponent();
        }
        public login frm_login;
        public admin_manage_user amu;
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
                    string query = $"UPDATE [Akun] set username = '{txtUsername.Text}', password = '{textBox1.Text}', nama_user = '{txtNama.Text}', tgl_lahir_user = '{tgl1}', jk_user = '{chckgender}', tipe_user = '{chcktipe}', gambar = '{openFileDialog1.SafeFileName}' WHERE id_user = {id}";
                    frm_login.executeQuery(query);
                    this.Close();
                }
                else if (chckimg == false && chck == false)
                {
                    string query = $"UPDATE [Akun] set username = '{txtUsername.Text}', password = '{textBox1.Text}', nama_user = '{txtNama.Text}', tgl_lahir_user = '{tgl1}', jk_user = '{chckgender}', tipe_user = '{chcktipe}' WHERE id_user = {id}";
                    frm_login.executeQuery(query);
                    this.Close();
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
                MessageBox.Show("No File",
                    "No File Choosen",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
                MessageBox.Show("No File",
                    "No File Choosen",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
