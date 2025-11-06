namespace Practica
{
    partial class FormulariCompra
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.CheckBox chkTerms;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numQuantitat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulariCompra));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.chkTerms = new System.Windows.Forms.CheckBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numQuantitat = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantitat)).BeginInit();
            this.SuspendLayout();
            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Benvingut";
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(62, 155);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 20);
            this.txtEmail.TabIndex = 2;
            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // txtNom
            this.txtNom.Location = new System.Drawing.Point(62, 116);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(220, 20);
            this.txtNom.TabIndex = 4;
            // chkTerms
            this.chkTerms.AutoSize = true;
            this.chkTerms.Location = new System.Drawing.Point(79, 421);
            this.chkTerms.Name = "chkTerms";
            this.chkTerms.Size = new System.Drawing.Size(173, 17);
            this.chkTerms.TabIndex = 5;
            this.chkTerms.Text = "Acepto els Terminis y Privacitat";
            this.chkTerms.UseVisualStyleBackColor = true;
            // btnProcesar
            this.btnProcesar.Location = new System.Drawing.Point(118, 392);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(106, 23);
            this.btnProcesar.TabIndex = 6;
            this.btnProcesar.Text = "Procesar Pedido";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // pictureBox
            this.pictureBox.BackColor = System.Drawing.Color.LightGray;
            // Si tienes una imagen real en Resources, descomenta esta línea:
            // this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(141, 39);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(59, 57);
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telèfon";
            // txtTelefon
            this.txtTelefon.Location = new System.Drawing.Point(62, 194);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(220, 20);
            this.txtTelefon.TabIndex = 11;
            // label5
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Producte";
            // comboBox1
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 233);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 21);
            this.comboBox1.TabIndex = 14;
            // label6
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quantitat";
            // numQuantitat
            this.numQuantitat.Location = new System.Drawing.Point(62, 273);
            this.numQuantitat.Name = "numQuantitat";
            this.numQuantitat.Size = new System.Drawing.Size(220, 20);
            this.numQuantitat.TabIndex = 17;
            // label7
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Direcció";
            // txtDireccio
            this.txtDireccio.Location = new System.Drawing.Point(62, 312);
            this.txtDireccio.Name = "txtDireccio";
            this.txtDireccio.Size = new System.Drawing.Size(220, 20);
            this.txtDireccio.TabIndex = 19;
            // label8
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Pago";
            // comboBox2
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(62, 351);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(220, 21);
            this.comboBox2.TabIndex = 21;
            // FormulariCompra form
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDireccio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numQuantitat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.chkTerms);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormulariCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulari de Compra";
            this.Load += new System.EventHandler(this.FormulariCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantitat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
