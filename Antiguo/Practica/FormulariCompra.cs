using System;
using System.Windows.Forms;

namespace Practica
{
    public partial class FormulariCompra : Form
    {
        public FormulariCompra()
        {
            InitializeComponent();
        }

        private void FormulariCompra_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "Coche F1", "Casco", "Mono de piloto", "Guantes" });
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new string[] { "Tarjeta", "Efectivo", "Transferencia" });
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text)) { MessageBox.Show("Introdueix el teu nom."); return; }
            if (string.IsNullOrWhiteSpace(txtEmail.Text)) { MessageBox.Show("Introdueix el teu email."); return; }
            if (string.IsNullOrWhiteSpace(txtTelefon.Text)) { MessageBox.Show("Introdueix el teu telèfon."); return; }
            if (comboBox1.SelectedIndex == -1) { MessageBox.Show("Selecciona un producte."); return; }
            if (numQuantitat.Value <= 0) { MessageBox.Show("Introdueix una quantitat vàlida."); return; }
            if (string.IsNullOrWhiteSpace(txtDireccio.Text)) { MessageBox.Show("Introdueix una direcció."); return; }
            if (comboBox2.SelectedIndex == -1) { MessageBox.Show("Selecciona un mètode de pagament."); return; }
            if (!chkTerms.Checked) { MessageBox.Show("Has d'acceptar els termes i la privacitat."); return; }

            MessageBox.Show("Comanda processada correctament!", "Èxit");
        }
    }
}
