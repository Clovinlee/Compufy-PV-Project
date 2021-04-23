namespace Compufy_PV_Projek
{
    partial class kasir_registermember
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.pl_addmember = new System.Windows.Forms.Panel();
            this.rb_wanita = new System.Windows.Forms.RadioButton();
            this.rb_pria = new System.Windows.Forms.RadioButton();
            this.dt_birthdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tempattinggal = new System.Windows.Forms.TextBox();
            this.tb_nohp = new System.Windows.Forms.TextBox();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.pl_addmember.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(71, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrasi Member";
            // 
            // btn_tambah
            // 
            this.btn_tambah.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(179)))), ((int)(((byte)(50)))));
            this.btn_tambah.FlatAppearance.BorderSize = 0;
            this.btn_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tambah.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah.ForeColor = System.Drawing.Color.White;
            this.btn_tambah.Location = new System.Drawing.Point(11, 371);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(348, 37);
            this.btn_tambah.TabIndex = 6;
            this.btn_tambah.Text = "Tambah Member";
            this.btn_tambah.UseVisualStyleBackColor = false;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // pl_addmember
            // 
            this.pl_addmember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_addmember.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pl_addmember.Controls.Add(this.rb_wanita);
            this.pl_addmember.Controls.Add(this.rb_pria);
            this.pl_addmember.Controls.Add(this.dt_birthdate);
            this.pl_addmember.Controls.Add(this.label6);
            this.pl_addmember.Controls.Add(this.label5);
            this.pl_addmember.Controls.Add(this.label4);
            this.pl_addmember.Controls.Add(this.label3);
            this.pl_addmember.Controls.Add(this.label2);
            this.pl_addmember.Controls.Add(this.tb_tempattinggal);
            this.pl_addmember.Controls.Add(this.tb_nohp);
            this.pl_addmember.Controls.Add(this.tb_nama);
            this.pl_addmember.Controls.Add(this.btn_tambah);
            this.pl_addmember.Controls.Add(this.label1);
            this.pl_addmember.Location = new System.Drawing.Point(2, 4);
            this.pl_addmember.Name = "pl_addmember";
            this.pl_addmember.Size = new System.Drawing.Size(370, 418);
            this.pl_addmember.TabIndex = 7;
            // 
            // rb_wanita
            // 
            this.rb_wanita.AutoSize = true;
            this.rb_wanita.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_wanita.Location = new System.Drawing.Point(209, 164);
            this.rb_wanita.Name = "rb_wanita";
            this.rb_wanita.Size = new System.Drawing.Size(62, 19);
            this.rb_wanita.TabIndex = 4;
            this.rb_wanita.Text = "Wanita";
            this.rb_wanita.UseVisualStyleBackColor = true;
            // 
            // rb_pria
            // 
            this.rb_pria.AutoSize = true;
            this.rb_pria.Checked = true;
            this.rb_pria.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_pria.Location = new System.Drawing.Point(158, 164);
            this.rb_pria.Name = "rb_pria";
            this.rb_pria.Size = new System.Drawing.Size(45, 19);
            this.rb_pria.TabIndex = 3;
            this.rb_pria.TabStop = true;
            this.rb_pria.Text = "Pria";
            this.rb_pria.UseVisualStyleBackColor = true;
            // 
            // dt_birthdate
            // 
            this.dt_birthdate.Location = new System.Drawing.Point(158, 126);
            this.dt_birthdate.Name = "dt_birthdate";
            this.dt_birthdate.Size = new System.Drawing.Size(173, 20);
            this.dt_birthdate.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tempat Tinggal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Birthdate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "No HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nama";
            // 
            // tb_tempattinggal
            // 
            this.tb_tempattinggal.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tempattinggal.Location = new System.Drawing.Point(158, 198);
            this.tb_tempattinggal.Multiline = true;
            this.tb_tempattinggal.Name = "tb_tempattinggal";
            this.tb_tempattinggal.Size = new System.Drawing.Size(173, 54);
            this.tb_tempattinggal.TabIndex = 5;
            // 
            // tb_nohp
            // 
            this.tb_nohp.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nohp.Location = new System.Drawing.Point(158, 93);
            this.tb_nohp.Name = "tb_nohp";
            this.tb_nohp.Size = new System.Drawing.Size(173, 23);
            this.tb_nohp.TabIndex = 1;
            // 
            // tb_nama
            // 
            this.tb_nama.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nama.Location = new System.Drawing.Point(156, 54);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(173, 23);
            this.tb_nama.TabIndex = 0;
            // 
            // kasir_registermember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(375, 426);
            this.Controls.Add(this.pl_addmember);
            this.MaximizeBox = false;
            this.Name = "kasir_registermember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kasir_addmember";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kasir_addmember_FormClosing);
            this.Load += new System.EventHandler(this.kasir_addmember_Load);
            this.pl_addmember.ResumeLayout(false);
            this.pl_addmember.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Panel pl_addmember;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.RadioButton rb_wanita;
        private System.Windows.Forms.RadioButton rb_pria;
        private System.Windows.Forms.DateTimePicker dt_birthdate;
        private System.Windows.Forms.TextBox tb_tempattinggal;
        private System.Windows.Forms.TextBox tb_nohp;
    }
}