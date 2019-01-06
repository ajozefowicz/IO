using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using biblioteka1.ServiceReference1;
using biblioteka1.ServiceReference2;
using biblioteka1.ServiceReference3;
using biblioteka1.ServiceReference4;

using WcfUserDoBazy;
using WcfEgzemplarzDoBazy;



namespace biblioteka1
{
    public partial class Form2_PanelPracownika : Form
    {


        WcfUserDoBazy.AdministracjaUzytkownikiem sc;

        WcfEgzemplarzDoBazy.AdministracjaEgzemplarzem scKsiazki;

        WcfWypozyczeniaDoBazy.AdministracjaWypozyczeniem scWypozyczenia;


        public Form2_PanelPracownika()
        {
            InitializeComponent();

            sc = new WcfUserDoBazy.AdministracjaUzytkownikiem();

            scKsiazki = new WcfEgzemplarzDoBazy.AdministracjaEgzemplarzem();

            scWypozyczenia = new WcfWypozyczeniaDoBazy.AdministracjaWypozyczeniem();
        }

        private void button1_powrotDoGlownego_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1_Biblioteka p = new Form1_Biblioteka();
            p.Show();

        }

        private void Form2_PanelPracownika_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void dodajEgzemplarz(object sender, EventArgs e)
        {


            /////////////////////////////////////////////////////



            //test czt to pojdzie
            // k.dataWypozyczenia = DateTime.UtcNow.ToLocalTime();
            // k.dataZwrotu = DateTime.UtcNow.ToLocalTime();

            // ServiceReference4.Service1Client service = new ServiceReference4.Service1Client();

            WcfEgzemplarzDoBazy.AdministracjaEgzemplarzem ss = new WcfEgzemplarzDoBazy.AdministracjaEgzemplarzem();



            if(comboBox_kategoriaEgzemplarza.Text=="książka")
            {
                Ksiazka k = new Ksiazka();

                k.tytul = textTytul.Text;
                k.stan = Convert.ToBoolean(comboBox_stan.Text);
                //  k.rodzaj = textRodzaj.Text;
                k.rodzaj = comboBox_rodzajeKsiazke.Text;
                k.licznikWypozyczen = Convert.ToInt32(textLicznikWyp.Text);
                k.licznikPrzedluzen = Convert.ToInt32(textLicznikPrzed.Text);
                k.iloscStron = Convert.ToInt32(textIloscStron.Text);
                k.imieAutora = textImieAutora.Text;
                k.nazwiskoAutora = textNazwiskoAutora.Text;
                k.nrISBN = textISBN.Text;

                if (ss.InsertKsiazka(k) == 1)
                {
                    MessageBox.Show("Ksiazka dodana do bazy");
                }
            }


            if(comboBox_kategoriaEgzemplarza.Text == "audiobook")
            {
                Audiobook a = new Audiobook();
                a.tytul = textTytul.Text;
                a.stan = Convert.ToBoolean(comboBox_stan.Text);
                //  k.rodzaj = textRodzaj.Text;
                a.rodzaj = comboBox_rodzajeKsiazke.Text;
                a.licznikWypozyczen = Convert.ToInt32(textLicznikWyp.Text);
                a.licznikPrzedluzen = Convert.ToInt32(textLicznikPrzed.Text);
                a.iliscMinut = Convert.ToInt32(textBox_iloscMinut.Text);
                a.ktoCzyta = textBox_ktoCzyta.Text;

                if (ss.InsertAudiobook(a) == 1)
                {
                    MessageBox.Show("Audiobook dodana do bazy");
                }
            }




        }

        private void dodajUzytkownika(object sender, EventArgs e)
        {

            //moze z ifem sprobowac if box stanowisko not null to ....


            Czytelnik c = new Czytelnik();
            c.id = text_IdUsera.Text;
            c.haslo = text_haslo.Text;
            c.imie = text_ImieUsera.Text;
            c.nazwisko = text_nazwiskoUsera.Text;
            c.pesel = textPesel.Text;
            c.emaileee = Convert.ToString(textEMail.Text);
            c.limit = Convert.ToInt32(textBox_limit.Text);
            c.kategoria = comboBox_kategoria.Text;
            c.maxCzasWypozyczenia = Convert.ToInt32(textBox_maxCzasWypozyczenia.Text);

            //

            Pracownik p = new Pracownik();
            p.id = text_IdUsera.Text;
            p.haslo = text_haslo.Text;
            p.imie = text_ImieUsera.Text;
            p.nazwisko = text_nazwiskoUsera.Text;
            p.pesel = textPesel.Text;
            p.emaileee = Convert.ToString(textEMail.Text);
            p.limit = Convert.ToInt32(textBox_limit.Text);
            p.kategoria = comboBox_kategoria.Text;
            p.maxCzasWypozyczenia = Convert.ToInt32(textBox_maxCzasWypozyczenia.Text);
            p.stanowisko = textBox_stanowisko.Text;





            ServiceReference2.Service1Client service = new ServiceReference2.Service1Client();

            

            WcfUserDoBazy.AdministracjaUzytkownikiem scUser = new WcfUserDoBazy.AdministracjaUzytkownikiem();

           // if (service.InsertUser(u) == 1) -- wczesniej dzialalo


            //tu ifa , if stanowikso not null to pracownik itd

            if(comboBox_kategoria.Text != "pracownik")
            {
                if (scUser.InsertCzytelnik(c) == 1)
                {
                    MessageBox.Show("czytelnik dodany do bazy");
                }

            }


            else
            {
                if (scUser.InsertPracownik(p) == 1)
                {
                    MessageBox.Show("pracownik dodany do bazy");
                }
            }



            //czyszczenie

            text_IdUsera.Clear();
            text_haslo.Clear();
            text_ImieUsera.Clear();
            text_nazwiskoUsera.Clear();
            textPesel.Clear();
            textEMail.Clear();
            textBox_limit.Clear();
            textBox_maxCzasWypozyczenia.Clear();
            textBox_stanowisko.Clear();
            




        }




