﻿using System;
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

        WcfWypozyczeniaDoBazy.Service1 scWypozyczenie;

        public Form3_PanelCzytelnika()
        {
            InitializeComponent();

            sc = new WcfKsiazkaDoBazy4.Service1();

            scWypozyczenie = new WcfWypozyczeniaDoBazy.Service1();

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


            //najpierw sprawdzamy czy ksiazka dostępna

            if (Convert.ToBoolean(dataGridView_ksiazki.CurrentRow.Cells["stan"].Value.ToString()) == true)

            {

                ServiceReference3.Wypozyczenie w = new ServiceReference3.Wypozyczenie();
                w.idKsiazki = Convert.ToInt32(key1); // pcja = ks.id nie działa, bo wybrany wiersz jest nulem, wiec zamiast listBox, dataGridView
                w.idUsera = textBox_witajUser.Text;     //label7_witaJUser.Text;   //textBox_IdUsera.Text; // to na probe, zmienić by pobierało
                w.dataWypozyczyenia = DateTime.UtcNow.ToLocalTime();
                w.dataZwrotu = DateTime.UtcNow.ToLocalTime().AddDays(14); // jak tu zrobic nulla
                w.czyAktualne = true; //w momencie wypozyczenia - true, jak będziemy zwracac to zmiana na false 

                ServiceReference3.Service1Client service = new ServiceReference3.Service1Client();

                /////



                Ksiazka nowa = new Ksiazka();
                Ksiazka stara = new Ksiazka();

                /*
                //stara.id = Convert.ToInt32(dataGridView_ksiazki.CurrentRow.Cells["id"].Value.ToString());
                stara.dataWypozyczenia = Convert.ToDateTime(dataGridView_ksiazki.CurrentRow.Cells["dataWypozyczenia"].Value.ToString());
                stara.dataZwrotu = Convert.ToDateTime(dataGridView_ksiazki.CurrentRow.Cells["dataZwrotu"].Value.ToString());
                stara.stan = Convert.ToBoolean(dataGridView_ksiazki.CurrentRow.Cells["stan"].Value.ToString());


                stara.tytul = dataGridView_ksiazki.CurrentRow.Cells["tytul"].Value.ToString();
                stara.rodzaj = dataGridView_ksiazki.CurrentRow.Cells["rodzaj"].Value.ToString();
                stara.licznikWypozyczen = Convert.ToInt32(dataGridView_ksiazki.CurrentRow.Cells["licznikWypozyczen"].Value.ToString());
                stara.licznikPrzedluzen = Convert.ToInt32(dataGridView_ksiazki.CurrentRow.Cells["licznikPrzedluzen"].Value.ToString());
                stara.iloscStron = Convert.ToInt32(dataGridView_ksiazki.CurrentRow.Cells["iloscStron"].Value.ToString());
                stara.imieAutora = dataGridView_ksiazki.CurrentRow.Cells["imieAutora"].Value.ToString();
                stara.nazwiskoAutora = dataGridView_ksiazki.CurrentRow.Cells["nazwiskoAutora"].Value.ToString();
                stara.nrISBN = dataGridView_ksiazki.CurrentRow.Cells["nrISBN"].Value.ToString();
                */


                //parametry, ktore ulegaja zmianie przy wypozyczeniu
                //nowa.id = Convert.ToInt32(dataGridView_ksiazki.CurrentRow.Cells["id"].Value.ToString());
                nowa.dataWypozyczenia = DateTime.UtcNow.ToLocalTime();
                nowa.dataZwrotu = (DateTime.UtcNow.ToLocalTime().AddDays(14)); //+14 dni jako prognozowana data zwrotu
                nowa.stan = false;
                nowa.licznikWypozyczen = Convert.ToInt32(dataGridView_ksiazki.CurrentRow.Cells["licznikWypozyczen"].Value.ToString()) + 1;

                //a jeszcze licznik przedluzen by sprawdzac czy nie przekroczono limitu
                nowa.licznikPrzedluzen = 0;


                //parametry, które się nie zmieniają
                nowa.tytul = nowa.tytul = dataGridView_ksiazki.CurrentRow.Cells["tytul"].Value.ToString();
                nowa.rodzaj = dataGridView_ksiazki.CurrentRow.Cells["rodzaj"].Value.ToString();
               // nowa.licznikPrzedluzen = Convert.ToInt32(dataGridView_ksiazki.CurrentRow.Cells["licznikPrzedluzen"].Value.ToString());
                nowa.iloscStron = Convert.ToInt32(dataGridView_ksiazki.CurrentRow.Cells["iloscStron"].Value.ToString());
                nowa.imieAutora = dataGridView_ksiazki.CurrentRow.Cells["imieAutora"].Value.ToString();
                nowa.nazwiskoAutora = dataGridView_ksiazki.CurrentRow.Cells["nazwiskoAutora"].Value.ToString();
                nowa.nrISBN = dataGridView_ksiazki.CurrentRow.Cells["nrISBN"].Value.ToString();


                // update z WCFKiazka
                sc.UpdateNaWypozyczenie2(key1, nowa);


                //Insert z WCFWypozyczenie
                if (service.InsertWypozyczenie(w) == 1)
                {
                    MessageBox.Show("Ksiazka wypozyczona");
                }

                ///////////////////////////////
            }


            else
                MessageBox.Show("Ksiazka niedostępna, pusty kwadracik !!!");


        }

        private void button_dodajDoUlubionych_Click(object sender, EventArgs e)
        {
            // trza gdzieś zrobic pole ulubioneDla i tam np podawac id usera, w książce nie - bo moze bnyc wielu userów a pole 1, 
            //w wypozyczeniach też nie bo nie musiał wypozyczyć by dodać do ulubioncyh - no w ostateczności tak sie zrobi
        }

        private void button_zwroc_Click(object sender, EventArgs e) // uwaga zmieniona nazawa butona, jak by sie krzaczyło pamiętać
        {
            //zwróc
            //wybiera poprzez wybór na liście ksiazek usera
            //jak zwroci to zmianie ulega status w ksiazce i w wypozyczeniu zmienia się na archiwalne i nowa data zwrotu się pojawia - update

            string key = dataGridView_katalogUsera.CurrentRow.Cells["idKsiazki"].Value.ToString();

            string keyDoWstawienia = "  CONVERT(VARCHAR, id)  = '" + key + " '";


            //pooakzuje dane wybranej - bo tak
            //dataGridView_ksiazki.DataSource = sc.FillListBoxKsiazkiWybranePrzezUsera(key);
            dataGridView_wybrana.DataSource = sc.pokazDaneWybranejKsiazkiZKataloguUsera(keyDoWstawienia);




            //najpierw sprawdzamy czy ksiazka jest jako wypozyczenieAktualne w katalogu Usera

            if (Convert.ToBoolean(dataGridView_katalogUsera.CurrentRow.Cells["czyAktualne"].Value.ToString()) == true)

            {


                //update wypozyczenie

                WcfWypozyczeniaDoBazy.Wypozyczenie wypNowe = new WcfWypozyczeniaDoBazy.Wypozyczenie();

                //zmianie ulega data zwrotu i czyAktualne
                wypNowe.dataZwrotu = DateTime.UtcNow.ToLocalTime();
                wypNowe.czyAktualne = false;

                //zmienie nie ulegaja
                wypNowe.idUsera = dataGridView_katalogUsera.CurrentRow.Cells["idUsera"].Value.ToString();
                wypNowe.dataWypozyczyenia = Convert.ToDateTime(dataGridView_katalogUsera.CurrentRow.Cells["dataWypozyczyenia"].Value.ToString());


                //update wyp


                 scWypozyczenie.UpdateNaZwrot(key, wypNowe);



                //update Ksiazki z Iksiazka

                Ksiazka nowa = new Ksiazka();

                //parametry, ktore ulegaja zmianie przy zwrocie
                //nowa.id = Convert.ToInt32(dataGridView_ksiazki.CurrentRow.Cells["id"].Value.ToString());

                nowa.dataZwrotu = DateTime.UtcNow.ToLocalTime();
                nowa.stan = true;

                nowa.dataWypozyczenia = Convert.ToDateTime(dataGridView_katalogUsera.CurrentRow.Cells["dataWypozyczyenia"].Value.ToString());//DateTime.UtcNow.ToLocalTime();

               
                
                //troxhe na okrętke
                //parametry, które się nie zmieniają
                nowa.licznikWypozyczen = Convert.ToInt32(dataGridView_wybrana.CurrentRow.Cells["licznikWypozyczen"].Value.ToString()); //Convert.ToInt32(dataGridView_ksiazki.CurrentRow.Cells["licznikWypozyczen"].Value.ToString());
                //nowa.dataWypozyczenia = Convert.ToDateTime(dataGridView_wybrana.CurrentRow.Cells["dataWypozyczenia"].Value.ToString());//DateTime.UtcNow.ToLocalTime();
                nowa.tytul = nowa.tytul = dataGridView_wybrana.CurrentRow.Cells["tytul"].Value.ToString();
                nowa.rodzaj = dataGridView_wybrana.CurrentRow.Cells["rodzaj"].Value.ToString();
                nowa.licznikPrzedluzen = Convert.ToInt32(dataGridView_wybrana.CurrentRow.Cells["licznikPrzedluzen"].Value.ToString());
                nowa.iloscStron = Convert.ToInt32(dataGridView_wybrana.CurrentRow.Cells["iloscStron"].Value.ToString());
                nowa.imieAutora = dataGridView_wybrana.CurrentRow.Cells["imieAutora"].Value.ToString();
                nowa.nazwiskoAutora = dataGridView_wybrana.CurrentRow.Cells["nazwiskoAutora"].Value.ToString();
                nowa.nrISBN = dataGridView_wybrana.CurrentRow.Cells["nrISBN"].Value.ToString();
                

                //update ksiazka
                sc.UpdateNaZwrot(key, nowa);

                MessageBox.Show("ksiazka zwrócona");

            }


            else
                MessageBox.Show("Ksiazka juz została przez Ciebie zwrócona");


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_witajUserName_Click(object sender, EventArgs e)
        {

        }




        public void pobierzNazweUseraDoPowitania(string n)
        {

            //textBox_IdUsera.Text = n;

            textBox_witajUser.Text = n;

           // label7_witaJUser.Text = n;
        }

        private void button_przegladajkatalogWlasny_Click(object sender, EventArgs e)
        {
            string idUzytkownika = textBox_witajUser.Text;

           // string idUzytkownika = label7_witajUserName.Text; // wolalabym labela, ale niestwty nie odczytuje poprawnie :/

            string key = "  CONVERT(VARCHAR, idUsera)  like '" + idUzytkownika + "'";

            dataGridView_katalogUsera.DataSource = scWypozyczenie.FillWypozyczeniaUseraWszystkie(key, idUzytkownika);

        }

        private void button_pokazAktualneWypUsera_Click(object sender, EventArgs e)
        {
            string idUzytkownika = textBox_witajUser.Text; // label7_witajUserName.Text;

            string key = "  CONVERT(VARCHAR, idUsera)  like '" + idUzytkownika + "' and czyAktualne like '1' ";

            dataGridView_katalogUsera.DataSource = scWypozyczenie.FillWypozyczeniaUseraAktualne(key);



        }

        private void button_pokazArchiwalneWypUsera_Click(object sender, EventArgs e)
        {


            string idUzytkownika = textBox_witajUser.Text; // // label7_witajUserName.Text;

            string key = "  CONVERT(VARCHAR, idUsera)  like '" + idUzytkownika + "' and czyAktualne like '0' ";

            dataGridView_katalogUsera.DataSource = scWypozyczenie.FillWypozyczeniaUseraAktualne(key);

        }

        private void button1_pokazDaneWybranejKs_Click(object sender, EventArgs e)
        {
            string id = dataGridView_katalogUsera.CurrentRow.Cells["idKsiazki"].Value.ToString();

            string key = "  CONVERT(VARCHAR, id)  = '" + id + " ' ";


            //dataGridView_ksiazki.DataSource = sc.FillListBoxKsiazkiWybranePrzezUsera(key);
            dataGridView_wybrana.DataSource = sc.pokazDaneWybranejKsiazkiZKataloguUsera(key);


        }

        private void dataGridView_wybrana_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView_katalogUsera.CurrentRow.Cells["idKsiazki"].Value.ToString();

            string key = "  CONVERT(VARCHAR, id)  = '" + id + " ' ";


            //dataGridView_ksiazki.DataSource = sc.FillListBoxKsiazkiWybranePrzezUsera(key);
            dataGridView_wybrana.DataSource = sc.pokazDaneWybranejKsiazkiZKataloguUsera(key);

            dataGridView_wybrana.ClearSelection();


        }

        private void dataGridView_katalogUsera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string id = dataGridView_katalogUsera.CurrentRow.Cells["idKsiazki"].Value.ToString();

            string key = "  CONVERT(VARCHAR, id)  = '" + id + " ' ";




            //pooakzuje dane wybranej - bo tak
            //dataGridView_ksiazki.DataSource = sc.FillListBoxKsiazkiWybranePrzezUsera(key);



            textBox_imieAutora.Text = "nanan";


            //dataGridView_ksiazki.DataSource = sc.FillListBoxKsiazkiWybranePrzezUsera(key);
            dataGridView_wybrana.DataSource = sc.pokazDaneWybranejKsiazkiZKataloguUsera(key);


            dataGridView_wybrana.ClearSelection();



            // ShowDialog();


        }

        private void button_przedłuż_Click(object sender, EventArgs e)
        {
            //można przedłużyć 3 razy
            //ilość przedłużeń mozemy sprawidzć dla danej pozycji id 
            //- nie mozemy bo w wypozyczeniach nie zaplanowalismy pola ilość przedłużeń
            //a może sie da licząc ile razy dla danej pozycji id wypozyczenia wywołano klik butona

            //zmienają się tylko daty zwrotu w IKsiazka i i Wypozyczenie







            string key = dataGridView_katalogUsera.CurrentRow.Cells["idKsiazki"].Value.ToString();

            string keyDoWstawienia = "  CONVERT(VARCHAR, id)  = '" + key + " '";


            //pooakzuje dane wybranej - bo tak
            //dataGridView_ksiazki.DataSource = sc.FillListBoxKsiazkiWybranePrzezUsera(key);
            dataGridView_wybrana.DataSource = sc.pokazDaneWybranejKsiazkiZKataloguUsera(keyDoWstawienia);




            //najpierw sprawdzamy czy ksiazka jest jako wypozyczenieAktualne w katalogu Usera

            if (Convert.ToBoolean(dataGridView_katalogUsera.CurrentRow.Cells["czyAktualne"].Value.ToString()) == true)

            {

                if (Convert.ToInt32(dataGridView_wybrana.CurrentRow.Cells["licznikPrzedluzen"].Value.ToString())<3)

                {


                    //update wypozyczenie

                    WcfWypozyczeniaDoBazy.Wypozyczenie wypNowe = new WcfWypozyczeniaDoBazy.Wypozyczenie();

                    //zmianie ulega data zwrotu 
                    wypNowe.dataZwrotu = DateTime.UtcNow.ToLocalTime();

                    //zmienie nie ulegaja
                    wypNowe.idUsera = dataGridView_katalogUsera.CurrentRow.Cells["idUsera"].Value.ToString();
                    wypNowe.dataWypozyczyenia = Convert.ToDateTime(dataGridView_katalogUsera.CurrentRow.Cells["dataWypozyczyenia"].Value.ToString());
                    wypNowe.czyAktualne = Convert.ToBoolean(dataGridView_katalogUsera.CurrentRow.Cells["czyAktualne"].Value.ToString());


                    //update wyp


                    scWypozyczenie.UpdateNaPrzedluzenie(key, wypNowe);



                    //update Ksiazki z Iksiazka

                    Ksiazka nowa = new Ksiazka();

                    //parametry, ktore ulegaja zmianie przy przedluzeniu

                    nowa.dataZwrotu = DateTime.UtcNow.ToLocalTime().AddDays(14);
                    nowa.licznikPrzedluzen = Convert.ToInt32(dataGridView_wybrana.CurrentRow.Cells["licznikPrzedluzen"].Value.ToString()) + 1;


                    //nowa.dataWypozyczenia = Convert.ToDateTime(dataGridView_katalogUsera.CurrentRow.Cells["dataWypozyczyenia"].Value.ToString());//DateTime.UtcNow.ToLocalTime();



                    //troxhe na okrętke
                    //parametry, które się nie zmieniają
                    nowa.stan = Convert.ToBoolean(dataGridView_wybrana.CurrentRow.Cells["stan"].Value.ToString());
                    nowa.licznikWypozyczen = Convert.ToInt32(dataGridView_wybrana.CurrentRow.Cells["licznikWypozyczen"].Value.ToString()); //Convert.ToInt32(dataGridView_ksiazki.CurrentRow.Cells["licznikWypozyczen"].Value.ToString());
                    nowa.dataWypozyczenia = Convert.ToDateTime(dataGridView_wybrana.CurrentRow.Cells["dataWypozyczenia"].Value.ToString());//DateTime.UtcNow.ToLocalTime();
                    nowa.tytul = nowa.tytul = dataGridView_wybrana.CurrentRow.Cells["tytul"].Value.ToString();
                    nowa.rodzaj = dataGridView_wybrana.CurrentRow.Cells["rodzaj"].Value.ToString();
                    //nowa.licznikPrzedluzen = Convert.ToInt32(dataGridView_wybrana.CurrentRow.Cells["licznikPrzedluzen"].Value.ToString());
                    nowa.iloscStron = Convert.ToInt32(dataGridView_wybrana.CurrentRow.Cells["iloscStron"].Value.ToString());
                    nowa.imieAutora = dataGridView_wybrana.CurrentRow.Cells["imieAutora"].Value.ToString();
                    nowa.nazwiskoAutora = dataGridView_wybrana.CurrentRow.Cells["nazwiskoAutora"].Value.ToString();
                    nowa.nrISBN = dataGridView_wybrana.CurrentRow.Cells["nrISBN"].Value.ToString();


                    //update ksiazka
                    sc.UpdateNaZwrot(key, nowa);

                    MessageBox.Show("ksiazka przedluzona");

                }


                else MessageBox.Show("Wyczerpałeś limit przedłużeń");


            }


            else
                MessageBox.Show("Nie możesz przedluzyć ksiązki, której nie masz");




        }
    }
}
