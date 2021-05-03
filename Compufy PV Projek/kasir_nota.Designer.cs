namespace Compufy_PV_Projek
{
    partial class kasir_nota
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
            this.creport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // creport
            // 
            this.creport.ActiveViewIndex = -1;
            this.creport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creport.Cursor = System.Windows.Forms.Cursors.Default;
            this.creport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creport.Location = new System.Drawing.Point(0, 0);
            this.creport.Name = "creport";
            this.creport.Size = new System.Drawing.Size(934, 508);
            this.creport.TabIndex = 0;
            // 
            // kasir_nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 508);
            this.Controls.Add(this.creport);
            this.Name = "kasir_nota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kasir_nota";
            this.Load += new System.EventHandler(this.kasir_nota_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer creport;
    }
}