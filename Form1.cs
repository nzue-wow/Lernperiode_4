﻿using System;
using System.Collections.Generic;
using System.IO;  
using System.Windows.Forms;
using Newtonsoft.Json;  

namespace PasswortManager
{
    

    public partial class Form1 : Form
    {
        

        public static List<(string Website, string Passwort)> passwortListe = new List<(string, string)>();

        

        public Form1()
        {
            InitializeComponent();
            Form1.LoadPasswords();  
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);  
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.SavePasswords();  // Passwörter beim Schließen speichern
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EingabePasswort().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SavedPasswords().ShowDialog();
        }

        // Methode zum Speichern der Passwörter
        public static void SavePasswords()
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "passwords.json");  // Speicherort

                
                string json = JsonConvert.SerializeObject(passwortListe, Formatting.Indented);

                
                File.WriteAllText(filePath, json);
                MessageBox.Show("Passwörter wurden gespeichert!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern: {ex.Message}");
            }
        }

        // Methode zum Laden der Passwörter
        public static void LoadPasswords()
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "passwords.json");

                if (File.Exists(filePath))
                {
                   
                    string json = File.ReadAllText(filePath);

                    
                    passwortListe = JsonConvert.DeserializeObject<List<(string Website, string Passwort)>>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden: {ex.Message}");
            }
        }
    }
}
