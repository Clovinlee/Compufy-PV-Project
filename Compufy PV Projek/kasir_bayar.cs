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
    public partial class kasir_bayar : Form
    {
        public kasir_bayar()
        {
            InitializeComponent();
        }

        public decimal total;
        public menu_kasir frm_kasir;

        private void kasir_bayar_Load(object sender, EventArgs e)
        {
            num_cash.Controls[0].Visible = false;
            num_cash.ResetText();
            this.MinimumSize = new Size(387, 333);
            this.MaximumSize = new Size(387, 333);
            lbl_total.Text = "Rp "+total.ToString("#,##");
        }

        private void rb_cash_Click(object sender, EventArgs e)
        {
            num_cash.Enabled = true;
        }

        private void rb_kredit_Click(object sender, EventArgs e)
        {
            num_cash.Enabled = false;
            num_cash.ResetText();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            if(rb_kredit.Checked == true)
            {
                num_cash.Value = total;
            }
            if(num_cash.Value < total)
            {
                MessageBox.Show("Uang yang dibayarkan tidak cukup!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frm_kasir.bayar = num_cash.Value;
                string metode = rb_cash.Checked == true ? "Cash" : "Kredit";
                frm_kasir.metode = metode;
                this.Close();
            }
        }

        private void kasir_bayar_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_kasir.frm_kasirbayar = null;
        }
    }
}
