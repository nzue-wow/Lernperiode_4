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
    public partial class Form1 : Form
    {
        public static List<(string Website, string Passwort)> passwortListe = new List<(string, string)>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSavedPasswords_Click(object sender, EventArgs e)
        {
            SavedPasswords savedPasswords = new SavedPasswords();
            savedPasswords.Show();  
            
        }

        private void buttonSaveNewPassword_Click(object sender, EventArgs e)
        {
            EingabePasswort eingabePasswort = new EingabePasswort();
            eingabePasswort.Show();
        }

    }
}
