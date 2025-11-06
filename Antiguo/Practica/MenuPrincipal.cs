using System;
using System.Windows.Forms;

namespace Practica
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            var compra = new FormulariCompra();
            compra.Show();
        }

        private void btnLlista_Click(object sender, EventArgs e)
        {
            var llista = new Llista();
            llista.Show();
        }

        private void btnSortir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
