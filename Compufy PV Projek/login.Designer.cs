namespace Compufy_PV_Projek
{
    partial class login
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
            this.pl_interface = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.icon_username = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.icon_password = new FontAwesome.Sharp.IconPictureBox();
            this.btn_login = new FontAwesome.Sharp.IconButton();
            this.pb_anon = new System.Windows.Forms.PictureBox();
            this.pl_topbar = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.pl_interface.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_username)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anon)).BeginInit();
            this.pl_topbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_interface
            // 
            this.pl_interface.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pl_interface.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.pl_interface.Controls.Add(this.panel2);
            this.pl_interface.Controls.Add(this.panel1);
            this.pl_interface.Controls.Add(this.btn_login);
            this.pl_interface.Controls.Add(this.pb_anon);
            this.pl_interface.Location = new System.Drawing.Point(296, 85);
            this.pl_interface.Name = "pl_interface";
            this.pl_interface.Size = new System.Drawing.Size(352, 579);
            this.pl_interface.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tb_username);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.icon_username);
            this.panel2.Location = new System.Drawing.Point(45, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 58);
            this.panel2.TabIndex = 1;
            // 
            // tb_username
            // 
            this.tb_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.Color.Silver;
            this.tb_username.Location = new System.Drawing.Point(52, 13);
            this.tb_username.MaxLength = 20;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(204, 24);
            this.tb_username.TabIndex = 0;
            this.tb_username.Tag = "Username";
            this.tb_username.Text = "Username";
            this.tb_username.Enter += new System.EventHandler(this.tb_input_Focus);
            this.tb_username.Leave += new System.EventHandler(this.tb_input_FocusLeave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 1);
            this.label2.TabIndex = 1;
            // 
            // icon_username
            // 
            this.icon_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.icon_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(160)))), ((int)(((byte)(152)))));
            this.icon_username.IconChar = FontAwesome.Sharp.IconChar.User;
            this.icon_username.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(160)))), ((int)(((byte)(152)))));
            this.icon_username.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_username.IconSize = 41;
            this.icon_username.Location = new System.Drawing.Point(8, 7);
            this.icon_username.Name = "icon_username";
            this.icon_username.Size = new System.Drawing.Size(41, 45);
            this.icon_username.TabIndex = 4;
            this.icon_username.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.icon_password);
            this.panel1.Location = new System.Drawing.Point(45, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 58);
            this.panel1.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.ForeColor = System.Drawing.Color.Silver;
            this.tb_password.Location = new System.Drawing.Point(52, 13);
            this.tb_password.MaxLength = 20;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(204, 24);
            this.tb_password.TabIndex = 1;
            this.tb_password.Tag = "Password";
            this.tb_password.Text = "Password";
            this.tb_password.Enter += new System.EventHandler(this.tb_input_Focus);
            this.tb_password.Leave += new System.EventHandler(this.tb_input_FocusLeave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(7, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 1);
            this.label3.TabIndex = 0;
            // 
            // icon_password
            // 
            this.icon_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.icon_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(160)))), ((int)(((byte)(152)))));
            this.icon_password.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.icon_password.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(160)))), ((int)(((byte)(152)))));
            this.icon_password.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_password.IconSize = 41;
            this.icon_password.Location = new System.Drawing.Point(8, 7);
            this.icon_password.Name = "icon_password";
            this.icon_password.Size = new System.Drawing.Size(41, 45);
            this.icon_password.TabIndex = 4;
            this.icon_password.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(160)))), ((int)(((byte)(152)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.btn_login.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_login.IconColor = System.Drawing.Color.Black;
            this.btn_login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_login.Location = new System.Drawing.Point(45, 359);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(262, 51);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pb_anon
            // 
            this.pb_anon.Location = new System.Drawing.Point(111, 22);
            this.pb_anon.Name = "pb_anon";
            this.pb_anon.Size = new System.Drawing.Size(130, 130);
            this.pb_anon.TabIndex = 2;
            this.pb_anon.TabStop = false;
            // 
            // pl_topbar
            // 
            this.pl_topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.pl_topbar.Controls.Add(this.Label1);
            this.pl_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_topbar.Location = new System.Drawing.Point(0, 0);
            this.pl_topbar.Name = "pl_topbar";
            this.pl_topbar.Size = new System.Drawing.Size(944, 66);
            this.pl_topbar.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(185)))), ((int)(((byte)(146)))));
            this.Label1.Location = new System.Drawing.Point(12, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(168, 42);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Login Page";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(160)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.pl_interface);
            this.Controls.Add(this.pl_topbar);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compufy";
            this.Load += new System.EventHandler(this.login_Load);
            this.pl_interface.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_username)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anon)).EndInit();
            this.pl_topbar.ResumeLayout(false);
            this.pl_topbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pl_interface;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox icon_username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox icon_password;
        private FontAwesome.Sharp.IconButton btn_login;
        private System.Windows.Forms.PictureBox pb_anon;
        private System.Windows.Forms.Panel pl_topbar;
        private System.Windows.Forms.Label Label1;
    }
}

