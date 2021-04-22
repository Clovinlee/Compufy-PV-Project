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
    public partial class kasir_registermember : Form
    {
        public kasir_registermember()
        {
            InitializeComponent();
        }

        public menu_kasir frm_kasir;
        public login frm_login;

        private void kasir_addmember_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(391, 465);
            this.MinimumSize = new Size(391, 360);
        }

        private void kasir_addmember_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_kasir.frm_registermember = null;
        }

        public Boolean isAngka(string exp)
        {
            foreach(char x in exp)
            {
                if (!Char.IsDigit(x))
                {
                    return false;
                }
            }
            return true;
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            if(tb_nama.Text == "" || tb_nohp.Text == "" || tb_tempattinggal.Text == "")
            {
                MessageBox.Show("Ada field kosong!", "Error!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (isAngka(tb_nohp.Text))
                {
                    string jenis_kelamin = "l";
                    if (rb_wanita.Checked == true)
                    {
                        jenis_kelamin = "p";
                    }
                    string q = $"INSERT INTO [Member] VALUES('{tb_nama.Text}','{tb_nohp.Text}',CONVERT(datetime,'{dt_birthdate.Value}',103),CONVERT(datetime,'{System.DateTime.Now}',103),'{jenis_kelamin}','{tb_tempattinggal.Text}')";
                    frm_login.executeQuery(q);
                    MessageBox.Show("Berhasil Menambahkan Member!");
                    frm_kasir.frm_registermember = null;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Field No Telp harus berupa angka!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
