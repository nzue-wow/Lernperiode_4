using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswortManager
{
    public partial class SavedPasswords : Form
    {
        public SavedPasswords()
        {
            InitializeComponent();
            LoadPasswords();
        }

        private void LoadPasswords()
        {
            this.Controls.Clear();  
            int yPosition = 20;

            foreach (var entry in Form1.passwortListe)
            {
                Label label = new Label();
                label.Text = $"{entry.Website}: {entry.Passwort}";
                label.AutoSize = true;
                label.Location = new System.Drawing.Point(20, yPosition);

                this.Controls.Add(label);
                yPosition += 30;
            }
        }
    }
}
