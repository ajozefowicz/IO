﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka1
{
    public partial class Form1_Biblioteka : Form
    {
        public Form1_Biblioteka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2_PanelPracownika p = new Form2_PanelPracownika();
            p.Show();
        }

        private void button2_Log_Czytelnik_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3_PanelCzytelnika p = new Form3_PanelCzytelnika();
            p.Show();
        }
    }
}
