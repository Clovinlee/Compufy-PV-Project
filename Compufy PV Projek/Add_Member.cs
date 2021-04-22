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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Member_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(510, 290);
            this.MaximumSize = new Size(510, 290);
        }
    }
}
