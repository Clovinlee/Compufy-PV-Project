namespace Compufy_PV_Projek
{
    partial class super_manage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_jk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pl_borderbottom = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_username,
            this.col_password,
            this.col_nama,
            this.col_birthdate,
            this.col_jk,
            this.col_tipe});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(741, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // col_id
            // 
            this.col_id.HeaderText = "ID_User";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            // 
            // col_username
            // 
            this.col_username.HeaderText = "Username";
            this.col_username.Name = "col_username";
            this.col_username.ReadOnly = true;
            // 
            // col_password
            // 
            this.col_password.HeaderText = "Password";
            this.col_password.Name = "col_password";
            this.col_password.ReadOnly = true;
            // 
            // col_nama
            // 
            this.col_nama.HeaderText = "Nama User";
            this.col_nama.Name = "col_nama";
            this.col_nama.ReadOnly = true;
            // 
            // col_birthdate
            // 
            this.col_birthdate.HeaderText = "Birthdate";
            this.col_birthdate.Name = "col_birthdate";
            this.col_birthdate.ReadOnly = true;
            // 
            // col_jk
            // 
            this.col_jk.HeaderText = "Jenis Kelamin";
            this.col_jk.Name = "col_jk";
            this.col_jk.ReadOnly = true;
            // 
            // col_tipe
            // 
            this.col_tipe.HeaderText = "Tipe User";
            this.col_tipe.Name = "col_tipe";
            this.col_tipe.ReadOnly = true;
            // 
            // pl_borderbottom
            // 
            this.pl_borderbottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(160)))), ((int)(((byte)(152)))));
            this.pl_borderbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pl_borderbottom.Location = new System.Drawing.Point(0, 400);
            this.pl_borderbottom.Name = "pl_borderbottom";
            this.pl_borderbottom.Size = new System.Drawing.Size(741, 13);
            this.pl_borderbottom.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 144);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // super_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(160)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(741, 413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pl_borderbottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "super_manage";
            this.Text = "super_manage";
            this.Load += new System.EventHandler(this.super_manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_jk;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tipe;
        private System.Windows.Forms.Panel pl_borderbottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}