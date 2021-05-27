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
    public partial class kasir_addmember : Form
    {
        public kasir_addmember()
        {
            InitializeComponent();
        }

        public login frm_login;
        public menu_kasir frm_kasir;
        DataSet ds_member;

        private void kasir_addmember_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(391, 352);
            this.MaximumSize = new Size(391, 441);
            ds_member = new DataSet();
            string q = $"SELECT * FROM [Member]";
            frm_login.executeDataSet(ds_member, q, "Member");
            if(id != -1)
            {
                for(int x = 0;x < ds_member.Tables[0].Rows.Count; x++)
                {
                    if(ds_member.Tables[0].Rows[x][0].ToString() == id.ToString())
                    {
                        tb_nama.Text = ds_member.Tables[0].Rows[x][1].ToString();
                        tb_birthdate.Text = ds_member.Tables[0].Rows[x][3].ToString();
                        if (ds_member.Tables[0].Rows[x][5].ToString() == "l")
                        {
                            rb_pria.Checked = true;
                        }
                        else
                        {
                            rb_wanita.Checked = true;
                        }
                    }
                }
                
            }
        }

        public int id;
        int temp_id = -1;
        private void btn_checkmember_Click(object sender, EventArgs e)
        {
            bool found = false;
            if(tb_id.Text != "")
            {
                foreach (DataRow r in ds_member.Tables[0].Rows)
                {
                    if (r[0].ToString() == tb_id.Text && r[7].ToString() == "0")
                    {
                        temp_id = Convert.ToInt32(r[0]);
                        tb_nama.Text = r[1].ToString();
                        tb_birthdate.Text = Convert.ToDateTime(r[3]).ToString("dd-MM-yyyy");
                        if (r[5].ToString() == "L")
                        {
                            rb_pria.Checked = true;
                        }
                        else
                        {
                            rb_wanita.Checked = true;
                        }
                        btn_tambahmember.Enabled = true;
                        found = true;
                    }
                }
                if (found == false)
                {
                    MessageBox.Show($"Member dengan ID {tb_id.Text} tidak ditemukan!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"Field Kosong!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Yakin reset member?","Reset Member",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tb_birthdate.Text = "";
                tb_id.Text = "";
                tb_nama.Text = "";
                id = -1;
                temp_id = -1;
                btn_tambahmember.Enabled = false;
                frm_kasir.id_member = -1;
                frm_kasir.nama_member = "";
                frm_kasir.sumHarga();
                frm_kasir.cb_member.Checked = false;
            }
        }

        private void btn_tambahmember_Click(object sender, EventArgs e)
        {
            id = temp_id;
            frm_kasir.id_member = id;
            frm_kasir.cb_member.Checked = true;
            frm_kasir.nama_member = tb_nama.Text;
            frm_kasir.sumHarga();
            MessageBox.Show("Berhasil input member!");
            this.Close();
        }

        private void kasir_addmember_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_kasir.frm_addmember = null;
        }
    }
}
