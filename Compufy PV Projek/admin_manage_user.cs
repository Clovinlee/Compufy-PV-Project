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
    public partial class admin_manage_user : Form
    {
        public admin_manage_user()
        {
            InitializeComponent();
        }
        Add_User frmAdd;
        public login frm_login;
        private void admin_manage_user_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(727, 508);
            frmAdd = new Add_User();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 11, FontStyle.Bold);
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmAdd.ShowDialog();
        }
    }
}
