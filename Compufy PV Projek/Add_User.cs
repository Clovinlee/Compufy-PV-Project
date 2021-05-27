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
    public partial class Add_User : Form
    {
        public Add_User()
        {
            InitializeComponent();
        }
        public login frm_login;

        bool chck = false;
        public string chckgender;
        public string chcktipe;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
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
            if (chck == false)
            {
                string query = $"INSERT into [Akun] (username, password, nama_user, tgl_lahir_user, jk_user, tipe_user, gambar, status_delete) VALUES('{txtUsername.Text}', '{textBox1.Text}', '{txtNama.Text}', '{dateTimePicker1.Value}', '{chckgender}', '{chcktipe}', '{openFileDialog1.SafeFileName}', '0')";
                frm_login.executeQuery(query);
                this.Close();
            }
            else
            {
                MessageBox.Show("Field Kosong");
            }

        }

        private void Add_User_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(510, 346);
            this.MaximumSize = new Size(510, 346);
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
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
