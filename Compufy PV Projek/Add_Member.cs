﻿using System;
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
    public partial class Add_Member : Form
    {
        public Add_Member()
        {
            InitializeComponent();
        }
        public login frm_login;

        bool chck = false;
        public string chckgender;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNama.Text == "" || textBox1.Text == "" || txtNama.Text == "" || cbGender.Text == "")
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
            if (chck == false)
            {
                string query = $"INSERT into [Member] (nama_member, no_hp_member, birthdate, tgl_daftar, jk_member, alamat_member, status_delete) VALUES('{txtNama.Text}', '{textBox1.Text}', '{dateTimePicker1.Value}', '{dateTimePicker2.Value}', '{chckgender}', '{textBox2.Text}', '0')";
                frm_login.executeQuery(query);
                this.Close();
            }
            else
            {
                MessageBox.Show("Field Kosong");
            }
            
        }

        private void Add_Member_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(448, 304);
            this.MaximumSize = new Size(448, 304);
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
