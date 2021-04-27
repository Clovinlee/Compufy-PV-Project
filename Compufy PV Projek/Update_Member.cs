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

        private void Update_Member_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(510, 304);
            this.MaximumSize = new Size(510, 304);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE [Member] set nama_member = '{nama}', no_hp_member = '{(nohp)}', birthdate = '{tanggallahir}', tgl_daftar = '{tanggaldaftar}', jk_member = '{gender}', alamat_member = '{alamat}' WHERE id_member = '{id}'";
            frm_login.executeQuery(query);
            this.Close();
        }
    }
}
