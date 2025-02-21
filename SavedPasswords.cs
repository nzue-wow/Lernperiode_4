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
        private string[] savedPasswords = { "save123", "secure?12", "admin124" };
        public SavedPasswords()
        {
            InitializeComponent();
            LoadPasswords();
        }

        private void LoadPasswords()
        {

            int yPosition = 20; // Abstand nach oben

            foreach (string password in savedPasswords)
            {
                Label label = new Label();
                label.Text = password;
                label.AutoSize = true;
                label.Location = new System.Drawing.Point(20, yPosition);

                this.Controls.Add(label);
                yPosition += 30;


            }
        }
    }
}
