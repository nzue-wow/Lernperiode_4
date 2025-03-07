namespace PasswortManager
{
    partial class SavedPasswords
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxPasswords;  // <--- NEU HINZUGEFÜGT

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.listBoxPasswords = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // ListBox Eigenschaften
            this.listBoxPasswords.FormattingEnabled = true;
            this.listBoxPasswords.Location = new System.Drawing.Point(20, 20);
            this.listBoxPasswords.Size = new System.Drawing.Size(760, 400);

            // ListBox dem Fenster hinzufügen
            this.Controls.Add(this.listBoxPasswords);

            // Fenster-Einstellungen
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Gespeicherte Passwörter";

            this.ResumeLayout(false);
        }

        #endregion
    }
}
