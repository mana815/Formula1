using System;
using System.Windows.Forms;

namespace Practica
{
    public partial class PantallaBenvinguda : Form
    {
        public PantallaBenvinguda()
        {
            InitializeComponent();
        }

        private void PantallaBenvinguda_Load(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            // "Iniciar Sessió" -> abre Login
            var login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Registrar (placeholder)
            MessageBox.Show("Funcionalidad de registro próximamente disponible.", "Registrar");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Términos y condiciones.", "Términos");
        }

        private void label4_Click(object sender, EventArgs e) { }
        private void pictureBox_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}
