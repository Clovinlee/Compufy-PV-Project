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

        public login()
        {
            InitializeComponent();
            this.Text = "Compufy";
            this.MinimumSize = new Size(390, 610);
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
            connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Application.StartupPath+@"\data.mdf;Integrated Security=True;Connect Timeout=30";
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

        public void executeQuery(string q)
        {
            conn.Open();
            query = new SqlCommand(q, conn);
            query.ExecuteNonQuery();
            conn.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string qu = $"SELECT * FROM [User] WHERE username = '{tb_username.Text}' AND password = '{tb_password.Text}';";
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
                if (tipe == 1)
                {
                    if (frm_admin == null)
                    {
                        frm_admin = new menu_admin();
                    }
                    frm_admin.lbl_namauser.Text = ds.Tables["akun"].Rows[0]["username"].ToString();
                    frm_admin.lbl_jabatanuser.Text = role;

                    frm_admin.frm_login = this;
                    frm_admin.Show();
                }
                else if (tipe == 2)
                {
                    if (frm_kasir == null)
                    {
                        frm_kasir = new menu_kasir();
                    }
                    frm_kasir.lbl_namauser.Text = ds.Tables["akun"].Rows[0]["username"].ToString();
                    frm_admin.lbl_jabatanuser.Text = role;

                    frm_kasir.frm_login = frm_login;
                    frm_kasir.Show();

                    }
                this.Hide();
            }
        }
    }
}