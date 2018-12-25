using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using biblioteka1.ServiceReference1;
using biblioteka1.ServiceReference2;
using WcfKsiazkaDoBazy;

namespace biblioteka1
{
    public partial class Form3_PanelCzytelnika : Form
    {

        WCFKsiazkaDataSet wc = new WCFKsiazkaDataSet();


        WcfKsiazkaDoBazy.Service1 sc;

        public Form3_PanelCzytelnika()
        {
            InitializeComponent();

            sc = new WcfKsiazkaDoBazy.Service1();
        }

        private void button1_powrotDoGlownego_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1_Biblioteka p = new Form1_Biblioteka();
            p.Show();

        }

        private void button_pokazKsiazki_Click(object sender, EventArgs e)
        {

            listBoxKsiazki.DataSource = sc.FillListBoxKsiazki();



           // dataGridView_ksiazki.DataSource = sc.FillListBoxKsiazki(); // przemyslec jak to tu działa



        }

        private void button_pokazKsiazkiTabela_Click(object sender, EventArgs e)
        {

            //listBoxKsiazki.DataSource = sc.FillListBoxKsiazki();


            //this.dataGridView_ksiazki.Columns["@licznikWypozyczen"].Visible = false;

            //DataGridView bierze kolumny z klasy książka, nie z bazy 

            //  dataGridView_ksiazki.Columns[1].Visible = false;


            dataGridView_ksiazki.DataSource = sc.FillListBoxKsiazkiTabela();


            //dataGridView_ksiazki.DataBind();


        }

        private void Form3_PanelCzytelnika_Load(object sender, EventArgs e)
        {

        }

        private void button_Wyszukaj_Click(object sender, EventArgs e)
        {


            string key=null;

            string key_imie = textBox_imieAutora.Text;
            string key_nazwisko = textBox_nazwiskoAutora.Text;
            string key_tytul = textBox_tytul.Text;
            string key_isbn = textBox_nrISBN.Text;



            //kombinacje 1 - elementowe


            //jesli wypelnione pole imie
            if (key_nazwisko.Length==0 && key_tytul.Length==0 && key_isbn.Length==0)
            key = " CONVERT(VARCHAR, imieAutora)  like '" + key_imie +  "'"; //= czy like? lepiej = i konversja na varchar

            //jesli wpelnione pole nazwisko
            else if (key_imie.Length == 0 && key_tytul.Length == 0 && key_isbn.Length == 0)
            key = " CONVERT(VARCHAR, nazwiskoAutora)  like '" + key_nazwisko + "'";

            //jesli wypelnione tytul
            else if (key_imie.Length == 0 && key_nazwisko.Length == 0 && key_isbn.Length == 0)
            key = " CONVERT(VARCHAR, tytul)  like '" + key_tytul + "'";

            //jesli wypelnione isbn
            else if (key_imie.Length == 0 && key_nazwisko.Length == 0 && key_tytul.Length == 0)
                key = " CONVERT(VARCHAR, nrISBN)  like '" + key_isbn + "'";

            //kombinacje dwuelementowe

            // imie i nazwisko
            else if (key_tytul.Length == 0 && key_isbn.Length == 0)
                key = "  CONVERT(VARCHAR, imieAutora)  = '" + key_imie + " ' and CONVERT(VARCHAR, nazwiskoAutora) = '" + key_nazwisko + "'";

            //imie, tytul
            else if (key_nazwisko.Length == 0 && key_isbn.Length == 0)
                key = "  CONVERT(VARCHAR, imieAutora)  = '" + key_imie + " ' and CONVERT(VARCHAR, tytul) = '" + key_tytul + "'";

            //imie, isbn
            else if (key_tytul.Length == 0 && key_nazwisko.Length == 0)
                key = "  CONVERT(VARCHAR, imieAutora)  = '" + key_imie + " ' and CONVERT(VARCHAR, nrISBN) = '" + key_isbn + "'";


            //nazwisko, isbn
            else if (key_imie.Length == 0 && key_tytul.Length == 0)
                // key = "  CONVERT(VARCHAR, nazwiskoAutora)  = '" + key_nazwisko + " ' and CONVERT(VARCHAR, nrISBN) = '" + key_isbn + "'";
                key = "  CONVERT(VARCHAR, nazwiskoAutora)  = '" + key_nazwisko + " ' and CONVERT(VARCHAR, nrISBN) = '" + key_isbn + "'";


            //nazwisko, tytul //spr ???????????????????????????????

            else if (key_imie.Length == 0 && key_isbn.Length == 0)
                key = "  CONVERT(VARCHAR, nazwiskoAutora)  = '" + key_nazwisko + " ' and CONVERT(VARCHAR, tytul) = '" + key_tytul + "'";




            //tytul, isbn
            else if (key_imie.Length == 0 && key_nazwisko.Length == 0)
                key = "  CONVERT(VARCHAR, tytul)  = '" + key_tytul + " ' and CONVERT(VARCHAR, nrISBN) = '" + key_isbn + "'";



            //kombinacje 3 -elementowe

            //imie, nazwisko, tytul
            else if (key_isbn.Length == 0)
                key = "  CONVERT(VARCHAR, imieAutora)  = '" + key_imie + " ' and CONVERT(VARCHAR, nazwiskoAutora) = '" + key_nazwisko +  " ' and CONVERT(VARCHAR, tytul) = '" + key_tytul + "'";

            //imie, nazwisko, isbn
            else if (key_tytul.Length == 0)
                key = "  CONVERT(VARCHAR, imieAutora)  = '" + key_imie + " ' and CONVERT(VARCHAR, nazwiskoAutora) = '" + key_nazwisko + " ' and CONVERT(VARCHAR, nrISBN) = '" + key_isbn + "'";

            //imie, tytul, isbn
            else if (key_nazwisko.Length == 0)
                key = "  CONVERT(VARCHAR, imieAutora)  = '" + key_imie + " ' and CONVERT(VARCHAR, tytul) = '" + key_tytul + " ' and CONVERT(VARCHAR, nrISBN) = '" + key_isbn + "'";

 
            //nazwisko, tytul, isbn
            else if (key_imie.Length == 0)
                key = "  CONVERT(VARCHAR, tytul)  = '" + key_tytul + " ' and CONVERT(VARCHAR, nazwiskoAutora) = '" + key_nazwisko + " ' and CONVERT(VARCHAR, nrISBN) = '" + key_isbn + "'";




            //cztero
            //autora, nazwisko, tytul, isbn
            else
                key = "  CONVERT(VARCHAR, imieAutora)  = '" + key_imie + " ' and CONVERT(VARCHAR, nazwiskoAutora) = '" + key_nazwisko  +" ' and CONVERT(VARCHAR, nrISBN) = '" + key_isbn + " ' and CONVERT(VARCHAR, tytul) = '" + key_tytul + "'";














            listBox_ksiazkiWybrane.DataSource = sc.FillListBoxKsiazkiWybranePrzezUsera(key);


        }

        private void textBox_imieAutora_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
