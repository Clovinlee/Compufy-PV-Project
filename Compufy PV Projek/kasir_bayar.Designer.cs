namespace Compufy_PV_Projek
{
    partial class kasir_bayar
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
            this.lbl_total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_cash = new System.Windows.Forms.NumericUpDown();
            this.rb_kredit = new XanderUI.XUIRadio();
            this.rb_cash = new XanderUI.XUIRadio();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pl_addmember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_cash)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_addmember
            // 
            this.pl_addmember.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pl_addmember.Controls.Add(this.lbl_total);
            this.pl_addmember.Controls.Add(this.label3);
            this.pl_addmember.Controls.Add(this.num_cash);
            this.pl_addmember.Controls.Add(this.rb_kredit);
            this.pl_addmember.Controls.Add(this.rb_cash);
            this.pl_addmember.Controls.Add(this.btn_cancel);
            this.pl_addmember.Controls.Add(this.btn_checkout);
            this.pl_addmember.Controls.Add(this.label2);
            this.pl_addmember.Controls.Add(this.label1);
            this.pl_addmember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_addmember.Location = new System.Drawing.Point(0, 0);
            this.pl_addmember.Name = "pl_addmember";
            this.pl_addmember.Size = new System.Drawing.Size(371, 294);
            this.pl_addmember.TabIndex = 9;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lbl_total.Location = new System.Drawing.Point(73, 47);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(43, 21);
            this.lbl_total.TabIndex = 16;
            this.lbl_total.Text = "Rp 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total :";
            // 
            // num_cash
            // 
            this.num_cash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_cash.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_cash.Location = new System.Drawing.Point(38, 124);
            this.num_cash.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.num_cash.Name = "num_cash";
            this.num_cash.Size = new System.Drawing.Size(226, 27);
            this.num_cash.TabIndex = 14;
            // 
            // rb_kredit
            // 
            this.rb_kredit.Checked = false;
            this.rb_kredit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_kredit.ForeColor = System.Drawing.Color.Black;
            this.rb_kredit.Location = new System.Drawing.Point(16, 166);
            this.rb_kredit.Name = "rb_kredit";
            this.rb_kredit.RadioColor = System.Drawing.Color.SlateGray;
            this.rb_kredit.RadioHoverColor = System.Drawing.Color.IndianRed;
            this.rb_kredit.RadioStyle = XanderUI.XUIRadio.Style.Android;
            this.rb_kredit.Size = new System.Drawing.Size(100, 16);
            this.rb_kredit.TabIndex = 12;
            this.rb_kredit.Text = "Kartu Kredit";
            this.rb_kredit.Click += new System.EventHandler(this.rb_kredit_Click);
            // 
            // rb_cash
            // 
            this.rb_cash.Checked = true;
            this.rb_cash.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_cash.ForeColor = System.Drawing.Color.Black;
            this.rb_cash.Location = new System.Drawing.Point(16, 102);
            this.rb_cash.Name = "rb_cash";
            this.rb_cash.RadioColor = System.Drawing.Color.SlateGray;
            this.rb_cash.RadioHoverColor = System.Drawing.Color.IndianRed;
            this.rb_cash.RadioStyle = XanderUI.XUIRadio.Style.Android;
            this.rb_cash.Size = new System.Drawing.Size(100, 16);
            this.rb_cash.TabIndex = 11;
            this.rb_cash.Text = "Cash";
            this.rb_cash.Click += new System.EventHandler(this.rb_cash_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.SlateGray;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(11, 205);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(349, 34);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(179)))), ((int)(((byte)(50)))));
            this.btn_checkout.FlatAppearance.BorderSize = 0;
            this.btn_checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkout.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkout.ForeColor = System.Drawing.Color.White;
            this.btn_checkout.Location = new System.Drawing.Point(11, 245);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(349, 37);
            this.btn_checkout.TabIndex = 3;
            this.btn_checkout.Text = "Checkout";
            this.btn_checkout.UseVisualStyleBackColor = false;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Metode Pembayaran";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(107, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pembayaran";
            // 
            // kasir_bayar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(371, 294);
            this.Controls.Add(this.pl_addmember);
            this.Name = "kasir_bayar";
            this.Text = "kasir_bayar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kasir_bayar_FormClosing);
            this.Load += new System.EventHandler(this.kasir_bayar_Load);
            this.pl_addmember.ResumeLayout(false);
            this.pl_addmember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_cash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_addmember;
        private System.Windows.Forms.NumericUpDown num_cash;
        private XanderUI.XUIRadio rb_kredit;
        private XanderUI.XUIRadio rb_cash;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label3;
    }
}