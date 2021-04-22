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
        private void admin_manage_member_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(727, 508);
            frmAdd = new Add_Member();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 11, FontStyle.Bold);
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
            txtID.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            txtNama.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            txtNOHP.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[idx].Cells[3].Value);
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[idx].Cells[4].Value);
            cbGender.Text = dataGridView1.Rows[idx].Cells[5].Value.ToString();
            textBox2.Text = dataGridView1.Rows[idx].Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE [Barang] set nama_member = '{txtNama.Text}', no_hp_member = '{(txtNOHP.Text)}', birthdate = '{dateTimePicker2.Value}', tgl_daftar = '{dateTimePicker1.Value}', jk_member = '{cbGender.SelectedItem.ToString()}', alamat_member = '{textBox2.Text}' WHERE id_member = '{txtID.Text}'";
            frm_login.executeQuery(query);
            LoadBarang();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin mau delete barang ini ?", "Delete Barang", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                string query = $"DELETE [Member] where id_member = '{txtID.Text}'";
                frm_login.executeQuery(query);
                LoadBarang();
            }
        }
    }
}
