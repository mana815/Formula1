namespace Practica
{
    partial class Llista
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxItems;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // listBoxItems
            this.listBoxItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxItems.Items.AddRange(new object[] {
            "Coche F1",
            "Casco",
            "Mono de piloto",
            "Guantes"});
            // Llista form
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.listBoxItems);
            this.Name = "Llista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Llista de Productes";
            this.ResumeLayout(false);
        }
    }
}