        private void button_pokazKsiazki_Click(object sender, EventArgs e)
        {
            //zaby pokazało ks wszytskie, ale tylko kila parametrów
            // listBox_ksiazkiPracownik.DataSource = scKsiazki.FillListBoxKsiazkiPanelPracownika();
            listBox_ksiazkiPracownik.DataSource = scKsiazki.SelectKsiazkiNajczesciejWypozyczane();


        }

        private void pokazCzytelnikow(object sender, EventArgs e)
        {
            dataGridViewPokazUserow.DataSource = sc.SelectCzytelnicy();

        }

        private void usunCzytelnikow(object sender, EventArgs e)
        {
            // int rowIndex = dataGridViewPokazUserow.CurrentCell.RowIndex;
            //dataGridViewPokazUserow.Rows.RemoveAt(rowIndex);






            //Uzytkownik u = new Uzytkownik();


            //int index = dataGridViewPokazUserow.CurrentRow.Index;

            //  u.id = index.ToString();


            /*
            u.id = (dataGridViewPokazUserow.CurrentCell.ColumnIndex).ToString();
            u.haslo = (dataGridViewPokazUserow.CurrentCell.ColumnIndex).ToString();
            u.imie = (dataGridViewPokazUserow.CurrentCell.ColumnIndex).ToString();
            u.nazwisko = (dataGridViewPokazUserow.CurrentCell.ColumnIndex).ToString();
            u.pesel = (dataGridViewPokazUserow.CurrentCell.ColumnIndex).ToString();
            u.emaileee = (dataGridViewPokazUserow.CurrentCell.ColumnIndex).ToString();
            */

            //u = dataGridViewPokazUserow.Select

            // sc.DeleteUser(index);




            //  u.id = dataGridViewPokazUserow.CurrentCell.RowIndex


            string key1 = dataGridViewPokazUserow.CurrentRow.Cells["id"].Value.ToString();
 
            string key2 = dataGridViewPokazUserow.CurrentRow.Cells["haslo"].Value.ToString();

            string key = " CONVERT(VARCHAR, id)  = '" + key1 + " ' and CONVERT(VARCHAR, haslo) = '" + key2 + "'"; //= czy like? lepiej = i konversja na varchar

            bool request = sc.DeleteUzytkownik2(key);

            if(request)
            {
                MessageBox.Show("usunieto");
            }
            else
            {
                MessageBox.Show("nie usunieto");
            }


        }

        //////////////////////////////////////////////////////////

        private void pokazKsiazki(object sender, EventArgs e)
        {
            // dataGridViewPokazUserow.DataSource = sc.FillListBoxUserzyTabela();

            dataGridView_ksiazkiTabela.DataSource = scKsiazki.SelectWszytskieKsiazki(); //zamiast ListBoxksiazkiTabela
        }

        private void usunKsiazke(object sender, EventArgs e)
        {

            string key1 = dataGridView_ksiazkiTabela.CurrentRow.Cells["id"].Value.ToString();

            string key2 = dataGridView_ksiazkiTabela.CurrentRow.Cells["tytul"].Value.ToString();

            string key = "  id  = '" + key1 + " ' and CONVERT(VARCHAR, tytul) = '" + key2 + "'"; //= czy like? lepiej = i konversja na varchar

            bool request = scKsiazki.DeleteEgzemplarz(key);

            if (request)
            {
                MessageBox.Show("usunieto");
            }
            else
            {
                MessageBox.Show("nie usunieto");
            }

        }

        private void label6_licznikPrzedluzen_Click(object sender, EventArgs e)
        {

        }

        private void button_usunUsera_Click(object sender, EventArgs e)
        {

        }

        private void pokazWypozyczenia(object sender, EventArgs e)
        {
            dataGridView_ksiazkiTabela.DataSource = scWypozyczenia.SelectWszystkieWypozyczenia();
        }

        private void pokazInformacjeOPoczytnosci(object sender, EventArgs e)
        {
           if (comboBox_sortowanieNaj.SelectedIndex == 0 )
            {
                listBox_ksiazkiPracownik.DataSource = scKsiazki.SelectKsiazkiNajczesciejWypozyczane();

            }


            if (comboBox_sortowanieNaj.SelectedIndex == 1)
            {
                listBox_ksiazkiPracownik.DataSource = scKsiazki.SelectKsiazkiNajzadziejWypozyczane();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pokazPracownikow(object sender, EventArgs e)
        {
            dataGridViewPokazUserow.DataSource = sc.SelectPracownicy();

        }

        private void textBox_limit_TextChanged(object sender, EventArgs e)
        {



        }

        private void comboBox_kategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_kategoria.Text == "wykładowca")
                textBox_limit.Text = "30";

            if (comboBox_kategoria.Text == "student")
                textBox_limit.Text = "21";

            if (comboBox_kategoria.Text == "zwykły czytelnik")
                textBox_limit.Text = "5";

            if (comboBox_kategoria.Text == "pracownik")
                textBox_limit.Text = "30";
        }

        private void button_przejscieDoSekcjiCzytelnika_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3_PanelCzytelnika p = new Form3_PanelCzytelnika();
            p.Show();



        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_tytul_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewPokazUserow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
