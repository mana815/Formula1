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
    public partial class cmbPago : Form
    {
        public cmbPago()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtNom.Text;

            if (usuario == "f1user" && clave == "1234")
            {
                MessageBox.Show("¡Bienvenido al sistema F1!");
                // Aquí puedes abrir la ventana principal o cerrar el login.
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta.");
            }
            if (!chkTerms.Checked)
            {
                MessageBox.Show("Debes aceptar los términos.");
                return;
            }

private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cmbPago));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkTerms = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuari";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 249);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.btnProcesar.Location = new System.Drawing.Point(150, 318);
            this.btnProcesar.Name = "button1";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "Continua";
            this.btnProcesar.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(166, 32);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(59, 57);
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(78, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "¡Benvingut a F1!";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkTerms
            // 
            this.checkTerms.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.checkTerms.AutoSize = true;
            this.checkTerms.Location = new System.Drawing.Point(145, 367);
            this.checkTerms.Name = "checkTerms";
            this.checkTerms.Size = new System.Drawing.Size(80, 17);
            this.checkTerms.TabIndex = 12;
            this.checkTerms.Text = "checkBox1";
            this.checkTerms.UseVisualStyleBackColor = true;
            this.checkTerms.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(374, 436);
            this.Controls.Add(this.checkTerms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }