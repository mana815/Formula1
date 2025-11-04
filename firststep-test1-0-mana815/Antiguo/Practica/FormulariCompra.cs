using System;
using System.Windows.Forms;

namespace Practica
{
    public partial class cmbPago : Form
    {
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbPago_Load(object sender, EventArgs e)
        {

        }namespace Practica
    {
        public partial class Login : Form
        {
            private Label lblTitle;
            private Label lblEmail;
            private Label lblPassword;
            private TextBox txtEmail;
            private TextBox txtPassword;
            private CheckBox chkTerms;
            private Button btnContinue;
            private LinkLabel linkSignIn;

            public Login()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                // Labels
                lblTitle = new Label();
                lblEmail = new Label();
                lblPassword = new Label();
                txtEmail = new TextBox();
                txtPassword = new TextBox();
                chkTerms = new CheckBox();
                btnContinue = new Button();
                linkSignIn = new LinkLabel();

                // 
                // lblTitle
                // 
                lblTitle.Text = "Benvingut";
                lblTitle.Font = new System.Drawing.Font("Arial", 20F);
                lblTitle.AutoSize = true;
                lblTitle.Location = new System.Drawing.Point(130, 20);

                // 
                // lblEmail
                // 
                lblEmail.Text = "Email:";
                lblEmail.Location = new System.Drawing.Point(50, 70);
                lblEmail.AutoSize = true;

                // 
                // txtEmail
                // 
                txtEmail.Location = new System.Drawing.Point(110, 70);
                txtEmail.Size = new System.Drawing.Size(200, 20);

                // 
                // lblPassword
                // 
                lblPassword.Text = "Contraseña:";
                lblPassword.Location = new System.Drawing.Point(50, 110);
                lblPassword.AutoSize = true;

                // 
                // txtPassword
                // 
                txtPassword.Location = new System.Drawing.Point(110, 110);
                txtPassword.Size = new System.Drawing.Size(200, 20);
                txtPassword.UseSystemPasswordChar = true;

                // 
                // chkTerms
                // 
                chkTerms.Text = "Acepto los Términos y Privacidad";
                chkTerms.Location = new System.Drawing.Point(50, 150);
                chkTerms.AutoSize = true;

                // 
                // btnContinue
                // 
                btnContinue.Text = "Continue";
                btnContinue.Location = new System.Drawing.Point(150, 190);
                btnContinue.Click += BtnContinue_Click;

                // 
                // linkSignIn
                // 
                linkSignIn.Text = "Sign In";
                linkSignIn.Location = new System.Drawing.Point(190, 230);
                linkSignIn.Click += LinkSignIn_Click;

                // 
                // Formulario Login
                // 
                this.Text = "Login F1";
                this.ClientSize = new System.Drawing.Size(370, 280);
                this.Controls.Add(lblTitle);
                this.Controls.Add(lblEmail);
                this.Controls.Add(txtEmail);
                this.Controls.Add(lblPassword);
                this.Controls.Add(txtPassword);
                this.Controls.Add(chkTerms);
                this.Controls.Add(btnContinue);
                this.Controls.Add(linkSignIn);
                this.StartPosition = FormStartPosition.CenterScreen;
            }

            private void BtnContinue_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Introduce tu correo.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Introduce tu contraseña.");
                    return;
                }
                if (!chkTerms.Checked)
                {
                    MessageBox.Show("Debes aceptar los Términos y Privacidad.");
                    return;
                }
                MessageBox.Show("¡Bienvenido a F1!");
            }

            private void LinkSignIn_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Funcionalidad de registro no implementada.");
            }

            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.Run(new Login());
            }
        }
    }
}