using System;
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
    public partial class Form3_PanelCzytelnika : Form
    {
        public Form3_PanelCzytelnika()
        {
            InitializeComponent();
        }

        private void button1_powrotDoGlownego_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1_Biblioteka p = new Form1_Biblioteka();
            p.Show();

        }
    }
}
