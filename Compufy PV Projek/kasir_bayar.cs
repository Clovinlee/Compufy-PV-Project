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
            this.MinimumSize = new Size(387, 384);
            this.MaximumSize = new Size(387, 384);
            lbl_total.Text = "Rp "+total.ToString("#,##");
        }

        private void rb_cash_Click(object sender, EventArgs e)
        {
            num_cash.Enabled = true;
            tb_kk1.Enabled = false;
            tb_kk1.Text = "";
            tb_kk2.Enabled = false;
            tb_kk2.Text = "";
            tb_kk3.Enabled = false;
            tb_kk3.Text = "";
            tb_kk4.Enabled = false;
            tb_kk4.Text = "";
        }

        private void rb_kredit_Click(object sender, EventArgs e)
        {
            num_cash.Enabled = false;
            num_cash.ResetText();
            tb_kk1.Enabled = true;
            tb_kk2.Enabled = true;
            tb_kk3.Enabled = true;
            tb_kk4.Enabled = true;
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
            if (num_cash.Value < total)
            {
                MessageBox.Show("Uang yang dibayarkan tidak cukup!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string nokartu = tb_kk1.Text + tb_kk2.Text + tb_kk3.Text + tb_kk4.Text;
                string metode = rb_cash.Checked == true ? "Cash" : "Kredit";
                if(metode == "Kredit" && (nokartu.Length < 16 || !frm_kasir.isAngka(nokartu)))
                {
                    num_cash.ResetText();
                    MessageBox.Show("Invalid input kartu!");
                }
                else
                {
                    frm_kasir.bayar = Convert.ToDecimal(num_cash.Value);
                    frm_kasir.metode = metode;
                    frm_kasir.nokartu = nokartu;
                    this.Close();
                }
            }
        }

        private void kasir_bayar_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_kasir.frm_kasirbayar = null;
        }

        private void tb_kk1_TextChanged(object sender, EventArgs e)
        {
            if(tb_kk1.Text.Length == 4)
            {
                tb_kk2.Focus();
            }
        }

        private void tb_kk2_TextChanged(object sender, EventArgs e)
        {
            if (tb_kk2.Text.Length == 4)
            {
                tb_kk3.Focus();
            }else if(tb_kk2.Text.Length == 0)
            {
                tb_kk1.Focus();
            }
        }

        private void tb_kk3_TextChanged(object sender, EventArgs e)
        {
            if (tb_kk3.Text.Length == 4)
            {
                tb_kk4.Focus();
            }else if(tb_kk3.Text.Length == 0)
            {
                tb_kk2.Focus();
            }
        }

        private void tb_kk4_TextChanged(object sender, EventArgs e)
        {
            if (tb_kk4.Text.Length == 0)
            {
                tb_kk3.Focus();
            }
        }
    }
}
