using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Windows.Forms;

namespace PasswortManager
{
    public partial class LoginForm : Form
    {
        private string korrektesPasswort = "MeinSicheresPasswort";  // Passwort 

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxPasswort.Text == korrektesPasswort)
            {
                this.Hide();
                Form1 hauptfenster = new Form1();
                hauptfenster.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Falsches Passwort!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

