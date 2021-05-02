﻿using System;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = $"INSERT into [Akun] (username, password, nama_user, tgl_lahir_user, jk_user, tipe_user, gambar) VALUES('{txtUsername.Text}', '{textBox1.Text}', '{txtNama.Text}', '{dateTimePicker1.Value}', '{cbGender.SelectedItem.ToString()}', '{comboBox1.SelectedItem.ToString()}', '{openFileDialog1.SafeFileName}')";
            frm_login.executeQuery(query);
            this.Close();
        }

        private void Add_User_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(510, 346);
            this.MaximumSize = new Size(510, 346);
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
