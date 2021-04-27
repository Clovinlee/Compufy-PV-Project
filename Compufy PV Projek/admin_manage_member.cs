using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Compufy_PV_Projek
{
    public partial class admin_manage_member : Form
    {
        public admin_manage_member()
        {
            InitializeComponent();
        }
        Add_Member frmAdd;
        public login frm_login;
        Update_Member frmUpdate;
        public string id;
        public string nama;
        public string nohp;
        public string tanggallahir;
        public string tanggaldaftar;
        public string gender;
        public string alamat;
        private void admin_manage_member_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(727, 508);
            frmAdd = new Add_Member();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 11, FontStyle.Bold);
            LoadBarang();
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmAdd.ShowDialog();
            LoadBarang();
        }

        private void LoadBarang()
        {
            dataGridView1.Rows.Clear();

            DataSet ds = new DataSet();
            string query = "SELECT * from Member";
            frm_login.executeDataSet(ds, query, "Member");

            for (int i = 0; i < ds.Tables["Member"].Rows.Count; i++)
            {
                dataGridView1.Rows.Add(ds.Tables["Member"].Rows[i].ItemArray[0], ds.Tables["Member"].Rows[i].ItemArray[1], ds.Tables["Member"].Rows[i].ItemArray[2], ds.Tables["Member"].Rows[i].ItemArray[3], ds.Tables["Member"].Rows[i].ItemArray[4], ds.Tables["Member"].Rows[i].ItemArray[5], ds.Tables["Member"].Rows[i].ItemArray[6]);
            }
        }
        int idx;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
            id = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            nama = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            nohp = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            tanggallahir = Convert.ToString(dataGridView1.Rows[idx].Cells[3].Value);
            tanggaldaftar = Convert.ToString(dataGridView1.Rows[idx].Cells[4].Value);
            gender = dataGridView1.Rows[idx].Cells[5].Value.ToString();
            alamat = dataGridView1.Rows[idx].Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin mau delete Member ini ?", "Delete Member", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                string query = $"DELETE [Member] where id_member = '{id}'";
                frm_login.executeQuery(query);
                LoadBarang();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmAdd.ShowDialog();
            LoadBarang();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            frmUpdate.ShowDialog();
            frmUpdate.id = id;
            frmUpdate.nama = nama;
            frmUpdate.nohp = nohp;
            frmUpdate.tanggallahir = tanggallahir;
            frmUpdate.tanggaldaftar = tanggaldaftar;
            frmUpdate.gender = gender;
            frmUpdate.alamat = alamat;
            LoadBarang();
        }
    }
}
