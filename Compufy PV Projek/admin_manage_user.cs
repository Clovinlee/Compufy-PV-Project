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
    public partial class admin_manage_user : Form
    {
        public admin_manage_user()
        {
            InitializeComponent();
        }
        Add_User frmAdd;
        public login frm_login;
        private void admin_manage_user_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(727, 508);
            frmAdd = new Add_User();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 11, FontStyle.Bold);
            LoadBarang();
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmAdd.ShowDialog();
        }

        private void LoadBarang()
        {
            dataGridView1.Rows.Clear();

            DataSet ds = new DataSet();
            string query = "SELECT * from Akun";
            frm_login.executeDataSet(ds, query, "Akun");

            for (int i = 0; i < ds.Tables["Akun"].Rows.Count; i++)
            {
                dataGridView1.Rows.Add(ds.Tables["Akun"].Rows[i].ItemArray[0], ds.Tables["Akun"].Rows[i].ItemArray[1], ds.Tables["Akun"].Rows[i].ItemArray[2], ds.Tables["Akun"].Rows[i].ItemArray[3], ds.Tables["Akun"].Rows[i].ItemArray[4], ds.Tables["Akun"].Rows[i].ItemArray[5], ds.Tables["Akun"].Rows[i].ItemArray[6]);
            }
        }
        int idx;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
            txtID.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            txtUsername.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            textBox2.Text = (dataGridView1.Rows[idx].Cells[3].Value.ToString());
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[idx].Cells[4].Value);
            cbGender.Text = dataGridView1.Rows[idx].Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[idx].Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE [Akun] set username = '{txtUsername}', passsword = '{(txtPassword.Text)}', nama_user = '{textBox2.Text}', tgl_lahir_user = '{dateTimePicker1.Value}', jk_user = '{cbGender.SelectedItem.ToString()}', tipe_user = '{comboBox1.SelectedItem.ToString()}' WHERE id_user = '{Convert.ToInt32(txtID.Text)}'";
            frm_login.executeQuery(query);
            LoadBarang();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin mau delete User ini ?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                string query = $"DELETE [Akun] where id_user = '{Convert.ToInt32(txtID.Text)}'";
                frm_login.executeQuery(query);
                LoadBarang();
            }
        }
    }
}
