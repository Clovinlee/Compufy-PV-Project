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
    public partial class menu_kasir : Form
    {
        public menu_kasir()
        {
            InitializeComponent();
        }

        public login frm_login;

        private void menu_kasir_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1008, 639);
            lbl_memberdaftar.Text = "00-00-0000";
            lbl_memberid.Text = "000000";
            lbl_membernama.Text = "Anon";
            gb_detailmember.Enabled = false;
            pl_leftmain.AutoScroll = true;
            pl_leftmain.HorizontalScroll.Enabled = false;
            pl_leftmain.HorizontalScroll.Visible = false;
        }

        private void pl_menulogo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle container = new Rectangle(0, 0, pl_menulogo.Width - 1, pl_menulogo.Height - 1);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            //g.DrawImage(new Bitmap(materials.compufy_0), 0,0,pl_menulogo.Width, pl_menulogo.Height);
            g.DrawString("<Logo>", new Font("Arial", 20), Brushes.White, container, format);
        }

        bool logout = false;
        private void link_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frm_login.Show();
                frm_login.resetLogin();
                login.frm_admin = null;
                logout = true;
                this.Close();
            }
        }

        private void menu_kasir_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logout == false)
            {
                Application.Exit();
            }
        }


        private void tb_inputmember_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_membercheck_Click(btn_membercheck, e);
            }
        }

        private void btn_membercheck_Click(object sender, EventArgs e)
        {
            gb_detailmember.Enabled = true;
            MessageBox.Show("Check Working!");
        }

        private void btn_memberreset_Click(object sender, EventArgs e)
        {
            gb_detailmember.Enabled = false;
            lbl_memberdaftar.Text = "00-00-0000";
            lbl_memberid.Text = "000000";
            lbl_membernama.Text = "Anon";
        }

        int lb_idx = -1;
        private void lb_daftarbarang_DoubleClick(object sender, EventArgs e)
        {
            lb_idx = lb_daftarbarang.SelectedIndex;
            if(lb_idx != -1)
            {

            }
        }
    }
}
