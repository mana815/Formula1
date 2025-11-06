namespace Practica
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // labelUser
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(50, 50);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(40, 13);
            this.labelUser.Text = "Usuari";
            // txtUser
            this.txtUser.Location = new System.Drawing.Point(50, 70);
            this.txtUser.Size = new System.Drawing.Size(200, 20);
            this.txtUser.Name = "txtUser";
            // labelPass
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(50, 110);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(67, 13);
            this.labelPass.Text = "Contrasenya";
            // txtPass
            this.txtPass.Location = new System.Drawing.Point(50, 130);
            this.txtPass.Size = new System.Drawing.Size(200, 20);
            this.txtPass.Name = "txtPass";
            this.txtPass.UseSystemPasswordChar = true;
            // btnEntrar
            this.btnEntrar.Location = new System.Drawing.Point(50, 170);
            this.btnEntrar.Size = new System.Drawing.Size(90, 30);
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // btnCancelar
            this.btnCancelar.Location = new System.Drawing.Point(160, 170);
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.Text = "Cancel·lar";
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // Login form
            this.ClientSize = new System.Drawing.Size(320, 250);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.labelUser);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
