namespace Compufy_PV_Projek
{
    partial class kasir_addmember
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
            this.pl_addmember = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_wanita = new System.Windows.Forms.RadioButton();
            this.rb_pria = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_birthdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.btn_tambahmember = new System.Windows.Forms.Button();
            this.btn_checkmember = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pl_addmember.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_addmember
            // 
            this.pl_addmember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_addmember.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pl_addmember.Controls.Add(this.btn_reset);
            this.pl_addmember.Controls.Add(this.groupBox1);
            this.pl_addmember.Controls.Add(this.btn_tambahmember);
            this.pl_addmember.Controls.Add(this.btn_checkmember);
            this.pl_addmember.Controls.Add(this.label2);
            this.pl_addmember.Controls.Add(this.tb_id);
            this.pl_addmember.Controls.Add(this.label1);
            this.pl_addmember.Location = new System.Drawing.Point(2, 2);
            this.pl_addmember.Name = "pl_addmember";
            this.pl_addmember.Size = new System.Drawing.Size(370, 395);
            this.pl_addmember.TabIndex = 8;
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reset.BackColor = System.Drawing.Color.SlateGray;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(252, 83);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(79, 34);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rb_wanita);
            this.groupBox1.Controls.Add(this.rb_pria);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_birthdate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_nama);
            this.groupBox1.Enabled = false;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 128);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Member";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Jenis Kelamin";
            // 
            // rb_wanita
            // 
            this.rb_wanita.AutoSize = true;
            this.rb_wanita.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_wanita.Location = new System.Drawing.Point(200, 82);
            this.rb_wanita.Name = "rb_wanita";
            this.rb_wanita.Size = new System.Drawing.Size(66, 21);
            this.rb_wanita.TabIndex = 16;
            this.rb_wanita.Text = "Wanita";
            this.rb_wanita.UseVisualStyleBackColor = true;
            // 
            // rb_pria
            // 
            this.rb_pria.AutoSize = true;
            this.rb_pria.Checked = true;
            this.rb_pria.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_pria.Location = new System.Drawing.Point(147, 82);
            this.rb_pria.Name = "rb_pria";
            this.rb_pria.Size = new System.Drawing.Size(48, 21);
            this.rb_pria.TabIndex = 15;
            this.rb_pria.TabStop = true;
            this.rb_pria.Text = "Pria";
            this.rb_pria.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Birthdate";
            // 
            // tb_birthdate
            // 
            this.tb_birthdate.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_birthdate.Location = new System.Drawing.Point(147, 53);
            this.tb_birthdate.Name = "tb_birthdate";
            this.tb_birthdate.Size = new System.Drawing.Size(173, 23);
            this.tb_birthdate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nama";
            // 
            // tb_nama
            // 
            this.tb_nama.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nama.Location = new System.Drawing.Point(147, 24);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(173, 23);
            this.tb_nama.TabIndex = 0;
            // 
            // btn_tambahmember
            // 
            this.btn_tambahmember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tambahmember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(179)))), ((int)(((byte)(50)))));
            this.btn_tambahmember.Enabled = false;
            this.btn_tambahmember.FlatAppearance.BorderSize = 0;
            this.btn_tambahmember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tambahmember.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambahmember.ForeColor = System.Drawing.Color.White;
            this.btn_tambahmember.Location = new System.Drawing.Point(11, 346);
            this.btn_tambahmember.Name = "btn_tambahmember";
            this.btn_tambahmember.Size = new System.Drawing.Size(348, 37);
            this.btn_tambahmember.TabIndex = 3;
            this.btn_tambahmember.Text = "Input Member";
            this.btn_tambahmember.UseVisualStyleBackColor = false;
            this.btn_tambahmember.Click += new System.EventHandler(this.btn_tambahmember_Click);
            // 
            // btn_checkmember
            // 
            this.btn_checkmember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_checkmember.BackColor = System.Drawing.Color.SlateGray;
            this.btn_checkmember.FlatAppearance.BorderSize = 0;
            this.btn_checkmember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkmember.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkmember.ForeColor = System.Drawing.Color.White;
            this.btn_checkmember.Location = new System.Drawing.Point(158, 83);
            this.btn_checkmember.Name = "btn_checkmember";
            this.btn_checkmember.Size = new System.Drawing.Size(79, 34);
            this.btn_checkmember.TabIndex = 1;
            this.btn_checkmember.Text = "Check";
            this.btn_checkmember.UseVisualStyleBackColor = false;
            this.btn_checkmember.Click += new System.EventHandler(this.btn_checkmember_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID Member";
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(158, 54);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(173, 23);
            this.tb_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(95, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Member";
            // 
            // kasir_addmember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(375, 402);
            this.Controls.Add(this.pl_addmember);
            this.MaximizeBox = false;
            this.Name = "kasir_addmember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kasir_addmember";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kasir_addmember_FormClosing);
            this.Load += new System.EventHandler(this.kasir_addmember_Load);
            this.pl_addmember.ResumeLayout(false);
            this.pl_addmember.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_addmember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button btn_tambahmember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_checkmember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_wanita;
        private System.Windows.Forms.RadioButton rb_pria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_birthdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_reset;
    }
}