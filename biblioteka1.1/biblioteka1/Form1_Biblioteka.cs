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
    public partial class Form1_Biblioteka : Form
    {

        WcfUserDoBazy.AdministracjaUzytkownikiem scUzytkownik;

        public Form1_Biblioteka()
        {
            InitializeComponent();

            scUzytkownik = new WcfUserDoBazy.AdministracjaUzytkownikiem();

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


            string hello = textBox1_loginCzytelnika.Text;

            p.pobierzNazweUseraDoPowitania(hello);
           

            p.pobierzLimiUseraDoPanelu();

            p.pobierzMaxCzasWypozyczeniaUseraDoPanelu();

            // string idUzytkownika = label7_witajUserName.Text; // wolalabym labela, ale niestwty nie odczytuje poprawnie :/

            

            /*
            textBox_IdUsera.Text = "ananan";

            p.pobierzNazweUsera();

            listBoxKsiazki.DataSource = "nanana";
            //p.pobierzNazweUsera();

            */


        }

        private void Form1_Biblioteka_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public string pobierzNazweUsera()
        {
            return textBox1_loginCzytelnika.Text;

        }
    }
}
