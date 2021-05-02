using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Compufy_PV_Projek
{
    public partial class Admin_Transaction : Form
    {
        public Admin_Transaction()
        {
            InitializeComponent();
        }

        public login frm_login;

        private void Admin_Transaction_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(727, 508);
            comboBox1.SelectedIndex = -1;
            LoadTrans();
        }

        DataSet ds;
        private void LoadTrans()
        {
            flowLayoutPanel1.Controls.Clear();

            ds = new DataSet();
            string query = "SELECT h.id_trans, h.tgl_trans, a.nama_user, isnull(m.nama_member, '-'), h.metode_trans, h.total_trans, h.diskon from h_transaksi h left join akun a on h.id_user = a.id_user left join member m on h.id_member = m.id_member";
            frm_login.executeDataSet(ds, query, "Trans");

            for (int i = 0; i < ds.Tables["Trans"].Rows.Count; i++)
            {
                AddPanel(i);
            }
        }

        private void AddPanel(int idx)
        {
            Panel panelTrans = new Panel();
            panelTrans.BackColor = SystemColors.Info;
            panelTrans.Size = new Size(flowLayoutPanel1.Width - 40, 130);
            panelTrans.Location = new Point(0, 0);

            Label id = new Label();
            id.Font = new Font("Nirmala UI", 14, FontStyle.Bold);
            id.Text = "Id Transaksi : " + Convert.ToString(ds.Tables["Trans"].Rows[idx].ItemArray[0]);
            id.Location = new Point(19, 10);
            id.AutoSize = true;
            panelTrans.Controls.Add(id);

            Label tanggal = new Label();
            tanggal.Font = new Font("Nirmala UI", 11);
            tanggal.Text = "Tanggal : " + Convert.ToString(ds.Tables["Trans"].Rows[idx].ItemArray[1]);
            tanggal.Location = new Point(20, 45);
            tanggal.AutoSize = true;
            panelTrans.Controls.Add(tanggal);

            Label kasir = new Label();
            kasir.Font = new Font("Nirmala UI", 11);
            kasir.Text = "Kasir : " + Convert.ToString(ds.Tables["Trans"].Rows[idx].ItemArray[2]);
            kasir.Location = new Point(20, 70);
            kasir.AutoSize = true;
            panelTrans.Controls.Add(kasir);

            Label member = new Label();
            member.Font = new Font("Nirmala UI", 11);
            member.Text = "Member : " + Convert.ToString(ds.Tables["Trans"].Rows[idx].ItemArray[3]);
            member.Location = new Point(20, 95);
            member.AutoSize = true;
            panelTrans.Controls.Add(member);

            Label metode = new Label();
            metode.Font = new Font("Nirmala UI", 14, FontStyle.Bold);
            metode.Text = Convert.ToString(ds.Tables["Trans"].Rows[idx].ItemArray[4]);
            metode.Location = new Point(flowLayoutPanel1.Width - 248, 45);
            metode.AutoSize = true;
            metode.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            panelTrans.Controls.Add(metode);

            Label total = new Label();
            total.Font = new Font("Nirmala UI", 11);
            total.Text = "Total : " + Convert.ToInt32(ds.Tables["Trans"].Rows[idx].ItemArray[5]).ToString("C", new CultureInfo("id-ID"));
            total.Location = new Point(flowLayoutPanel1.Width - 248, 75);
            total.AutoSize = true;
            total.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            panelTrans.Controls.Add(total);

            Label diskon = new Label();
            diskon.Font = new Font("Nirmala UI", 11);
            diskon.Text = "Diskon : " + Convert.ToInt32(ds.Tables["Trans"].Rows[idx].ItemArray[6]).ToString("C", new CultureInfo("id-ID"));
            diskon.Location = new Point(flowLayoutPanel1.Width - 248, 100);
            diskon.AutoSize = true;
            diskon.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            panelTrans.Controls.Add(diskon);

            FontAwesome.Sharp.IconButton detail = new FontAwesome.Sharp.IconButton();
            detail.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
            detail.Text = "Detail";
            detail.Size = new Size(180, 37);
            detail.Location = new Point(flowLayoutPanel1.Width - 243, 8);
            detail.ForeColor = Color.White;
            detail.BackColor = Color.Black;
            detail.FlatStyle = FlatStyle.Flat;
            detail.IconChar = FontAwesome.Sharp.IconChar.List;
            detail.IconColor = Color.White;
            detail.IconSize = 32;
            detail.TextImageRelation = TextImageRelation.ImageBeforeText;
            detail.ImageAlign = ContentAlignment.MiddleLeft;
            detail.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            panelTrans.Controls.Add(detail);

            flowLayoutPanel1.Controls.Add(panelTrans);
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control p in flowLayoutPanel1.Controls)
            {
                if (p is Panel)
                {
                    p.Width = flowLayoutPanel1.Width - 40;
                }
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search By ID")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search By ID";
                txtSearch.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            if (comboBox1.SelectedIndex != -1)
            {
                ds = new DataSet();
                string query = $"SELECT h.id_trans, h.tgl_trans, a.nama_user, isnull(m.nama_member, '-'), h.metode_trans, h.total_trans, h.diskon from h_transaksi h left join akun a on h.id_user = a.id_user left join member m on h.id_member = m.id_member where h.id_trans = '{txtSearch.Text}' and h.metode_trans = '{comboBox1.Text}'";
                frm_login.executeDataSet(ds, query, "Trans");
            }
            else
            {
                ds = new DataSet();
                string query = $"SELECT h.id_trans, h.tgl_trans, a.nama_user, isnull(m.nama_member, '-'), h.metode_trans, h.total_trans, h.diskon from h_transaksi h left join akun a on h.id_user = a.id_user left join member m on h.id_member = m.id_member where h.id_trans = '{txtSearch.Text}'";
                frm_login.executeDataSet(ds, query, "Trans");
            }

            for (int i = 0; i < ds.Tables["Trans"].Rows.Count; i++)
            {
                AddPanel(i);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            ds = new DataSet();
            string query = $"SELECT h.id_trans, h.tgl_trans, a.nama_user, isnull(m.nama_member, '-'), h.metode_trans, h.total_trans, h.diskon from h_transaksi h left join akun a on h.id_user = a.id_user left join member m on h.id_member = m.id_member where h.metode_trans = '{comboBox1.Text}'";
            frm_login.executeDataSet(ds, query, "Trans");

            for (int i = 0; i < ds.Tables["Trans"].Rows.Count; i++)
            {
                AddPanel(i);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            txtSearch.Text = "Search By ID";
            txtSearch.ForeColor = SystemColors.ScrollBar;
            LoadTrans();
        }
    }
}
