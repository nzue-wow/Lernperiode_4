﻿using System;
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
    public partial class EingapePasw : Form
    {
        public EingapePasw()
        {
            InitializeComponent();
            string[] Passwörter = new string[10];
            Passwörter = System.Convert.ToString(Console.ReadLine(textBox1)); 
        }
    }
}
