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
    public partial class menu_superadmin : Form
    {
        public menu_superadmin()
        {
            InitializeComponent();
            this.MinimumSize = new Size(925, 544);
        }
        Button sub_active;

        private void menu_superadmin_Load(object sender, EventArgs e)
        {
            sub_active = btn_manageuser;
            this.ActiveControl = btn_menudashboard;
        }

        public super_dashboard frm_superdash;
        public super_manage frm_supermanage;


        private void btn_submenu_Enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b != sub_active)
            {
                sub_active.BackColor = Color.FromArgb(0, 65, 82);
                sub_active.TextImageRelation = TextImageRelation.ImageBeforeText;
                sub_active.ImageAlign = ContentAlignment.MiddleLeft;

                b.BackColor = Color.FromArgb(8, 117, 146);
                b.TextImageRelation = TextImageRelation.TextBeforeImage;
                b.ImageAlign = ContentAlignment.MiddleRight;
                pl_submenu.Controls.Clear();

                if (b.Text == "Dashboard")
                {
                    if (frm_superdash == null)
                    {
                        Console.WriteLine("ON");
                        frm_superdash = new super_dashboard();
                    }
                    frm_superdash.TopLevel = false;
                    frm_superdash.Dock = DockStyle.Fill;
                    frm_superdash.frm_super = this;
                    pl_submenu.Controls.Add(frm_superdash);
                    frm_superdash.Show();
                }
                else if (b.Text == "Manage User")
                {
                    if (frm_supermanage == null)
                    {
                        frm_supermanage = new super_manage();
                    }
                    frm_supermanage.TopLevel = false;
                    pl_submenu.Controls.Add(frm_supermanage);
                    frm_supermanage.Dock = DockStyle.Fill;
                    frm_supermanage.Show();
                }
                sub_active = b;
            }
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

        public login frm_login;
        bool logout = false;

        private void link_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    frm_login.Show();
            //    login.frm_super = null;
            //    if(frm_superdash != null)
            //    {
            //        frm_superdash.Close();
            //        frm_superdash = null;
            //    }
            //    if(frm_supermanage != null)
            //    {
            //        frm_supermanage.Close();
            //        frm_supermanage = null;
            //    }
            //    logout = true;
            //    this.Close();
            //}
        }

        private void menu_superadmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logout == false)
            {
                Application.Exit();
            }
        }
    }
}
