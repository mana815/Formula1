using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // Abre la pantalla de registro o siguiente paso
            var formNou = new FormNouUsuari();
            formNou.Show();
            this.Hide();
        }
        private void btnJaTincCompte_Click(object sender, EventArgs e)
        {
            // Abre la pantalla de login
            var formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }
    }
}
