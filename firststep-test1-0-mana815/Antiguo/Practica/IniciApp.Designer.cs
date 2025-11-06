namespace Practica
{
    partial class IniciApp
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnComencar;
        private System.Windows.Forms.Button btnJaTincCompte;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnComencar = new System.Windows.Forms.Button();
            this.btnJaTincCompte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // btnComencar
            this.btnComencar.Location = new System.Drawing.Point(50, 40);
            this.btnComencar.Size = new System.Drawing.Size(200, 40);
            this.btnComencar.Text = "Començar";
            this.btnComencar.Click += new System.EventHandler(this.btnComencar_Click);
            // btnJaTincCompte
            this.btnJaTincCompte.Location = new System.Drawing.Point(50, 100);
            this.btnJaTincCompte.Size = new System.Drawing.Size(200, 40);
            this.btnJaTincCompte.Text = "Ja tinc un compte";
            this.btnJaTincCompte.Click += new System.EventHandler(this.btnJaTincCompte_Click);
            // IniciApp form
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.btnJaTincCompte);
            this.Controls.Add(this.btnComencar);
            this.Name = "IniciApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inici App";
            this.ResumeLayout(false);
        }
    }
}
