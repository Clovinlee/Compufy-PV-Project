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
using System.IO;

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
        public Admin_Transaction frm_transaction;
        public string usergambar;
        public string gender;

        Button sub_active;
        public string id_login;

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

            frm_transaction = new Admin_Transaction();
            frm_transaction.TopLevel = false;
            frm_transaction.Dock = DockStyle.Fill;
            frm_transaction.frm_login = frm_login;
            frm_transaction.FormBorderStyle = FormBorderStyle.None;
            frm_transaction.Hide();

            pl_submenu.Controls.Add(frm_stock);
            pl_submenu.Controls.Add(frm_dashboard);
            pl_submenu.Controls.Add(frm_manageuser);
            pl_submenu.Controls.Add(frm_managemember);
            pl_submenu.Controls.Add(frm_transaction);

            this.ActiveControl = btn_menudashboard;
            noGambar = true;

            setToolTip();
            readLogoDirectory();
            
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
                    
                }
                else if(b.Text == "Transactions") 
                {
                    frm_transaction.Show();
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
        bool noGambar;

        private void pl_menulogo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle container = new Rectangle(0, 0, pl_menulogo.Width - 1, pl_menulogo.Height - 1);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            //g.DrawImage(new Bitmap(materials.compufy_0), 0,0,pl_menulogo.Width, pl_menulogo.Height);

            if (noGambar == true)
            {
                g.DrawString("<Logo>", new Font("Arial", 20), Brushes.White, container, format);
            }
        }

        bool logout = false;
        private void link_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?","Logout",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frm_login.Show();
                frm_login.resetLogin();
                //frm_login.history += $"logout\n";
                frm_login.writeHistory();
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

        private void pl_menulogo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images (*.PNG;*.JPG)|*.PNG;*.JPG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string directory = "logo_picture\\";
                Directory.CreateDirectory(directory);

                if (!File.Exists(Application.StartupPath + "\\logo_picture\\" + openFileDialog1.SafeFileName))
                {
                    File.Copy(openFileDialog1.FileName, directory + openFileDialog1.SafeFileName, true);
                }

                Bitmap logo = new Bitmap(Application.StartupPath + "\\logo_picture\\" + openFileDialog1.SafeFileName);
                writeLogoDirectory();

                pl_menulogo.BackgroundImage = logo;
                noGambar = false;
                pl_menulogo.Refresh();
            }
            else
            {
                MessageBox.Show("No File",
                    "No File Choosen",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void setToolTip()
        {
            ToolTip panelToolTip = new ToolTip();
            panelToolTip.ToolTipTitle = "Ganti Logo";
            panelToolTip.UseFading = true;
            panelToolTip.UseAnimation = true;
            panelToolTip.IsBalloon = true;
            panelToolTip.ShowAlways = true;
            panelToolTip.AutoPopDelay = 5000;
            panelToolTip.InitialDelay = 250;
            panelToolTip.ReshowDelay = 500;
            panelToolTip.SetToolTip(pl_menulogo, "Klik untuk ganti logo");
        }

        private void writeLogoDirectory()
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "/dirLogoAdm.txt");
            sw.Write(Application.StartupPath + "\\logo_picture\\" + openFileDialog1.SafeFileName);
            sw.Close();
        }

        StreamReader sr;
        private void readLogoDirectory()
        {
            try
            {
                sr = new StreamReader(Application.StartupPath + "/dirLogoAdm.txt");
                while (!sr.EndOfStream)
                {
                    string directory = sr.ReadLine();
                    Bitmap logo = new Bitmap(directory);
                    pl_menulogo.BackgroundImage = logo;
                }
                noGambar = false;
            }
            catch
            {
                noGambar = true;
            }
            sr.Close();

            if (pl_menulogo.BackgroundImage == null)
            {
                noGambar = true;
            }
        }

        private void pl_avatar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (usergambar == "-" && gender.Trim() == "L")
            {
                Image img = Image.FromFile("profile_picture/profile_sample7.png");
                g.DrawImage(img, 0, 0, 70, 70);
            }
            if (usergambar == "-" && gender == "P")
            {
                Image img = Image.FromFile("profile_picture/profile_sample1.png");
                g.DrawImage(img, 0, 0, 70, 70);
            }
            if (usergambar != "-")
            {
                Image img = Image.FromFile("profile_picture/"+ usergambar);
                g.DrawImage(img, 0, 0, 70, 70);
            }
        }

        private void btn_historyAdd_Click(object sender, EventArgs e)
        {
            FontAwesome.Sharp.IconButton b = (FontAwesome.Sharp.IconButton)sender;
            if(historyState == false)
            {
                frm_login.history += $"mainbutton%{b.Name}%{b.Text}\n";
            }
        }
        public Boolean historyState = false;

        List<FontAwesome.Sharp.IconButton> h_btn = new List<FontAwesome.Sharp.IconButton>();
        //List<Control> h_list = new List<Control>();
        List<string[]> h_list = new List<string[]>();

        public void doHistory(string h)
        {
            historyState = true;
            string[] temp = h.Split('\n');
            for(int i = 1; i < temp.Length; i++)
            {
                string[] h_temp = temp[i].Split('%');
                h_list.Add(h_temp);
            }
            tmr_history.Start();
        }

        public void tmr_history_Tick(object sender, EventArgs e)
        {
            if(h_list.Count > 0)
            {
                if (h_list[0][0] == "mainbutton")
                {
                    FontAwesome.Sharp.IconButton b = (FontAwesome.Sharp.IconButton)pl_leftbar.Controls.Find(h_list[0][1], false)[0];
                    btn_submenu_MouseDown(b, new MouseEventArgs(MouseButtons.Left, 1, b.Location.X + 10, b.Location.Y + 10, 1));
                    btn_submenu_MouseUp(b, new MouseEventArgs(MouseButtons.Left, 1, b.Location.X + 10, b.Location.Y + 10, 1));
                    btn_submenu_Enter(b, new MouseEventArgs(MouseButtons.Left, 1, b.Location.X + 10, b.Location.Y + 10, 1));
                    h_list.RemoveAt(0);
                }
            }
            else
            {
                historyState = false;
                tmr_history.Stop();
            }
        }
    }
}