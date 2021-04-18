using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Compufy_PV_Projek
{
    public partial class menu_admin : Form
    {
        public menu_admin()
        {
            InitializeComponent();
            this.Text = "Compufy";
        }

        //CODE BEGIN//

        public login frm_login;

        private void menu_admin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btn_menudashboard;
            this.MinimumSize = new Size(925, 639);

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
            if (MessageBox.Show("Are you sure you want to logout?","Logout",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frm_login.Show();
                frm_login.resetLogin();
                login.frm_admin = null;
                logout = true;
                this.Close();
            }
        }

        private void btn_submenu_Enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.FromArgb(8, 117, 146);
            b.TextImageRelation = TextImageRelation.TextBeforeImage;
            b.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void btn_submenu_Leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.FromArgb(0, 65, 82);
            b.TextImageRelation = TextImageRelation.ImageBeforeText;
            b.ImageAlign = ContentAlignment.MiddleLeft;
        }

        Color b_color;
        private void btn_submenu_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            b_color = b.BackColor;
            b.BackColor = Color.FromArgb(11, 85, 150);
        }

        private void btn_submenu_MouseUp(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = b_color;
        }

        private void menu_admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logout == false)
            {
                Application.Exit();
            }
        }
    }
}