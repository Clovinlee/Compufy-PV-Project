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
    public partial class admin_dashboard : Form
    {
        public admin_dashboard()
        {
            InitializeComponent();
        }

        public login frm_login;
        string member_terbaru;

        private void admin_dashboard_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(727, 508);
            DataSet ds = new DataSet();
            string query = "SELECT * from Member";
            frm_login.executeDataSet(ds, query, "Member");

            label1.Text = ds.Tables["Member"].Rows.Count.ToString() + " Member";
            for (int i = 0; i < ds.Tables["Member"].Rows.Count; i++)
            {
                member_terbaru = ds.Tables["Member"].Rows[i].ItemArray[1].ToString();
            }
            label4.Text = member_terbaru;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
