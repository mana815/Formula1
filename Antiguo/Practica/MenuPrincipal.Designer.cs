namespace Practica
{
    partial class MenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnLlista;
        private System.Windows.Forms.Button btnSortir;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnLlista = new System.Windows.Forms.Button();
            this.btnSortir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // labelTitulo
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.Location = new System.Drawing.Point(60, 30);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(160, 25);
            this.labelTitulo.Text = "Menú Principal";
            // btnComprar
            this.btnComprar.Location = new System.Drawing.Point(60, 80);
            this.btnComprar.Size = new System.Drawing.Size(160, 35);
            this.btnComprar.Text = "Formulari de Compra";
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // btnLlista
            this.btnLlista.Location = new System.Drawing.Point(60, 130);
            this.btnLlista.Size = new System.Drawing.Size(160, 35);
            this.btnLlista.Text = "Veure Llista";
            this.btnLlista.Click += new System.EventHandler(this.btnLlista_Click);
            // btnSortir
            this.btnSortir.Location = new System.Drawing.Point(60, 180);
            this.btnSortir.Size = new System.Drawing.Size(160, 35);
            this.btnSortir.Text = "Sortir";
            this.btnSortir.Click += new System.EventHandler(this.btnSortir_Click);
            // MenuPrincipal form
            this.ClientSize = new System.Drawing.Size(300, 260);
            this.Controls.Add(this.btnSortir);
            this.Controls.Add(this.btnLlista);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.labelTitulo);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
