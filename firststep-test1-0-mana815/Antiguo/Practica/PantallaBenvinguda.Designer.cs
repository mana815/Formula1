using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practica
{
    public partial class PantallaBenvinguda : Form
    {
        // Constructor
        public PantallaBenvinguda()
        {
            InitializeComponent();
            ConfigurarEstilo();
        }

        // Método que configura el estilo del formulario
        private void ConfigurarEstilo()
        {
            this.Text = "F1Turbo - Bienvenida";
            this.Size = new Size(350, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White; // Fondo blanco

            // Título principal
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Text = "TurboF1";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Location = new Point(75, 30);
            lblTitulo.Size = new Size(200, 50);

            // Subtítulo: ¡Bienvenido!
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Text = "¡Benvingut!";
            label3.Location = new Point(109, 85);
            label3.Size = new Size(130, 30);

            // Descripción corta
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            label2.ForeColor = Color.Black;
            label2.Text = "Prepara't per sentir l'adrenalina de cada volta, seguir totes les curses en temps real i descobrir estadístiques exclusives dels teus pilots i equips preferits.";
            label2.Location = new Point(35, 120);
            label2.Size = new Size(270, 60);

            // Botón principal: Començar
            button1.BackColor = Color.FromArgb(58, 134, 255);
            button1.ForeColor = Color.White;
            button1.Text = "Començar";
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(85, 200);
            button1.Size = new Size(170, 38);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Cursor = Cursors.Hand;
            button1.Click += Button1_Click;

            // Botón cuenta
            label1.BackColor = Color.Gainsboro;
            label1.ForeColor = Color.Black;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Text = "Ja tinc un compte";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Location = new Point(85, 250);
            label1.Size = new Size(170, 30);

            // (Opcional) Puedes convertir label1 en botón si lo prefieres: 
            // O simplemente añade otro Button y elimina esta config de label1.
        }

        // Método que inicializa los controles (simplificado)
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaBenvinguda));
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(120, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "TurboF1";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Iniciar Sesion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(117, 419);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Terminos de condiciones";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(156, 53);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(59, 57);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(127, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Registrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "¡Benvingut!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PantallaBenvinguda
            // 
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(367, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox);
            this.Name = "PantallaBenvinguda";
            this.Load += new System.EventHandler(this.PantallaBenvinguda_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pantalla de registro o nueva cuenta...");
        }
        private Label label4;
        private Button button2;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox;
        private Button button1;
        private Button button3;
        private Label label1;
    }
}
