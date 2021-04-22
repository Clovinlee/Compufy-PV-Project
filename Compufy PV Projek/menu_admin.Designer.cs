namespace Compufy_PV_Projek
{
    partial class menu_admin
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
            this.pl_leftbar = new System.Windows.Forms.Panel();
            this.btn_member = new FontAwesome.Sharp.IconButton();
            this.btn_manageuser = new FontAwesome.Sharp.IconButton();
            this.btn_menustocks = new FontAwesome.Sharp.IconButton();
            this.btn_menutransactions = new FontAwesome.Sharp.IconButton();
            this.btn_menusales = new FontAwesome.Sharp.IconButton();
            this.btn_menudashboard = new FontAwesome.Sharp.IconButton();
            this.pl_menulogo = new System.Windows.Forms.Panel();
            this.pl_topbar = new System.Windows.Forms.Panel();
            this.lbl_jabatanuser = new System.Windows.Forms.Label();
            this.link_logout = new System.Windows.Forms.LinkLabel();
            this.lbl_namauser = new System.Windows.Forms.Label();
            this.pl_avatar = new System.Windows.Forms.Panel();
            this.pl_submenu = new System.Windows.Forms.Panel();
            this.pl_leftbar.SuspendLayout();
            this.pl_topbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_leftbar
            // 
            this.pl_leftbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(82)))));
            this.pl_leftbar.Controls.Add(this.btn_member);
            this.pl_leftbar.Controls.Add(this.btn_manageuser);
            this.pl_leftbar.Controls.Add(this.btn_menustocks);
            this.pl_leftbar.Controls.Add(this.btn_menutransactions);
            this.pl_leftbar.Controls.Add(this.btn_menusales);
            this.pl_leftbar.Controls.Add(this.btn_menudashboard);
            this.pl_leftbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_leftbar.Location = new System.Drawing.Point(0, 92);
            this.pl_leftbar.Name = "pl_leftbar";
            this.pl_leftbar.Size = new System.Drawing.Size(182, 508);
            this.pl_leftbar.TabIndex = 5;
            // 
            // btn_member
            // 
            this.btn_member.FlatAppearance.BorderSize = 0;
            this.btn_member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_member.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_member.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_member.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btn_member.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_member.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_member.IconSize = 45;
            this.btn_member.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_member.Location = new System.Drawing.Point(0, 423);
            this.btn_member.Name = "btn_member";
            this.btn_member.Size = new System.Drawing.Size(182, 82);
            this.btn_member.TabIndex = 6;
            this.btn_member.Tag = "Manage Member";
            this.btn_member.Text = "Manage Member";
            this.btn_member.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_member.UseVisualStyleBackColor = true;
            this.btn_member.Enter += new System.EventHandler(this.btn_submenu_Enter);
            this.btn_member.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_submenu_MouseDown);
            this.btn_member.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_submenu_MouseUp);
            // 
            // btn_manageuser
            // 
            this.btn_manageuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(82)))));
            this.btn_manageuser.FlatAppearance.BorderSize = 0;
            this.btn_manageuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manageuser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageuser.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_manageuser.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.btn_manageuser.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_manageuser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_manageuser.IconSize = 45;
            this.btn_manageuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manageuser.Location = new System.Drawing.Point(0, 338);
            this.btn_manageuser.Name = "btn_manageuser";
            this.btn_manageuser.Size = new System.Drawing.Size(182, 82);
            this.btn_manageuser.TabIndex = 5;
            this.btn_manageuser.Tag = "Manage User";
            this.btn_manageuser.Text = "Manage User";
            this.btn_manageuser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_manageuser.UseVisualStyleBackColor = false;
            this.btn_manageuser.Enter += new System.EventHandler(this.btn_submenu_Enter);
            this.btn_manageuser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_submenu_MouseDown);
            this.btn_manageuser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_submenu_MouseUp);
            // 
            // btn_menustocks
            // 
            this.btn_menustocks.FlatAppearance.BorderSize = 0;
            this.btn_menustocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menustocks.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menustocks.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_menustocks.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.btn_menustocks.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_menustocks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_menustocks.IconSize = 45;
            this.btn_menustocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menustocks.Location = new System.Drawing.Point(0, 254);
            this.btn_menustocks.Name = "btn_menustocks";
            this.btn_menustocks.Size = new System.Drawing.Size(182, 82);
            this.btn_menustocks.TabIndex = 1;
            this.btn_menustocks.Tag = "Stocks";
            this.btn_menustocks.Text = "Stocks";
            this.btn_menustocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menustocks.UseVisualStyleBackColor = true;
            this.btn_menustocks.Enter += new System.EventHandler(this.btn_submenu_Enter);
            this.btn_menustocks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_submenu_MouseDown);
            this.btn_menustocks.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_submenu_MouseUp);
            // 
            // btn_menutransactions
            // 
            this.btn_menutransactions.FlatAppearance.BorderSize = 0;
            this.btn_menutransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menutransactions.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menutransactions.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_menutransactions.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.btn_menutransactions.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_menutransactions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_menutransactions.IconSize = 45;
            this.btn_menutransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menutransactions.Location = new System.Drawing.Point(0, 169);
            this.btn_menutransactions.Name = "btn_menutransactions";
            this.btn_menutransactions.Size = new System.Drawing.Size(182, 82);
            this.btn_menutransactions.TabIndex = 1;
            this.btn_menutransactions.Tag = "Transactions";
            this.btn_menutransactions.Text = "Transactions";
            this.btn_menutransactions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menutransactions.UseVisualStyleBackColor = true;
            this.btn_menutransactions.Enter += new System.EventHandler(this.btn_submenu_Enter);
            this.btn_menutransactions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_submenu_MouseDown);
            this.btn_menutransactions.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_submenu_MouseUp);
            // 
            // btn_menusales
            // 
            this.btn_menusales.FlatAppearance.BorderSize = 0;
            this.btn_menusales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menusales.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menusales.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_menusales.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btn_menusales.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_menusales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_menusales.IconSize = 45;
            this.btn_menusales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menusales.Location = new System.Drawing.Point(0, 84);
            this.btn_menusales.Name = "btn_menusales";
            this.btn_menusales.Size = new System.Drawing.Size(182, 82);
            this.btn_menusales.TabIndex = 1;
            this.btn_menusales.Tag = "Sales";
            this.btn_menusales.Text = "Sales";
            this.btn_menusales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menusales.UseVisualStyleBackColor = true;
            this.btn_menusales.Enter += new System.EventHandler(this.btn_submenu_Enter);
            this.btn_menusales.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_submenu_MouseDown);
            this.btn_menusales.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_submenu_MouseUp);
            // 
            // btn_menudashboard
            // 
            this.btn_menudashboard.FlatAppearance.BorderSize = 0;
            this.btn_menudashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menudashboard.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menudashboard.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_menudashboard.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_menudashboard.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_menudashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_menudashboard.IconSize = 45;
            this.btn_menudashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menudashboard.Location = new System.Drawing.Point(0, 0);
            this.btn_menudashboard.Name = "btn_menudashboard";
            this.btn_menudashboard.Size = new System.Drawing.Size(182, 82);
            this.btn_menudashboard.TabIndex = 1;
            this.btn_menudashboard.Tag = "Dashboard";
            this.btn_menudashboard.Text = "Dashboard";
            this.btn_menudashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menudashboard.UseVisualStyleBackColor = true;
            this.btn_menudashboard.Enter += new System.EventHandler(this.btn_submenu_Enter);
            this.btn_menudashboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_submenu_MouseDown);
            this.btn_menudashboard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_submenu_MouseUp);
            // 
            // pl_menulogo
            // 
            this.pl_menulogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(82)))));
            this.pl_menulogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pl_menulogo.Location = new System.Drawing.Point(0, 0);
            this.pl_menulogo.Name = "pl_menulogo";
            this.pl_menulogo.Size = new System.Drawing.Size(182, 92);
            this.pl_menulogo.TabIndex = 3;
            this.pl_menulogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pl_menulogo_Paint);
            // 
            // pl_topbar
            // 
            this.pl_topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.pl_topbar.Controls.Add(this.lbl_jabatanuser);
            this.pl_topbar.Controls.Add(this.link_logout);
            this.pl_topbar.Controls.Add(this.lbl_namauser);
            this.pl_topbar.Controls.Add(this.pl_avatar);
            this.pl_topbar.Controls.Add(this.pl_menulogo);
            this.pl_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_topbar.Location = new System.Drawing.Point(0, 0);
            this.pl_topbar.Name = "pl_topbar";
            this.pl_topbar.Size = new System.Drawing.Size(909, 92);
            this.pl_topbar.TabIndex = 4;
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
            // pl_avatar
            // 
            this.pl_avatar.Location = new System.Drawing.Point(829, 11);
            this.pl_avatar.Name = "pl_avatar";
            this.pl_avatar.Size = new System.Drawing.Size(70, 70);
            this.pl_avatar.TabIndex = 3;
            // 
            // pl_submenu
            // 
            this.pl_submenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(160)))), ((int)(((byte)(152)))));
            this.pl_submenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_submenu.Location = new System.Drawing.Point(182, 92);
            this.pl_submenu.Name = "pl_submenu";
            this.pl_submenu.Size = new System.Drawing.Size(727, 508);
            this.pl_submenu.TabIndex = 6;
            // 
            // menu_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(909, 600);
            this.Controls.Add(this.pl_submenu);
            this.Controls.Add(this.pl_leftbar);
            this.Controls.Add(this.pl_topbar);
            this.Name = "menu_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compufy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_admin_FormClosing);
            this.Load += new System.EventHandler(this.menu_admin_Load);
            this.pl_leftbar.ResumeLayout(false);
            this.pl_topbar.ResumeLayout(false);
            this.pl_topbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_leftbar;
        private FontAwesome.Sharp.IconButton btn_member;
        private FontAwesome.Sharp.IconButton btn_manageuser;
        private FontAwesome.Sharp.IconButton btn_menustocks;
        private FontAwesome.Sharp.IconButton btn_menutransactions;
        private FontAwesome.Sharp.IconButton btn_menusales;
        private FontAwesome.Sharp.IconButton btn_menudashboard;
        private System.Windows.Forms.Panel pl_menulogo;
        private System.Windows.Forms.Panel pl_topbar;
        public System.Windows.Forms.Label lbl_jabatanuser;
        private System.Windows.Forms.LinkLabel link_logout;
        public System.Windows.Forms.Label lbl_namauser;
        private System.Windows.Forms.Panel pl_avatar;
        private System.Windows.Forms.Panel pl_submenu;
    }
}

