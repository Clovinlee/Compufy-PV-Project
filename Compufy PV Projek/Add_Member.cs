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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = $"INSERT into [Member] (nama_member, no_hp_member, birthdate, tgl_daftar, jk_member, alamat_member) VALUES('{txtNama.Text}', '{textBox1.Text}', '{dateTimePicker1.Value}', '{dateTimePicker2.Value}', '{cbGender.SelectedItem.ToString()}', '{textBox2.Text}')";
            frm_login.executeQuery(query);
            this.Close();
            
        }

        private void Add_Member_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(510, 304);
            this.MaximumSize = new Size(510, 304);
        }
    }
}
