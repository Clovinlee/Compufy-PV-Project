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
        public admin_stock frm_stock;
        public admin_dashboard frm_dashboard;
        public admin_manage_user frm_manageuser;
        public admin_manage_member frm_managemember;

        Button sub_active;
        
        private void menu_admin_Load(object sender, EventArgs e)
        {
            sub_active = btn_menusales;
            this.MinimumSize = new Size(925, 639);

            //CREATE FORM
            frm_stock = new admin_stock();
            frm_stock.TopLevel = false;
            frm_stock.Dock = DockStyle.Fill;
            frm_stock.frm_login = frm_login;
            frm_stock.FormBorderStyle = FormBorderStyle.None;
            frm_stock.Hide();

            frm_dashboard = new admin_dashboard();
            frm_dashboard.TopLevel = false;
            frm_dashboard.Dock = DockStyle.Fill;
            frm_dashboard.frm_login = frm_login;
            frm_dashboard.FormBorderStyle = FormBorderStyle.None;
            frm_dashboard.Hide();

            frm_manageuser = new admin_manage_user();
            frm_manageuser.TopLevel = false;
            frm_manageuser.Dock = DockStyle.Fill;
            frm_manageuser.frm_login = frm_login;
            frm_manageuser.FormBorderStyle = FormBorderStyle.None;
            frm_manageuser.Hide();

            frm_managemember = new admin_manage_member();
            frm_managemember.TopLevel = false;
            frm_managemember.Dock = DockStyle.Fill;
            frm_managemember.frm_login = frm_login;
            frm_managemember.FormBorderStyle = FormBorderStyle.None;
            frm_managemember.Hide();

            pl_submenu.Controls.Add(frm_stock);
            pl_submenu.Controls.Add(frm_dashboard);
            pl_submenu.Controls.Add(frm_manageuser);
            pl_submenu.Controls.Add(frm_managemember);

            this.ActiveControl = btn_menudashboard;
        }

        private void btn_submenu_Enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            foreach(Form f in pl_submenu.Controls)
            {
                f.Hide();
            }
            if (b != sub_active)
            {
                sub_active.BackColor = Color.FromArgb(0, 65, 82);
                sub_active.TextImageRelation = TextImageRelation.ImageBeforeText;
                sub_active.ImageAlign = ContentAlignment.MiddleLeft;

                b.BackColor = Color.FromArgb(8, 117, 146);
                b.TextImageRelation = TextImageRelation.TextBeforeImage;
                b.ImageAlign = ContentAlignment.MiddleRight;

                if (b.Text == "Dashboard")
                {
                    frm_dashboard.Show();
                }
                else if (b.Text == "Sales")
                {
                    
                }else if(b.Text == "Transactions") 
                { 

                }
                else if(b.Text == "Stocks")
                {
                    frm_stock.Show();
                }
                else if(b.Text == "Manage User")
                {
                    frm_manageuser.Show();
                }
                else if (b.Text == "Manage Member")
                {
                    frm_managemember.Show();
                }
                sub_active = b;
            }
        }

        private void btn_submenu_MouseUp(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = b_color;
        }

        private void btn_submenu_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            b_color = b.BackColor;
            b.BackColor = Color.FromArgb(11, 85, 150);
        }

        Color b_color;

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

        private void menu_admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logout == false)
            {
                Application.Exit();
            }
        }
    }
}