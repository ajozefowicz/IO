﻿using System;
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



namespace biblioteka1
{
    public partial class Form2_PanelPracownika : Form
    {


        WcfUserDoBazy.Service1 sc;

        WcfKsiazkaDoBazy4.Service1 scKsiazki;

        WcfWypozyczeniaDoBazy.Service1 scWypozyczenia;


        public Form2_PanelPracownika()
        {
            InitializeComponent();

            sc = new WcfUserDoBazy.Service1();

            scKsiazki = new WcfKsiazkaDoBazy4.Service1();

            scWypozyczenia = new WcfWypozyczeniaDoBazy.Service1();
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

        private void button1_dodajKsiazke_Click(object sender, EventArgs e)
        {
            Ksiazka k = new Ksiazka();
            k.id = Convert.ToInt32(textId.Text);
            k.tytul = textTytul.Text;
            //k.stan = Convert.ToBoolean(textStan.Text);
            k.stan = Convert.ToBoolean(comboBox_stan.Text);
            //  k.rodzaj = textRodzaj.Text;
            k.rodzaj = comboBox_rodzajeKsiazke.Text;
            k.licznikWypozyczen = Convert.ToInt32(textLicznikWyp.Text);
            k.licznikPrzedluzen = Convert.ToInt32(textLicznikPrzed.Text);
            k.iloscStron = Convert.ToInt32(textIloscStron.Text);
            k.imieAutora = textImieAutora.Text;
            k.nazwiskoAutora = textNazwiskoAutora.Text;
            k.nrISBN = textISBN.Text;


            //test czt to pojdzie
           // k.dataWypozyczenia = DateTime.UtcNow.ToLocalTime();
           // k.dataZwrotu = DateTime.UtcNow.ToLocalTime();

            ServiceReference4.Service1Client service = new ServiceReference4.Service1Client();

           if ( service.InsertKsiazka(k) == 1)
            {
                MessageBox.Show("Ksiazka dodana do bazy");
            }
        }

        private void button_dodajUsera_Click(object sender, EventArgs e)
        {

            Uzytkownik u = new Uzytkownik();
            u.id = text_IdUsera.Text;
            u.haslo = text_haslo.Text;
            u.imie = text_ImieUsera.Text;
            u.nazwisko = text_nazwiskoUsera.Text;
            u.pesel = textPesel.Text;
            u.emaileee = Convert.ToString(textEMail.Text);



            ServiceReference2.Service1Client service = new ServiceReference2.Service1Client();

            

            WcfUserDoBazy.Service1 scUser = new WcfUserDoBazy.Service1();

           // if (service.InsertUser(u) == 1) -- wczesniej dzialalo
                if (scUser.InsertUser(u) == 1)
            {
                MessageBox.Show("uzytkownik dodany do bazy");
            }


            //czyszczenie

            text_IdUsera.Clear();
            text_haslo.Clear();
            text_ImieUsera.Clear();
            text_nazwiskoUsera.Clear();
            textPesel.Clear();
            textEMail.Clear();



        }




        private void button_pokazKsiazki_Click(object sender, EventArgs e)
        {
            //zaby pokazało ks wszytskie, ale tylko kila parametrów
            // listBox_ksiazkiPracownik.DataSource = scKsiazki.FillListBoxKsiazkiPanelPracownika();
            listBox_ksiazkiPracownik.DataSource = scKsiazki.pokazKsiazkiNajczesciejWypozyczane();


        }

        private void button_pokazUserówDataGrid_Click(object sender, EventArgs e)
        {
            dataGridViewPokazUserow.DataSource = sc.FillListBoxUserzyTabela();

        }

        private void button_usunUserazTabeli_Click(object sender, EventArgs e)
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

            bool request = sc.DeleteUser2(key);

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

        private void button_pokazKsiazkiTabela_Click(object sender, EventArgs e)
        {
            // dataGridViewPokazUserow.DataSource = sc.FillListBoxUserzyTabela();

            dataGridView_ksiazkiTabela.DataSource = scKsiazki.FillListBoxksiazkiTabela();
        }

        private void button_usunKsiazkezTabeli_Click(object sender, EventArgs e)
        {

            string key1 = dataGridView_ksiazkiTabela.CurrentRow.Cells["id"].Value.ToString();

            string key2 = dataGridView_ksiazkiTabela.CurrentRow.Cells["tytul"].Value.ToString();

            string key = "  id  = '" + key1 + " ' and CONVERT(VARCHAR, tytul) = '" + key2 + "'"; //= czy like? lepiej = i konversja na varchar

            bool request = scKsiazki.DeleteKsiazka2(key);

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

        private void button_pokazWypozyczenia_Click(object sender, EventArgs e)
        {
            dataGridView_ksiazkiTabela.DataSource = scWypozyczenia.FillWypozyczeniaDataGridViewTabela();
        }

        private void comboBox_sortowanieNaj_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (comboBox_sortowanieNaj.SelectedIndex == 0 )
            {
                listBox_ksiazkiPracownik.DataSource = scKsiazki.pokazKsiazkiNajczesciejWypozyczane();

            }


            if (comboBox_sortowanieNaj.SelectedIndex == 1)
            {
                listBox_ksiazkiPracownik.DataSource = scKsiazki.pokazKsiazkiNajzadziejWypozyczane();

            }
        }
    }
}
