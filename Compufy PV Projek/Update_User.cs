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

        private void Update_User_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(510, 304);
            this.MaximumSize = new Size(510, 304);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE [Akun] set username = '{username}', password = '{(password)}', nama_user = '{nama}', tgl_lahir_user = '{datebirth}', jk_user = '{gender}', tipe_user = '{tipeuser}' WHERE id_user = '{id}'";
            frm_login.executeQuery(query);
            this.Close();
        }
    }
}
