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
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.IO;

namespace Compufy_PV_Projek
{
    public partial class login : Form
    {

        //LIST FORM(s)
        public static login frm_login;
        public static menu_admin frm_admin;
        //public static menu_superadmin frm_super;
        public static menu_kasir frm_kasir;
        //
        public menu_history frm_history;

        public login()
        {
            InitializeComponent();
            this.Text = "Compufy";
            this.MinimumSize = new Size(390, 640);
            frm_login = this;
        }

        private void tb_input_Focus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(tb.Text == tb.Tag.ToString())
            {
                tb.Text = "";
            }
        }

        private void tb_input_FocusLeave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(tb.Text == "")
            {
                tb.Text = tb.Tag.ToString();
            }
        }

        Random rnd = new Random();

        public void resetLogin()
        {
            tb_password.Text = tb_password.Tag.ToString();
            tb_username.Text = tb_username.Tag.ToString();
            pb_anon.Image = new Bitmap(Image.FromFile($"profile_sample{rnd.Next(1, 10)}.png"), pb_anon.Width - 1, pb_anon.Height - 1);
        }

        private void login_Load(object sender, EventArgs e)
        {
            resetLogin();
            connStr = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = " + Application.StartupPath + "\\DB_Compufy.mdf; Integrated Security = True; Connect Timeout = 30";
            conn = new SqlConnection(connStr);
        }

        SqlConnection conn;
        string connStr;

        DataSet ds;
        SqlCommand query;
        //SqlDataReader reader;

        public void executeDataSet(DataSet ds,string query, string namaTabel)
        {
            conn.Open();
            SqlCommand q = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(q);
            da.Fill(ds, namaTabel);
            conn.Close();
        }

        public int execScalar(string q)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(q, conn);
            int r = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return r;
        }

        public void executeQuery(string q)
        {
            conn.Open();
            query = new SqlCommand(q, conn);
            query.ExecuteNonQuery();
            conn.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string qu = $"SELECT id_user, username, password, nama_user, tgl_lahir_user, jk_user, tipe_user, isnull(gambar, '-') as gambar FROM [Akun] WHERE username = '{tb_username.Text}' AND password = '{tb_password.Text}';";
            ds = new DataSet();
            executeDataSet(ds, qu, "akun");

            if (ds.Tables["akun"].Rows.Count == 0)
            {
                MessageBox.Show("Invalid Username / Password!");
            }
            else
            {
                //MessageBox.Show($"Welcome, {ds.Tables["akun"].Rows[0]["username"]}\nPassword : {ds.Tables["akun"].Rows[0]["password"]}");
                int tipe = Convert.ToInt16(ds.Tables["akun"].Rows[0]["tipe_user"]);
                string role = "";
                if (tipe == 1)
                {
                    role = "Administrator";
                }
                else if (tipe == 2)
                {
                    role = "Kasir";
                }
                if(history == "")
                {
                    history += $"login%{tb_username.Text}%{tb_password.Text}%{role}\n";
                }
                if (tipe == 1)
                {
                    if (frm_admin == null)
                    {
                        frm_admin = new menu_admin();
                    }
                    frm_admin.lbl_namauser.Text = ds.Tables["akun"].Rows[0]["nama_user"].ToString();
                    frm_admin.lbl_jabatanuser.Text = role;
                    frm_admin.usergambar = ds.Tables["akun"].Rows[0]["gambar"].ToString();
                    frm_admin.gender = ds.Tables["akun"].Rows[0]["jk_user"].ToString();
                    


                    frm_admin.frm_login = this;
                    frm_admin.id_login = ds.Tables["akun"].Rows[0]["id_user"].ToString();
                    frm_admin.Show();
                }
                else if (tipe == 2)
                {
                    if (frm_kasir == null)
                    {
                        frm_kasir = new menu_kasir();
                    }
                    frm_kasir.lbl_namauser.Text = ds.Tables["akun"].Rows[0]["nama_user"].ToString();
                    frm_kasir.lbl_jabatanuser.Text = role;
                    frm_kasir.usergambar = ds.Tables["akun"].Rows[0]["gambar"].ToString();
                    frm_kasir.gender = ds.Tables["akun"].Rows[0]["jk_user"].ToString();

                    frm_kasir.frm_login = frm_login;
                    frm_kasir.id_login = ds.Tables["akun"].Rows[0]["id_user"].ToString();
                    frm_kasir.Show();

                    }
                this.Hide();
            }
        }

        public string history = "";

        private void btn_history_Click(object sender, EventArgs e)
        {
            if(frm_history == null)
            {
                frm_history = new menu_history();
            }
            frm_history.frm_login = this;
            frm_history.ShowDialog();
            string[] h_login = history.Split('\n')[0].Split('%');
            
            if(h_login[0] != "")
            {
                tb_username.Text = h_login[1];
                tb_password.Text = h_login[2];
                btn_login_Click(btn_login, e);
                if(h_login[3] == "Administrator")
                {
                    frm_admin.doHistory(history);
                }
                else if(h_login[3] == "Kasir")
                {
                    frm_kasir.doHistory(history);
                }
            }
        }

        public void writeHistory()
        {
            StreamWriter writer = new StreamWriter(Application.StartupPath + @"\history.txt");
            writer.Write(history);
            writer.Close();
            history = "";
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}