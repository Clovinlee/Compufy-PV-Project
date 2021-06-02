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
    public partial class Add_Member : Form
    {
        public Add_Member()
        {
            InitializeComponent();
        }
        public login frm_login;

        bool chck = false;
        public string chckgender;
        public string tgl1 = "";
        public string tgl2 = "";
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            tgl1 = dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
            tgl2 = dateTimePicker2.Value.Month.ToString() + "/" + dateTimePicker2.Value.Day.ToString() + "/" + dateTimePicker2.Value.Year.ToString();
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
                if (checkNumber(textBox1.Text) == true)
                {
                    string query = $"INSERT into [Member] (nama_member, no_hp_member, birthdate, tgl_daftar, jk_member, alamat_member, status_delete) VALUES('{txtNama.Text}', '{textBox1.Text}', '{tgl1}', '{tgl2}', '{chckgender}', '{textBox2.Text}', '0')";
                    frm_login.executeQuery(query);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No HP Harus Angka");
                }
            }
            else
            {
                MessageBox.Show("Field Kosong");
                chck = false;
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
        private void Add_Member_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(448, 304);
            this.MaximumSize = new Size(448, 304);
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;

        }
    }
}
