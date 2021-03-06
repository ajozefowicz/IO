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

using WcfEgzemplarzDoBazy;
using biblioteka1.ServiceReference3;
//using.biblioteka1.ServiceReference4;

using WcfRezerwacjaDoBazy;


namespace biblioteka1
{
    public partial class Form3_PanelCzytelnika : Form
    {

        //WCFKsiazkaDataSet wc = new WCFKsiazkaDataSet();


        WcfEgzemplarzDoBazy.AdministracjaEgzemplarzem sc;

        WcfWypozyczeniaDoBazy.AdministracjaWypozyczeniem scWypozyczenie;

        WcfRezerwacjaDoBazy.AdministracjaRezerwacja scRezerwacja;

        WcfUserDoBazy.AdministracjaUzytkownikiem scUzytkownik;

        

        public Form3_PanelCzytelnika()
        {
            InitializeComponent();

            sc = new WcfEgzemplarzDoBazy.AdministracjaEgzemplarzem();

            scWypozyczenie = new WcfWypozyczeniaDoBazy.AdministracjaWypozyczeniem();

            scRezerwacja = new WcfRezerwacjaDoBazy.AdministracjaRezerwacja();

            scUzytkownik = new WcfUserDoBazy.AdministracjaUzytkownikiem();

            


        }

        private void button1_powrotDoGlownego_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1_Biblioteka p = new Form1_Biblioteka();
            p.Show();

        }

        private void button_pokazKsiazki_Click(object sender, EventArgs e)
        {

            //listBoxKsiazki.DataSource = sc.FillListBoxKsiazki();

           // dataGridView_ksiazki.DataSource = sc.FillListBoxKsiazki(); // przemyslec jak to tu działa

        }

        private void pokazWszytskieKsiazki(object sender, EventArgs e)
        {

            //this.dataGridView_ksiazki.Columns["@licznikWypozyczen"].Visible = false; //nie dziaka

            //DataGridView bierze kolumny z klasy książka, nie z bazy 

            //  dataGridView_ksiazki.Columns[1].Visible = false; // nie dziala


            dataGridView_ksiazki.DataSource = sc.SelectWszytskieKsiazki();

        }

        private void Form3_PanelCzytelnika_Load(object sender, EventArgs e)
        {

        }

        private void wyszukajEgzemplarz(object sender, EventArgs e)
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


