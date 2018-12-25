using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using biblioteka1.ServiceReference1;
using biblioteka1.ServiceReference2;
using WcfWypozyczeniaDoBazy;

using WcfKsiazkaDoBazy4;
using biblioteka1.ServiceReference3;
//using.biblioteka1.ServiceReference4;

namespace biblioteka1
{
    public partial class Form3_PanelCzytelnika : Form
    {

        //WCFKsiazkaDataSet wc = new WCFKsiazkaDataSet();

        


        WcfKsiazkaDoBazy4.Service1 sc;

        public Form3_PanelCzytelnika()
        {
            InitializeComponent();

            sc = new WcfKsiazkaDoBazy4.Service1();
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



            //listBox_ksiazkiWybrane.DataSource = sc.FillListBoxKsiazkiWybranePrzezUsera(key);

            dataGridView_ksiazki.DataSource = sc.FillListBoxKsiazkiWybranePrzezUsera(key);


        }

        private void textBox_imieAutora_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Wypozycz_Click(object sender, EventArgs e)
        {
            ServiceReference4.Ksiazka ks = new ServiceReference4.Ksiazka();

            //ks = listBox_ksiazkiWybrane.SelectedItem as ServiceReference1.Ksiazka;// to nie działa, po wybraniu wiersza na ekranie jest nullem


            string key1 = dataGridView_ksiazki.CurrentRow.Cells["id"].Value.ToString();

            //int key2 = listBox_ksiazkiWybrane.



            ServiceReference3.Wypozyczenie w = new ServiceReference3.Wypozyczenie();
            //w.id = 0; // jak zrobic by się nadpisywało
            w.idKsiazki =  Convert.ToInt32(key1); // = ks.id nie działa, bo wybrany wiersz jest nulem, wiec zamiast listBox, dataGridView
            w.idUsera = textBox_IdUsera.Text; // to na probe, zmienić by pobierało
            w.dataWypozyczyenia = DateTime.UtcNow.ToLocalTime();
            w.dataZwrotu = DateTime.UtcNow.ToLocalTime(); // jak tu zrobic nulla
            w.czyAktualne = true; //w momencie wypozyczenia - true, jak będziemy zwracac to zmiana na false 

            ServiceReference3.Service1Client service = new ServiceReference3.Service1Client();


            // tu jeszcze trzeba zmienic stan oryginalnej ksiazki na niedostępna czyli update dodac do funkcji wypozyczenia i date trza zmienic



            if(service.InsertWypozyczenie(w) ==1)
            {
                MessageBox.Show("Ksiazka wypozyczona");
            }
            

        }

        private void button_dodajDoUlubionych_Click(object sender, EventArgs e)
        {
            // trza gdzieś zrobic pole ulubioneDla i tam np podawac id usera, w książce nie - bo moze bnyc wielu userów a pole 1, 
            //w wypozyczeniach też nie bo nie musiał wypozyczyć by dodać do ulubioncyh - no w ostateczności tak sie zrobi
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //zwróc
            //wybiera poprzez wybór na liście
            //jak zwroci to zmianie ulega status w ksiazce i w wypozyczeniu zmienia się na archiwalne i nowa data zwrotu się pojawia - update
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
