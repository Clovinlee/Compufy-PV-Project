namespace Compufy_PV_Projek
{
    partial class menu_kasir
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
            this.pl_main = new System.Windows.Forms.Panel();
            this.pl_submenu = new System.Windows.Forms.Panel();
            this.pl_topbar = new System.Windows.Forms.Panel();
            this.pl_menulogo = new System.Windows.Forms.Panel();
            this.pl_avatar = new System.Windows.Forms.Panel();
            this.lbl_jabatanuser = new System.Windows.Forms.Label();
            this.link_logout = new System.Windows.Forms.LinkLabel();
            this.lbl_namauser = new System.Windows.Forms.Label();
            this.pl_main.SuspendLayout();
            this.pl_topbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_main
            // 
            this.pl_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(160)))), ((int)(((byte)(152)))));
            this.pl_main.Controls.Add(this.pl_submenu);
            this.pl_main.Controls.Add(this.pl_topbar);
            this.pl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_main.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl_main.Location = new System.Drawing.Point(0, 0);
            this.pl_main.Name = "pl_main";
            this.pl_main.Size = new System.Drawing.Size(909, 600);
            this.pl_main.TabIndex = 4;
            // 
            // pl_submenu
            // 
            this.pl_submenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_submenu.Location = new System.Drawing.Point(0, 92);
            this.pl_submenu.Name = "pl_submenu";
            this.pl_submenu.Size = new System.Drawing.Size(909, 508);
            this.pl_submenu.TabIndex = 1;
            // 
            // pl_topbar
            // 
            this.pl_topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.pl_topbar.Controls.Add(this.pl_menulogo);
            this.pl_topbar.Controls.Add(this.pl_avatar);
            this.pl_topbar.Controls.Add(this.lbl_jabatanuser);
            this.pl_topbar.Controls.Add(this.link_logout);
            this.pl_topbar.Controls.Add(this.lbl_namauser);
            this.pl_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_topbar.Location = new System.Drawing.Point(0, 0);
            this.pl_topbar.Name = "pl_topbar";
            this.pl_topbar.Size = new System.Drawing.Size(909, 92);
            this.pl_topbar.TabIndex = 0;
            // 
            // pl_menulogo
            // 
            this.pl_menulogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(82)))));
            this.pl_menulogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pl_menulogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_menulogo.Location = new System.Drawing.Point(0, 0);
            this.pl_menulogo.Name = "pl_menulogo";
            this.pl_menulogo.Size = new System.Drawing.Size(184, 92);
            this.pl_menulogo.TabIndex = 3;
            this.pl_menulogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pl_menulogo_Paint);
            // 
            // pl_avatar
            // 
            this.pl_avatar.Location = new System.Drawing.Point(998, 11);
            this.pl_avatar.Name = "pl_avatar";
            this.pl_avatar.Size = new System.Drawing.Size(70, 70);
            this.pl_avatar.TabIndex = 3;
            // 
            // lbl_jabatanuser
            // 
            this.lbl_jabatanuser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_jabatanuser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jabatanuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(160)))), ((int)(((byte)(152)))));
            this.lbl_jabatanuser.Location = new System.Drawing.Point(572, 33);
            this.lbl_jabatanuser.Name = "lbl_jabatanuser";
            this.lbl_jabatanuser.Size = new System.Drawing.Size(251, 26);
            this.lbl_jabatanuser.TabIndex = 4;
            this.lbl_jabatanuser.Text = "Kasir Shift Pagi";
            this.lbl_jabatanuser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // link_logout
            // 
            this.link_logout.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(236)))), ((int)(((byte)(226)))));
            this.link_logout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.link_logout.AutoSize = true;
            this.link_logout.Font = new System.Drawing.Font("Arial", 11.25F);
            this.link_logout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(160)))), ((int)(((byte)(152)))));
            this.link_logout.Location = new System.Drawing.Point(771, 64);
            this.link_logout.Name = "link_logout";
            this.link_logout.Size = new System.Drawing.Size(52, 17);
            this.link_logout.TabIndex = 5;
            this.link_logout.TabStop = true;
            this.link_logout.Text = "Logout";
            this.link_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_logout_LinkClicked);
            // 
            // lbl_namauser
            // 
            this.lbl_namauser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_namauser.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_namauser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(185)))), ((int)(((byte)(146)))));
            this.lbl_namauser.Location = new System.Drawing.Point(572, 5);
            this.lbl_namauser.Name = "lbl_namauser";
            this.lbl_namauser.Size = new System.Drawing.Size(251, 37);
            this.lbl_namauser.TabIndex = 4;
            this.lbl_namauser.Text = "Nama User";
            this.lbl_namauser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menu_kasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 600);
            this.Controls.Add(this.pl_main);
            this.Name = "menu_kasir";
            this.Text = "menu_kasir";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_kasir_FormClosing);
            this.Load += new System.EventHandler(this.menu_kasir_Load);
            this.pl_main.ResumeLayout(false);
            this.pl_topbar.ResumeLayout(false);
            this.pl_topbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pl_main;
        private System.Windows.Forms.Panel pl_topbar;
        public System.Windows.Forms.Label lbl_jabatanuser;
        private System.Windows.Forms.LinkLabel link_logout;
        public System.Windows.Forms.Label lbl_namauser;
        private System.Windows.Forms.Panel pl_avatar;
        private System.Windows.Forms.Panel pl_menulogo;
        private System.Windows.Forms.Panel pl_submenu;
    }
}