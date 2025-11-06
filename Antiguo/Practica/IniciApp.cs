using System;
using System.Windows.Forms;

namespace Practica
{
    public partial class IniciApp : Form
    {
        public IniciApp()
        {
            InitializeComponent();
        }

        private void btnComencar_Click(object sender, EventArgs e)
        {
            // Abrir formulario nuevo / por ahora mostrar mensaje
            MessageBox.Show("Acció Començar (IniciApp) - funcionalitat a implementar.");
        }

        private void btnJaTincCompte_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
