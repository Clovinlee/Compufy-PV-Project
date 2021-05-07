using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Compufy_PV_Projek
{
    public partial class menu_history : Form
    {
        public menu_history()
        {
            InitializeComponent();
        }
        public login frm_login;
        
        Boolean loop = false;
        private void clb_history_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (loop == false)
            {
                loop = true;
                for(int i = 0;i < clb_history.Items.Count; i++)
                {
                    if(i <= e.Index)
                    {
                        clb_history.SetItemChecked(i, true);
                    }
                    else
                    {
                        clb_history.SetItemChecked(i, false);
                    }
                }
                loop = false;
                step = e.Index;
            }
        }

        private void menu_history_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_login.frm_history = null;
        }
        
        private void btn_loadhistory_Click(object sender, EventArgs e)
        {
            if(step != -1)
            {
                int ctr = 0;
                StreamReader reader = new StreamReader(Application.StartupPath + @"\history.txt");
                while (!reader.EndOfStream)
                {
                    if(ctr <= step)
                    {
                        frm_login.history += reader.ReadLine() + "\n";
                        ctr++;
                    }
                    else
                    {
                        reader.ReadLine();
                    }
                }
            }
            this.Close();
        }

        int step = -1;
        private void menu_history_Load(object sender, EventArgs e)
        {
            clb_history.Items.Clear();
            StreamReader reader = new StreamReader(Application.StartupPath + @"\history.txt");
            string username = "";
            string password = "";
            string role = "";
            while (!reader.EndOfStream)
            {
                string[] temp = reader.ReadLine().Split('%');
                if (temp[0] == "login")
                {
                    clb_history.Items.Add($"Login | Username : {temp[1]} | Password : {temp[2]} | Role : {temp[3]}");
                    username = temp[1];
                    password = temp[2];
                    role = temp[3];
                }
                else if (temp[0] == "mainbutton" || temp[0] == "button")
                {
                    clb_history.Items.Add($"Button | Button : {temp[2]}");
                }
                else if(temp[0] == "product")
                {
                    clb_history.Items.Add($"Add Checkout | Product : {temp[2]}");
                }
                else if(temp[0] == "logout")
                {
                    clb_history.Items.Add($"Logout | Username : {username} | Password : {password} | Role : {role}");
                }
            }
            reader.Close();
            this.MinimumSize = new Size(297, 496);
        }
    }
}