            dataGridView_ksiazki.DataSource = sc.SelectKsiazkiWybranePoParametrach(key);


        }

        private void textBox_imieAutora_TextChanged(object sender, EventArgs e)
        {

        }

        private void wypozycEgzemplarz(object sender, EventArgs e)
        {
            //ServiceReference4.Ksiazka ks = new ServiceReference4.Ksiazka();
            WcfEgzemplarzDoBazy.Ksiazka ks = new WcfEgzemplarzDoBazy.Ksiazka();

 
            //2 wersje wypozyczania :
            //1. z rezerwacji i wtedy update rezerwacji - data
            //2. normalne

            //ks = listBox_ksiazkiWybrane.SelectedItem as ServiceReference1.Ksiazka;// to nie działa, po wybraniu wiersza na ekranie jest nullem


            string key1 = dataGridView_ksiazki.CurrentRow.Cells["id"].Value.ToString();

            int idK = Convert.ToInt32(dataGridView_ksiazki.CurrentRow.Cells["id"].Value.ToString());

            DateTime dataDoSprawdzeniaRezerwacji = Convert.ToDateTime(dataGridView_ksiazki.CurrentRow.Cells["dataZwrotu"].Value.ToString());

            //id Usera do sprawdzenia funkcji czy nie zalega i czy limit nie przekroczony
            string  idUzy = textBox_witajUser.Text;


            string keyRez = " CONVERT(VARCHAR, idKsiazki)  = '" + key1 + " ' and CONVERT(VARCHAR, idUsera) = '" + idUzy+ "'";

            int limit = Convert.ToInt32(textBox_limit.Text);

            //1. sprawdzamy czy user nie zalega z skiążkami
            if (scWypozyczenie.SelectCzyUserNieZalegazeZwrotem(idUzy) == false)  //tzn zalega
            {
                MessageBox.Show("Zalegasz ze zwrotem, nie możesz wypozyczyc");
            }

            //2. spr czy nie przekroczy limitu
            else if(scWypozyczenie.SelectIleUserMaWypozyczonych(idUzy)>=limit) // na probe 20
            {
                MessageBox.Show("Wypozyczyles juz " + Convert.ToInt32(scWypozyczenie.SelectIleUserMaWypozyczonych(idUzy)) + " nie mozesz więcej" );
            }

            //3.
            else
            {
                //1. wersja wypozyczania z rezerwacji
                //jesli ks jest na rezerwacji u user jest nr 1 w kolejce to może wypozyczyć
                //i ks musi byc zwrocona, czyli data zwrotu<dataaktualna

                if((scRezerwacja.SelectCzyKsiazkaJestNaRzerwacji(key1)==true) && scRezerwacja.SelectNaKtorejUserJestPozycjiWRezerwacji(idUzy,idK )==1
                    && dataDoSprawdzeniaRezerwacji< DateTime.UtcNow.ToLocalTime())

                {

                    //int limit = Convert.ToInt32(textBox_limit.Text);
                    int maxCzasWypozyczenia = Convert.ToInt32(textBox_czasWypozyczenia.Text);

                    Wypozycz(key1);

                    //na koniec zdejmujemy rezerwacje z Listy Rezerwacji
                    scRezerwacja.DeleteRezerwacja(keyRez);


                    Rezerwacja rezNowa = new Rezerwacja();

                    //zmianie ulega data zwrotu - powinna we wszytskich
                    rezNowa.dataZwrotu = DateTime.UtcNow.ToLocalTime().AddDays(maxCzasWypozyczenia); //DateTime.UtcNow.ToLocalTime();

                    //zmienie nie ulegaja
                    // rewNowa.idUsera = dataGridView_katalogUsera.CurrentRow.Cells["idUsera"].Value.ToString();
                    rezNowa.tytul = dataGridView_ksiazki.CurrentRow.Cells["tytul"].Value.ToString();
                    rezNowa.nazwiskoAutora = dataGridView_ksiazki.CurrentRow.Cells["nazwiskoAutora"].Value.ToString();




                    scRezerwacja.UpdateNaZwrot(key1, rezNowa);

                }


                else if ((scRezerwacja.SelectCzyKsiazkaJestNaRzerwacji(key1) == true) && scRezerwacja.SelectNaKtorejUserJestPozycjiWRezerwacji(idUzy, idK) == 1
                    && dataDoSprawdzeniaRezerwacji > DateTime.UtcNow.ToLocalTime())

                {

                    MessageBox.Show("ksiazka jeszcze nie została zwrocona");

                }



                //najpierw sprawdzamy czy ksiazka dostępna

                else if (Convert.ToBoolean(dataGridView_ksiazki.CurrentRow.Cells["stan"].Value.ToString()) == true)
                    Wypozycz(key1);


                else
                    MessageBox.Show("Ksiazka niedostępna, pusty kwadracik !!!");


            }
                    
        }

        private void Wypozycz(string key1)
        {
            int limit = Convert.ToInt32(textBox_limit.Text);
            int maxCzasWypozyczenia = Convert.ToInt32(textBox_czasWypozyczenia.Text);

            //ServiceReference3.Wypozyczenie w = new ServiceReference3.Wypozyczenie();
            WcfWypozyczeniaDoBazy.Wypozyczenie w = new WcfWypozyczeniaDoBazy.Wypozyczenie();
            

            w.idEgzemplarza = Convert.ToInt32(key1); // pcja = ks.id nie działa, bo wybrany wiersz jest nulem, wiec zamiast listBox, dataGridView
            w.idUsera = textBox_witajUser.Text;     //label7_witaJUser.Text;   //textBox_IdUsera.Text; // to na probe, zmienić by pobierało
            w.dataWypozyczyenia = DateTime.UtcNow.ToLocalTime();
            w.dataZwrotu = DateTime.UtcNow.ToLocalTime().AddDays(maxCzasWypozyczenia); // jak tu zrobic nulla
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
            nowa.dataZwrotu = (DateTime.UtcNow.ToLocalTime().AddDays(maxCzasWypozyczenia)); //+14 dni jako prognozowana data zwrotu
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
            sc.UpdateNaWypozyczenie(key1, nowa);


            //Insert z WCFWypozyczenie
            if (service.InsertWypozyczenie(w) == 1)
            {
                MessageBox.Show("Ksiazka wypozyczona");
            }

            ///////////////////////////////
        }

        private void dodajDoUlubionych(object sender, EventArgs e)
        {
            // trza gdzieś zrobic pole ulubioneDla i tam np podawac id usera, w książce nie - bo moze bnyc wielu userów a pole 1, 
            //w wypozyczeniach też nie bo nie musiał wypozyczyć by dodać do ulubioncyh - no w ostateczności tak sie zrobi
        }

        private void zwrocWybranaKsiazke(object sender, EventArgs e) // uwaga zmieniona nazawa butona, jak by sie krzaczyło pamiętać
        {
            //zwróc
            //wybiera poprzez wybór na liście ksiazek usera
            //jak zwroci to zmianie ulega status w ksiazce i w wypozyczeniu zmienia się na archiwalne i nowa data zwrotu się pojawia - update
            //i w rezerwacji data zwrotu powina sie zmienic

            string key = dataGridView_katalogUsera.CurrentRow.Cells["idEgzemplarza"].Value.ToString();

            string keyDoWstawienia = "  CONVERT(VARCHAR, id)  = '" + key + " '";


            //pooakzuje dane wybranej - bo tak
            //dataGridView_ksiazki.DataSource = sc.FillListBoxKsiazkiWybranePrzezUsera(key);
            dataGridView_wybrana.DataSource = sc.SelectDaneWybranejKsiazkiZKataloguUsera(keyDoWstawienia);




            //najpierw sprawdzamy czy ksiazka jest jako wypozyczenieAktualne w katalogu Usera

            if (Convert.ToBoolean(dataGridView_katalogUsera.CurrentRow.Cells["czyAktualne"].Value.ToString()) == true)

            {

                //2 rodzaje zwracania: 
                //1. gdy jest naLiscie Rezerwacji (wtedy czyDostepna - nie ulega zmianie)
                //2. gdy nie ma na liscie rezerwacji (wtedy czyDostepna - ulega zmianie na true)

                Ksiazka nowa = new Ksiazka();

                if (scRezerwacja.SelectCzyKsiazkaJestNaRzerwacji(key) == true)
                {
                    nowa.stan = false;

                }

                else nowa.stan = true;
                




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



                //parametry, ktore ulegaja zmianie przy zwrocie
                //nowa.id = Convert.ToInt32(dataGridView_ksiazki.CurrentRow.Cells["id"].Value.ToString());

                nowa.dataZwrotu = DateTime.UtcNow.ToLocalTime();


                //nowa.stan = true;

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



                /////////////////////////////////////////////////////////////////////////////////////////////////
                //update na rezerwace

                WcfRezerwacjaDoBazy.Rezerwacja rewNowa = new WcfRezerwacjaDoBazy.Rezerwacja();


                //zmianie ulega data zwrotu 
                rewNowa.dataZwrotu = DateTime.UtcNow.ToLocalTime();

                //zmienie nie ulegaja
               // rewNowa.idUsera = dataGridView_katalogUsera.CurrentRow.Cells["idUsera"].Value.ToString();
                rewNowa.tytul = dataGridView_wybrana.CurrentRow.Cells["tytul"].Value.ToString();
                rewNowa.nazwiskoAutora = dataGridView_wybrana.CurrentRow.Cells["nazwiskoAutora"].Value.ToString();


                scRezerwacja.UpdateNaZwrot(key, rewNowa);

            }


            else
                MessageBox.Show("Ksiazka juz została przez Ciebie zwrócona");


        }








        private void button_zarezerwuj(object sender, EventArgs e)
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

            textBox_witajUser.Text = n;

        }

        private void przegladajKatalogWlasny(object sender, EventArgs e)
        {
            string idUzytkownika = textBox_witajUser.Text;

           // string idUzytkownika = label7_witajUserName.Text; // wolalabym labela, ale niestwty nie odczytuje poprawnie :/

            string key = "  CONVERT(VARCHAR, idUsera)  like '" + idUzytkownika + "'";

            dataGridView_katalogUsera.DataSource = scWypozyczenie.SelectWypozyczeniaUzytkownikaWszystkie(key, idUzytkownika);

        }

        private void pokazAktualneWypozyczeniaCzytelnika(object sender, EventArgs e)
        {
            string idUzytkownika = textBox_witajUser.Text; // label7_witajUserName.Text;

            string key = "  CONVERT(VARCHAR, idUsera)  like '" + idUzytkownika + "' and czyAktualne like '1' ";

            dataGridView_katalogUsera.DataSource = scWypozyczenie.SelectWypozyczeniaUzytkownikaAktualne(key);



        }

        private void pokazArchiwalneWypozyczeniaCzytelnika(object sender, EventArgs e)
        {


            string idUzytkownika = textBox_witajUser.Text; // // label7_witajUserName.Text;

            string key = "  CONVERT(VARCHAR, idUsera)  like '" + idUzytkownika + "' and czyAktualne like '0' ";

            dataGridView_katalogUsera.DataSource = scWypozyczenie.SelectWypozyczeniaUzytkownikaAktualne(key);

        }

        private void pokazDaneWybranejPozycji(object sender, EventArgs e)
        {
            string id = dataGridView_katalogUsera.CurrentRow.Cells["idEgzemplarza"].Value.ToString();

            string key = "  CONVERT(VARCHAR, id)  = '" + id + " ' ";


            //dataGridView_ksiazki.DataSource = sc.FillListBoxKsiazkiWybranePrzezUsera(key);
            dataGridView_wybrana.DataSource = sc.SelectDaneWybranejKsiazkiZKataloguUsera(key);


        }

        private void dataGridView_wybrana_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView_katalogUsera.CurrentRow.Cells["idEgzemplarza"].Value.ToString();

            string key = "  CONVERT(VARCHAR, id)  = '" + id + " ' ";


            //dataGridView_ksiazki.DataSource = sc.FillListBoxKsiazkiWybranePrzezUsera(key);
            dataGridView_wybrana.DataSource = sc.SelectDaneWybranejKsiazkiZKataloguUsera(key);

            dataGridView_wybrana.ClearSelection();


        }

        private void dataGridView_katalogUsera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string id = dataGridView_katalogUsera.CurrentRow.Cells["idEgzemplarza"].Value.ToString();

            string key = "  CONVERT(VARCHAR, id)  = '" + id + " ' ";

            //pooakzuje dane wybranej - bo tak


            //tescik, bo nie wiem kiedy dziala, generalnie dziala jak klika sie na daty ....
            //textBox_imieAutora.Text = "nanan";


            //dataGridView_ksiazki.DataSource = sc.FillListBoxKsiazkiWybranePrzezUsera(key);
            dataGridView_wybrana.DataSource = sc.SelectDaneWybranejKsiazkiZKataloguUsera(key);


            dataGridView_wybrana.ClearSelection();



            // ShowDialog();


        }

        private void przedluzWybranaKsiazke(object sender, EventArgs e)
        {

            int limit = Convert.ToInt32(textBox_limit.Text);
            int maxCzasWypozyczenia = Convert.ToInt32(textBox_czasWypozyczenia.Text);
            //można przedłużyć 3 razy
            //ilość przedłużeń mozemy sprawidzć dla danej pozycji id 
            //- nie mozemy bo w wypozyczeniach nie zaplanowalismy pola ilość przedłużeń
            //a może sie da licząc ile razy dla danej pozycji id wypozyczenia wywołano klik butona

            //zmienają się tylko daty zwrotu w IKsiazka i i Wypozyczenie


            string key = dataGridView_katalogUsera.CurrentRow.Cells["idEgzemplarza"].Value.ToString();//key dla ksiazki

            //key dla update wypozyczenia:

            string keyWyp = (dataGridView_katalogUsera.CurrentRow.Cells["id"].Value.ToString());

            string keyDoWstawienia = "  CONVERT(VARCHAR, id)  = '" + key + " '";


            //pooakzuje dane wybranej - bo tak
            //dataGridView_ksiazki.DataSource = sc.FillListBoxKsiazkiWybranePrzezUsera(key);
            dataGridView_wybrana.DataSource = sc.SelectDaneWybranejKsiazkiZKataloguUsera(keyDoWstawienia);




            //najpierw sprawdzamy czy ksiazka jest jako wypozyczenieAktualne w katalogu Usera

            if (Convert.ToBoolean(dataGridView_katalogUsera.CurrentRow.Cells["czyAktualne"].Value.ToString()) == true)

            {


                if (Convert.ToInt32(dataGridView_wybrana.CurrentRow.Cells["licznikPrzedluzen"].Value.ToString())<2)

                {


                    //update wypozyczenie

                    WcfWypozyczeniaDoBazy.Wypozyczenie wypNowe = new WcfWypozyczeniaDoBazy.Wypozyczenie();

                    //zmianie ulega data zwrotu 
                    wypNowe.dataZwrotu = DateTime.UtcNow.ToLocalTime().AddDays(maxCzasWypozyczenia);

                    //zmienie nie ulegaja
                    wypNowe.idUsera = dataGridView_katalogUsera.CurrentRow.Cells["idUsera"].Value.ToString();
                    wypNowe.dataWypozyczyenia = Convert.ToDateTime(dataGridView_katalogUsera.CurrentRow.Cells["dataWypozyczyenia"].Value.ToString());
                    wypNowe.czyAktualne = Convert.ToBoolean(dataGridView_katalogUsera.CurrentRow.Cells["czyAktualne"].Value.ToString());


                    //update wyp

                    //tu key id by sie nie powtarzały ksiazki
                    scWypozyczenie.UpdateNaPrzedluzenie(keyWyp, wypNowe);



                    //update Ksiazki z Iksiazka

                    Ksiazka nowa = new Ksiazka();

                    //parametry, ktore ulegaja zmianie przy przedluzeniu

                    nowa.dataZwrotu = DateTime.UtcNow.ToLocalTime().AddDays(maxCzasWypozyczenia);
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


                    //update ksiazka i tu id ksiazki ok
                    sc.UpdateNaPrzedluzenie(key, nowa);
                    //sc.UpdateNaZwrot(key, nowa);

                    MessageBox.Show("ksiazka przedluzona");


                    //update na rzerwacje

                    Rezerwacja rNowa = new Rezerwacja();
                    //zmienia date wszystkie gdzie id ksiazki takie samo
                    rNowa.dataZwrotu = DateTime.UtcNow.ToLocalTime().AddDays(maxCzasWypozyczenia);


                    scRezerwacja.UpdateNaPrzedluzenie(key, rNowa);

                }


                else MessageBox.Show("Wyczerpałeś limit przedłużeń");


            }


            else
                MessageBox.Show("Nie możesz przedluzyć ksiązki, której nie masz");




        }

        private void zarezerwujEgzemplarz(object sender, EventArgs e)
        {
            // WcfRezerwacjaDoBazy.Rezerwacja r = new WcfRezerwacjaDoBazy.Rezerwacja();
            Rezerwacja r = new Rezerwacja();


            //!!!!! dlaczego to raz działa raz nie ????????
            //ServiceReference4.Ksiazka ks = new ServiceReference4.Ksiazka(); 

          //  WcfEgzemplarzDoBazy.Ksiazka ks = new WcfEgzemplarzDoBazy.Ksiazka();

            WcfRezerwacjaDoBazy.AdministracjaRezerwacja ss = new WcfRezerwacjaDoBazy.AdministracjaRezerwacja();

            string idU = textBox_witajUser.Text;
            string idK = dataGridView_ksiazki.CurrentRow.Cells["id"].Value.ToString();

            //blokada, że jesli raz zarezerwował to już drugi raz nie może - w tej samej "turze", po zwrocie już moze

            if (ss.SelectCzyUserJuzZarezerowalDanaKsiazka(idK, idU) == false)
            {
                r.idUsera = textBox_witajUser.Text;
                r.idEgzemplarza = Convert.ToInt32(dataGridView_ksiazki.CurrentRow.Cells["id"].Value.ToString());
                r.tytul = dataGridView_ksiazki.CurrentRow.Cells["tytul"].Value.ToString();
                r.nazwiskoAutora = dataGridView_ksiazki.CurrentRow.Cells["nazwiskoAutora"].Value.ToString();
                r.dataZwrotu = Convert.ToDateTime(dataGridView_ksiazki.CurrentRow.Cells["dataZwrotu"].Value.ToString());



                if (ss.InsertRezerwacja(r) == 1)
                {
                    MessageBox.Show("Rezerwacja dodana do bazy");
                }
            }

            else
                MessageBox.Show("Juz zarezerwowałeś tę pozycję, nie możesz drugi raz");
            


        }

        private void pokazZarezerwowaneKsiazkiUzytkownika(object sender, EventArgs e)
        {
            string idUzytkownika = textBox_witajUser.Text; // label7_witajUserName.Text;

            string key = "  CONVERT(VARCHAR, idUsera)  like '" + idUzytkownika + "' ";

            dataGridView_katalogUsera.DataSource = scRezerwacja.SelectRezerwacjeUzytkownika(key);
        }

        private void dataGridView_ksiazki_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pokazNumerCzytelnikaWKolejceRezerwacji(object sender, EventArgs e)
        {
            string idUzy = textBox_witajUser.Text;


            int idK = Convert.ToInt32(dataGridView_katalogUsera.CurrentRow.Cells["idEgzemplarza"].Value.ToString());

            DateTime dataZw = Convert.ToDateTime(dataGridView_katalogUsera.CurrentRow.Cells["dataZwrotu"].Value.ToString());


            if(dataZw> DateTime.UtcNow.ToLocalTime())
            textBox_nrWKolejce.Text = (scRezerwacja.SelectNaKtorejUserJestPozycjiWRezerwacji(idUzy, idK)).ToString();

            else
                textBox_nrWKolejce.Text = ((scRezerwacja.SelectNaKtorejUserJestPozycjiWRezerwacji(idUzy, idK))-1).ToString();


        }

        private void usunRezerwacje(object sender, EventArgs e)
        {


            int key1 = Convert.ToInt32(dataGridView_katalogUsera.CurrentRow.Cells["idEgzemplarza"].Value.ToString());

            string key2 = dataGridView_katalogUsera.CurrentRow.Cells["idUsera"].Value.ToString();

            string key = " CONVERT(VARCHAR, idKsiazki)  = '" + key1 + " ' and CONVERT(VARCHAR, idUsera) = '" + key2 + "'";

            bool request = scRezerwacja.DeleteRezerwacja(key);

            if (request)
            {
                MessageBox.Show("usunieto rezerwacje");
            }
            else
            {
                MessageBox.Show("nie usunieto");
            }





        }

        private void button_czyNaRezerwacji_Click(object sender, EventArgs e)
        {
            //jest ok
            string key = dataGridView_katalogUsera.CurrentRow.Cells["idEgzemplarza"].Value.ToString();
            //textBox1_pomocniczy.Text = Convert.ToString(scRezerwacja.CzyKsiazkaJestNaRzerwacji(key));
        }

        private void button_powiadomieniaORez_Click(object sender, EventArgs e)
        {
            DateTime dataDoSprawdzeniaRezerwacji = Convert.ToDateTime(dataGridView_ksiazki.CurrentRow.Cells["dataZwrotu"].Value.ToString());

            Ksiazka ks = new Ksiazka();

            //if ((scRezerwacja.CzyKsiazkaJestNaRzerwacji(key1) == true) && scRezerwacja.NaKtorejUserJestPozycjiWRezerwacji(idUzy, idK) == 1
                 //   && dataDoSprawdzeniaRezerwacji < DateTime.UtcNow.ToLocalTime())

            //nie ma jak sie dostac do daty zwrotu bez klikania na liste

        }

        private void textBox_witajUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_limit_TextChanged(object sender, EventArgs e)
        {


            

        }




        public string pobierzLimiUseraDoPanelu()
        {

            string idUzytkownika = textBox_witajUser.Text;
            string key = "  CONVERT(VARCHAR, id)  like '" + idUzytkownika + "'";
            textBox_limit.Text = (scUzytkownik.SelectLimitUzytkownika(key, idUzytkownika)).ToString();

            return textBox_limit.Text;

        }


        public string pobierzMaxCzasWypozyczeniaUseraDoPanelu()
        {

            string idUzytkownika = textBox_witajUser.Text;
            string key = "  CONVERT(VARCHAR, id)  like '" + idUzytkownika + "'";
            textBox_czasWypozyczenia.Text = (scUzytkownik.SelectMaxCzasWypozyczeniaUsera(key, idUzytkownika)).ToString();

            return textBox_czasWypozyczenia.Text;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void compositeTypeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label_limit_Click(object sender, EventArgs e)
        {

        }
    }
}
