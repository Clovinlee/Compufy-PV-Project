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
    public partial class Update_Member : Form
    {
        public Update_Member()
        {
            InitializeComponent();
        }
        public login frm_login;
        public admin_manage_member amm;
        public string id;
        public string nama;
        public string nohp;
        public string tanggallahir;
        public string tanggaldaftar;
        public string gender;
        public string alamat;
        public string chckgender;

        private void Update_Member_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(460, 304);
            this.MaximumSize = new Size(460, 304);
            txtNama.Text = nama;
            textBox1.Text = nohp;
            dateTimePicker1.Value = Convert.ToDateTime(tanggallahir);
            dateTimePicker2.Value = Convert.ToDateTime(tanggaldaftar);
            textBox2.Text = alamat;
            cbGender.Text = gender;
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        bool chck = false;
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
                string query = $"UPDATE [Member] set nama_member = '{txtNama.Text}', no_hp_member = '{(textBox1.Text)}', birthdate = '{dateTimePicker1.Value}', tgl_daftar = '{dateTimePicker2.Value}', jk_member = '{chckgender}', alamat_member = '{textBox2.Text}' WHERE id_member = {id}";
                frm_login.executeQuery(query);
                this.Close();
            }
            else
            {
                MessageBox.Show("Field Kosong");
            }

        }

    }
}
