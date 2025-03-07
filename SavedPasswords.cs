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
            if (listBoxPasswords == null)
            {
                MessageBox.Show("Fehler: listBoxPasswords existiert nicht!");
                return;
            }

            

            foreach (var entry in Form1.passwortListe)
            {
                listBoxPasswords.Items.Add($"{entry.Website}: {entry.Passwort}");
            }
        }


    }
}

