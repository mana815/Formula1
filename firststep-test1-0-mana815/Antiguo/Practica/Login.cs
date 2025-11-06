using System;
using System.Windows.Forms;

namespace Practica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Usuario de prueba admin/admin
            if (txtUser.Text == "admin" && txtPass.Text == "admin")
            {
                var menu = new MenuPrincipal();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuari o contrasenya incorrectes.", "Error");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Volver a pantalla de bienvenida
            var pb = new PantallaBenvinguda();
            pb.Show();
            this.Hide();
        }
    }
}
