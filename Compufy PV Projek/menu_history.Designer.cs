namespace Compufy_PV_Projek
{
    partial class menu_history
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_loadhistory = new FontAwesome.Sharp.IconButton();
            this.clb_history = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.btn_loadhistory);
            this.panel1.Controls.Add(this.clb_history);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 434);
            this.panel1.TabIndex = 0;
            // 
            // btn_loadhistory
            // 
            this.btn_loadhistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_loadhistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(160)))), ((int)(((byte)(152)))));
            this.btn_loadhistory.FlatAppearance.BorderSize = 0;
            this.btn_loadhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadhistory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadhistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.btn_loadhistory.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_loadhistory.IconColor = System.Drawing.Color.Black;
            this.btn_loadhistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_loadhistory.Location = new System.Drawing.Point(17, 374);
            this.btn_loadhistory.Name = "btn_loadhistory";
            this.btn_loadhistory.Size = new System.Drawing.Size(225, 51);
            this.btn_loadhistory.TabIndex = 4;
            this.btn_loadhistory.Text = "Load History";
            this.btn_loadhistory.UseVisualStyleBackColor = false;
            this.btn_loadhistory.Click += new System.EventHandler(this.btn_loadhistory_Click);
            // 
            // clb_history
            // 
            this.clb_history.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clb_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.clb_history.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_history.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_history.ForeColor = System.Drawing.Color.White;
            this.clb_history.FormattingEnabled = true;
            this.clb_history.Location = new System.Drawing.Point(17, 16);
            this.clb_history.Name = "clb_history";
            this.clb_history.Size = new System.Drawing.Size(225, 352);
            this.clb_history.TabIndex = 0;
            this.clb_history.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_history_ItemCheck);
            // 
            // menu_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(160)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(281, 457);
            this.Controls.Add(this.panel1);
            this.Name = "menu_history";
            this.Text = "menu_history";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_history_FormClosing);
            this.Load += new System.EventHandler(this.menu_history_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox clb_history;
        private FontAwesome.Sharp.IconButton btn_loadhistory;
    }
}