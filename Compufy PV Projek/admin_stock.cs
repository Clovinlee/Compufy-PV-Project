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
    public partial class admin_stock : Form
    {
        public admin_stock()
        {
            InitializeComponent();
        }

        add_stock frmAdd;

        private void admin_stock_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(727, 508);
            frmAdd = new add_stock();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 11, FontStyle.Bold);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmAdd.ShowDialog();
        }
    }
}
