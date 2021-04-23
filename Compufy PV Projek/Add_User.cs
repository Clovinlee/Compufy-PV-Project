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
    public partial class Add_User : Form
    {
        public Add_User()
        {
            InitializeComponent();
        }
        public login frm_login;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = $"INSERT into [Akun] (username, password, nama_user, tgl_lahir_user, jk_user, tipe_user) VALUES('{txtUsername.Text}', '{textBox1.Text}', '{txtNama.Text}', '{dateTimePicker1.Value}', '{cbGender.SelectedItem.ToString()}', '{comboBox1.SelectedItem.ToString()}')";
            frm_login.executeQuery(query);
            this.Close();
        }

        private void Add_User_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(510, 304);
            this.MaximumSize = new Size(510, 304);
        }
    }
}
