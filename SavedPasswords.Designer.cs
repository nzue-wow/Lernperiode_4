﻿namespace PasswortManager
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPasswords
            // 
            this.listBoxPasswords.FormattingEnabled = true;
            this.listBoxPasswords.ItemHeight = 25;
            this.listBoxPasswords.Location = new System.Drawing.Point(20, 20);
            this.listBoxPasswords.Name = "listBoxPasswords";
            this.listBoxPasswords.Size = new System.Drawing.Size(760, 379);
            this.listBoxPasswords.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(673, 392);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(107, 46);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // SavedPasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxPasswords);
            this.Name = "SavedPasswords";
            this.Text = "Gespeicherte Passwörter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
    }
}
