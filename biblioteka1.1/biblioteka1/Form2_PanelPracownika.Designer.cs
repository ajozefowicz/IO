//using biblioteka1.ServiceReference1;

namespace biblioteka1
{
    partial class Form2_PanelPracownika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1_powrotDoGlownego = new System.Windows.Forms.Button();
            this.button1_dodajKsiazke = new System.Windows.Forms.Button();
            this.label1_id = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textTytul = new System.Windows.Forms.TextBox();
            this.label2_tytul = new System.Windows.Forms.Label();
            this.textStan = new System.Windows.Forms.TextBox();
            this.label3_stan = new System.Windows.Forms.Label();
            this.textRodzaj = new System.Windows.Forms.TextBox();
            this.label4_rodzaj = new System.Windows.Forms.Label();
            this.textLicznikWyp = new System.Windows.Forms.TextBox();
            this.label5_licznikWypozyczen = new System.Windows.Forms.Label();
            this.textLicznikPrzed = new System.Windows.Forms.TextBox();
            this.label6_licznikPrzedluzen = new System.Windows.Forms.Label();
            this.textIloscStron = new System.Windows.Forms.TextBox();
            this.label7_iloscStron = new System.Windows.Forms.Label();
            this.textImieAutora = new System.Windows.Forms.TextBox();
            this.label8_imieAutora = new System.Windows.Forms.Label();
            this.textNazwiskoAutora = new System.Windows.Forms.TextBox();
            this.label9_nazwiskoAutora = new System.Windows.Forms.Label();
            this.textISBN = new System.Windows.Forms.TextBox();
            this.label10_nrISBN = new System.Windows.Forms.Label();
            this.textEMail = new System.Windows.Forms.TextBox();
            this.label_emial = new System.Windows.Forms.Label();
            this.textPesel = new System.Windows.Forms.TextBox();
            this.label_pesel = new System.Windows.Forms.Label();
            this.text_IdUsera = new System.Windows.Forms.TextBox();
            this.label_IdUsera = new System.Windows.Forms.Label();
            this.text_nazwiskoUsera = new System.Windows.Forms.TextBox();
            this.label_NazwiskoUsera = new System.Windows.Forms.Label();
            this.text_ImieUsera = new System.Windows.Forms.TextBox();
            this.label_Imie = new System.Windows.Forms.Label();
            this.text_haslo = new System.Windows.Forms.TextBox();
            this.label4_haslo = new System.Windows.Forms.Label();
            this.button_dodajUsera = new System.Windows.Forms.Button();
            this.listBox_ksiazkiPracownik = new System.Windows.Forms.ListBox();
            this.listBox2_uzytkownicy = new System.Windows.Forms.ListBox();
            this.dataGridViewPokazUserow = new System.Windows.Forms.DataGridView();
            this.button_pokazCzytelnikow = new System.Windows.Forms.Button();
            this.button_usunUserazTabeli = new System.Windows.Forms.Button();
            this.dataGridView_ksiazkiTabela = new System.Windows.Forms.DataGridView();
            this.button_usunKsiazkezTabeli = new System.Windows.Forms.Button();
            this.button_pokazKsiazkiTabela = new System.Windows.Forms.Button();
            this.button_pokazWypozyczenia = new System.Windows.Forms.Button();
            this.comboBox_rodzajeKsiazke = new System.Windows.Forms.ComboBox();
            this.comboBox_stan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_sortowanieNaj = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_limit = new System.Windows.Forms.TextBox();
            this.label_limit = new System.Windows.Forms.Label();
            this.label_kategoria = new System.Windows.Forms.Label();
            this.comboBox_kategoria = new System.Windows.Forms.ComboBox();
            this.textBox_maxCzasWypozyczenia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_stanowisko = new System.Windows.Forms.TextBox();
            this.label_stanowisko = new System.Windows.Forms.Label();
            this.button_pokazPracownikow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokazUserow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ksiazkiTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_powrotDoGlownego
            // 
            this.button1_powrotDoGlownego.Location = new System.Drawing.Point(851, 1);
            this.button1_powrotDoGlownego.Name = "button1_powrotDoGlownego";
            this.button1_powrotDoGlownego.Size = new System.Drawing.Size(124, 36);
            this.button1_powrotDoGlownego.TabIndex = 0;
            this.button1_powrotDoGlownego.Text = "powrót do ekranu głównego";
            this.button1_powrotDoGlownego.UseVisualStyleBackColor = true;
            this.button1_powrotDoGlownego.Click += new System.EventHandler(this.button1_powrotDoGlownego_Click);
            // 
            // button1_dodajKsiazke
            // 
            this.button1_dodajKsiazke.Location = new System.Drawing.Point(12, 347);
            this.button1_dodajKsiazke.Name = "button1_dodajKsiazke";
            this.button1_dodajKsiazke.Size = new System.Drawing.Size(103, 23);
            this.button1_dodajKsiazke.TabIndex = 1;
            this.button1_dodajKsiazke.Text = "dodaj książke";
            this.button1_dodajKsiazke.UseVisualStyleBackColor = true;
            this.button1_dodajKsiazke.Click += new System.EventHandler(this.button1_dodajKsiazke_Click);
            // 
            // label1_id
            // 
            this.label1_id.AutoSize = true;
            this.label1_id.Location = new System.Drawing.Point(12, 36);
            this.label1_id.Name = "label1_id";
            this.label1_id.Size = new System.Drawing.Size(15, 13);
            this.label1_id.TabIndex = 2;
            this.label1_id.Text = "id";
            this.label1_id.Click += new System.EventHandler(this.label1_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(108, 36);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 3;
            // 
            // textTytul
            // 
            this.textTytul.Location = new System.Drawing.Point(108, 61);
            this.textTytul.Name = "textTytul";
            this.textTytul.Size = new System.Drawing.Size(100, 20);
            this.textTytul.TabIndex = 5;
            // 
            // label2_tytul
            // 
            this.label2_tytul.AutoSize = true;
            this.label2_tytul.Location = new System.Drawing.Point(12, 61);
            this.label2_tytul.Name = "label2_tytul";
            this.label2_tytul.Size = new System.Drawing.Size(26, 13);
            this.label2_tytul.TabIndex = 4;
            this.label2_tytul.Text = "tytul";
            // 
            // textStan
            // 
            this.textStan.Location = new System.Drawing.Point(108, 86);
            this.textStan.Name = "textStan";
            this.textStan.Size = new System.Drawing.Size(100, 20);
            this.textStan.TabIndex = 7;
            // 
            // label3_stan
            // 
            this.label3_stan.AutoSize = true;
            this.label3_stan.Location = new System.Drawing.Point(12, 86);
            this.label3_stan.Name = "label3_stan";
            this.label3_stan.Size = new System.Drawing.Size(27, 13);
            this.label3_stan.TabIndex = 6;
            this.label3_stan.Text = "stan";
            // 
            // textRodzaj
            // 
            this.textRodzaj.Location = new System.Drawing.Point(108, 111);
            this.textRodzaj.Name = "textRodzaj";
            this.textRodzaj.Size = new System.Drawing.Size(100, 20);
            this.textRodzaj.TabIndex = 9;
            // 
            // label4_rodzaj
            // 
            this.label4_rodzaj.AutoSize = true;
            this.label4_rodzaj.Location = new System.Drawing.Point(12, 293);
            this.label4_rodzaj.Name = "label4_rodzaj";
            this.label4_rodzaj.Size = new System.Drawing.Size(35, 13);
            this.label4_rodzaj.TabIndex = 8;
            this.label4_rodzaj.Text = "rodzaj";
            // 
            // textLicznikWyp
            // 
            this.textLicznikWyp.Location = new System.Drawing.Point(108, 137);
            this.textLicznikWyp.Name = "textLicznikWyp";
            this.textLicznikWyp.Size = new System.Drawing.Size(100, 20);
            this.textLicznikWyp.TabIndex = 11;
            // 
            // label5_licznikWypozyczen
            // 
            this.label5_licznikWypozyczen.AutoSize = true;
            this.label5_licznikWypozyczen.Location = new System.Drawing.Point(12, 137);
            this.label5_licznikWypozyczen.Name = "label5_licznikWypozyczen";
            this.label5_licznikWypozyczen.Size = new System.Drawing.Size(97, 13);
            this.label5_licznikWypozyczen.TabIndex = 10;
            this.label5_licznikWypozyczen.Text = "licznik wypożyczeń";
            // 
            // textLicznikPrzed
            // 
            this.textLicznikPrzed.Location = new System.Drawing.Point(108, 162);
            this.textLicznikPrzed.Name = "textLicznikPrzed";
            this.textLicznikPrzed.Size = new System.Drawing.Size(100, 20);
            this.textLicznikPrzed.TabIndex = 13;
            // 
            // label6_licznikPrzedluzen
            // 
            this.label6_licznikPrzedluzen.AutoSize = true;
            this.label6_licznikPrzedluzen.Location = new System.Drawing.Point(12, 162);
            this.label6_licznikPrzedluzen.Name = "label6_licznikPrzedluzen";
            this.label6_licznikPrzedluzen.Size = new System.Drawing.Size(92, 13);
            this.label6_licznikPrzedluzen.TabIndex = 12;
            this.label6_licznikPrzedluzen.Text = "licznik przedłużeń";
            this.label6_licznikPrzedluzen.Click += new System.EventHandler(this.label6_licznikPrzedluzen_Click);
            // 
            // textIloscStron
            // 
            this.textIloscStron.Location = new System.Drawing.Point(108, 187);
            this.textIloscStron.Name = "textIloscStron";
            this.textIloscStron.Size = new System.Drawing.Size(100, 20);
            this.textIloscStron.TabIndex = 15;
            // 
            // label7_iloscStron
            // 
            this.label7_iloscStron.AutoSize = true;
            this.label7_iloscStron.Location = new System.Drawing.Point(12, 187);
            this.label7_iloscStron.Name = "label7_iloscStron";
            this.label7_iloscStron.Size = new System.Drawing.Size(54, 13);
            this.label7_iloscStron.TabIndex = 14;
            this.label7_iloscStron.Text = "ilosc stron";
            // 
            // textImieAutora
            // 
            this.textImieAutora.Location = new System.Drawing.Point(108, 213);
            this.textImieAutora.Name = "textImieAutora";
            this.textImieAutora.Size = new System.Drawing.Size(100, 20);
            this.textImieAutora.TabIndex = 17;
            // 
            // label8_imieAutora
            // 
            this.label8_imieAutora.AutoSize = true;
            this.label8_imieAutora.Location = new System.Drawing.Point(12, 213);
            this.label8_imieAutora.Name = "label8_imieAutora";
            this.label8_imieAutora.Size = new System.Drawing.Size(58, 13);
            this.label8_imieAutora.TabIndex = 16;
            this.label8_imieAutora.Text = "imie autora";
            // 
            // textNazwiskoAutora
            // 
            this.textNazwiskoAutora.Location = new System.Drawing.Point(108, 238);
            this.textNazwiskoAutora.Name = "textNazwiskoAutora";
            this.textNazwiskoAutora.Size = new System.Drawing.Size(100, 20);
            this.textNazwiskoAutora.TabIndex = 19;
            // 
            // label9_nazwiskoAutora
            // 
            this.label9_nazwiskoAutora.AutoSize = true;
            this.label9_nazwiskoAutora.Location = new System.Drawing.Point(12, 238);
            this.label9_nazwiskoAutora.Name = "label9_nazwiskoAutora";
            this.label9_nazwiskoAutora.Size = new System.Drawing.Size(84, 13);
            this.label9_nazwiskoAutora.TabIndex = 18;
            this.label9_nazwiskoAutora.Text = "nazwisko autora";
            // 
            // textISBN
            // 
            this.textISBN.Location = new System.Drawing.Point(108, 264);
            this.textISBN.Name = "textISBN";
            this.textISBN.Size = new System.Drawing.Size(100, 20);
            this.textISBN.TabIndex = 21;
            this.textISBN.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label10_nrISBN
            // 
            this.label10_nrISBN.AutoSize = true;
            this.label10_nrISBN.Location = new System.Drawing.Point(12, 264);
            this.label10_nrISBN.Name = "label10_nrISBN";
            this.label10_nrISBN.Size = new System.Drawing.Size(44, 13);
            this.label10_nrISBN.TabIndex = 20;
            this.label10_nrISBN.Text = "nr ISBN";
            this.label10_nrISBN.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textEMail
            // 
            this.textEMail.Location = new System.Drawing.Point(667, 161);
            this.textEMail.Name = "textEMail";
            this.textEMail.Size = new System.Drawing.Size(100, 20);
            this.textEMail.TabIndex = 31;
            // 
            // label_emial
            // 
            this.label_emial.AutoSize = true;
            this.label_emial.Location = new System.Drawing.Point(619, 161);
            this.label_emial.Name = "label_emial";
            this.label_emial.Size = new System.Drawing.Size(34, 13);
            this.label_emial.TabIndex = 30;
            this.label_emial.Text = "e-mail";
            // 
            // textPesel
            // 
            this.textPesel.Location = new System.Drawing.Point(667, 135);
            this.textPesel.Name = "textPesel";
            this.textPesel.Size = new System.Drawing.Size(100, 20);
            this.textPesel.TabIndex = 29;
            // 
            // label_pesel
            // 
            this.label_pesel.AutoSize = true;
            this.label_pesel.Location = new System.Drawing.Point(619, 135);
            this.label_pesel.Name = "label_pesel";
            this.label_pesel.Size = new System.Drawing.Size(32, 13);
            this.label_pesel.TabIndex = 28;
            this.label_pesel.Text = "pesel";
            // 
            // text_IdUsera
            // 
            this.text_IdUsera.Location = new System.Drawing.Point(667, 36);
            this.text_IdUsera.Name = "text_IdUsera";
            this.text_IdUsera.Size = new System.Drawing.Size(100, 20);
            this.text_IdUsera.TabIndex = 27;
            // 
            // label_IdUsera
            // 
            this.label_IdUsera.AutoSize = true;
            this.label_IdUsera.Location = new System.Drawing.Point(619, 39);
            this.label_IdUsera.Name = "label_IdUsera";
            this.label_IdUsera.Size = new System.Drawing.Size(15, 13);
            this.label_IdUsera.TabIndex = 26;
            this.label_IdUsera.Text = "id";
            // 
            // text_nazwiskoUsera
            // 
            this.text_nazwiskoUsera.Location = new System.Drawing.Point(667, 109);
            this.text_nazwiskoUsera.Name = "text_nazwiskoUsera";
            this.text_nazwiskoUsera.Size = new System.Drawing.Size(100, 20);
            this.text_nazwiskoUsera.TabIndex = 25;
            // 
            // label_NazwiskoUsera
            // 
            this.label_NazwiskoUsera.AutoSize = true;
            this.label_NazwiskoUsera.Location = new System.Drawing.Point(619, 109);
            this.label_NazwiskoUsera.Name = "label_NazwiskoUsera";
            this.label_NazwiskoUsera.Size = new System.Drawing.Size(46, 13);
            this.label_NazwiskoUsera.TabIndex = 24;
            this.label_NazwiskoUsera.Text = "nawsiko";
            // 
            // text_ImieUsera
            // 
            this.text_ImieUsera.Location = new System.Drawing.Point(667, 84);
            this.text_ImieUsera.Name = "text_ImieUsera";
            this.text_ImieUsera.Size = new System.Drawing.Size(100, 20);
            this.text_ImieUsera.TabIndex = 23;
            // 
            // label_Imie
            // 
            this.label_Imie.AutoSize = true;
            this.label_Imie.Location = new System.Drawing.Point(619, 84);
            this.label_Imie.Name = "label_Imie";
            this.label_Imie.Size = new System.Drawing.Size(25, 13);
            this.label_Imie.TabIndex = 22;
            this.label_Imie.Text = "imie";
            // 
            // text_haslo
            // 
            this.text_haslo.Location = new System.Drawing.Point(667, 60);
            this.text_haslo.Name = "text_haslo";
            this.text_haslo.Size = new System.Drawing.Size(100, 20);
            this.text_haslo.TabIndex = 35;
            // 
            // label4_haslo
            // 
            this.label4_haslo.AutoSize = true;
            this.label4_haslo.Location = new System.Drawing.Point(619, 60);
            this.label4_haslo.Name = "label4_haslo";
            this.label4_haslo.Size = new System.Drawing.Size(32, 13);
            this.label4_haslo.TabIndex = 34;
            this.label4_haslo.Text = "haslo";
            // 
            // button_dodajUsera
            // 
            this.button_dodajUsera.Location = new System.Drawing.Point(802, 160);
            this.button_dodajUsera.Name = "button_dodajUsera";
            this.button_dodajUsera.Size = new System.Drawing.Size(103, 23);
            this.button_dodajUsera.TabIndex = 36;
            this.button_dodajUsera.Text = "dodaj uzytkownika";
            this.button_dodajUsera.UseVisualStyleBackColor = true;
            this.button_dodajUsera.Click += new System.EventHandler(this.button_dodajUsera_Click);
            // 
            // listBox_ksiazkiPracownik
            // 
            this.listBox_ksiazkiPracownik.FormattingEnabled = true;
            this.listBox_ksiazkiPracownik.Location = new System.Drawing.Point(214, 36);
            this.listBox_ksiazkiPracownik.Name = "listBox_ksiazkiPracownik";
            this.listBox_ksiazkiPracownik.Size = new System.Drawing.Size(399, 147);
            this.listBox_ksiazkiPracownik.TabIndex = 38;
            // 
            // listBox2_uzytkownicy
            // 
            this.listBox2_uzytkownicy.FormattingEnabled = true;
            this.listBox2_uzytkownicy.Location = new System.Drawing.Point(781, 38);
            this.listBox2_uzytkownicy.Name = "listBox2_uzytkownicy";
            this.listBox2_uzytkownicy.Size = new System.Drawing.Size(199, 82);
            this.listBox2_uzytkownicy.TabIndex = 39;
            // 
            // dataGridViewPokazUserow
            // 
            this.dataGridViewPokazUserow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPokazUserow.Location = new System.Drawing.Point(667, 282);
            this.dataGridViewPokazUserow.Name = "dataGridViewPokazUserow";
            this.dataGridViewPokazUserow.Size = new System.Drawing.Size(326, 150);
            this.dataGridViewPokazUserow.TabIndex = 43;
            // 
            // button_pokazCzytelnikow
            // 
            this.button_pokazCzytelnikow.Location = new System.Drawing.Point(618, 433);
            this.button_pokazCzytelnikow.Name = "button_pokazCzytelnikow";
            this.button_pokazCzytelnikow.Size = new System.Drawing.Size(117, 23);
            this.button_pokazCzytelnikow.TabIndex = 44;
            this.button_pokazCzytelnikow.Text = "pokaz czytelników";
            this.button_pokazCzytelnikow.UseVisualStyleBackColor = true;
            this.button_pokazCzytelnikow.Click += new System.EventHandler(this.button_pokazCzytelnikowDataGrid_Click);
            // 
            // button_usunUserazTabeli
            // 
            this.button_usunUserazTabeli.Location = new System.Drawing.Point(876, 433);
            this.button_usunUserazTabeli.Name = "button_usunUserazTabeli";
            this.button_usunUserazTabeli.Size = new System.Drawing.Size(117, 23);
            this.button_usunUserazTabeli.TabIndex = 45;
            this.button_usunUserazTabeli.Text = "usun uzytkownika";
            this.button_usunUserazTabeli.UseVisualStyleBackColor = true;
            this.button_usunUserazTabeli.Click += new System.EventHandler(this.button_usunUserazTabeli_Click);
            // 
            // dataGridView_ksiazkiTabela
            // 
            this.dataGridView_ksiazkiTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ksiazkiTabela.Location = new System.Drawing.Point(214, 218);
            this.dataGridView_ksiazkiTabela.Name = "dataGridView_ksiazkiTabela";
            this.dataGridView_ksiazkiTabela.Size = new System.Drawing.Size(366, 150);
            this.dataGridView_ksiazkiTabela.TabIndex = 46;
            // 
            // button_usunKsiazkezTabeli
            // 
            this.button_usunKsiazkezTabeli.Location = new System.Drawing.Point(338, 374);
            this.button_usunKsiazkezTabeli.Name = "button_usunKsiazkezTabeli";
            this.button_usunKsiazkezTabeli.Size = new System.Drawing.Size(103, 23);
            this.button_usunKsiazkezTabeli.TabIndex = 48;
            this.button_usunKsiazkezTabeli.Text = "usun ksiazke";
            this.button_usunKsiazkezTabeli.UseVisualStyleBackColor = true;
            this.button_usunKsiazkezTabeli.Click += new System.EventHandler(this.button_usunKsiazkezTabeli_Click);
            // 
            // button_pokazKsiazkiTabela
            // 
            this.button_pokazKsiazkiTabela.Location = new System.Drawing.Point(214, 374);
            this.button_pokazKsiazkiTabela.Name = "button_pokazKsiazkiTabela";
            this.button_pokazKsiazkiTabela.Size = new System.Drawing.Size(103, 23);
            this.button_pokazKsiazkiTabela.TabIndex = 47;
            this.button_pokazKsiazkiTabela.Text = "pokaz ksiazki";
            this.button_pokazKsiazkiTabela.UseVisualStyleBackColor = true;
            this.button_pokazKsiazkiTabela.Click += new System.EventHandler(this.button_pokazKsiazkiTabela_Click);
            // 
            // button_pokazWypozyczenia
            // 
            this.button_pokazWypozyczenia.Location = new System.Drawing.Point(463, 376);
            this.button_pokazWypozyczenia.Name = "button_pokazWypozyczenia";
            this.button_pokazWypozyczenia.Size = new System.Drawing.Size(117, 23);
            this.button_pokazWypozyczenia.TabIndex = 49;
            this.button_pokazWypozyczenia.Text = "pokaz wypozyczenia";
            this.button_pokazWypozyczenia.UseVisualStyleBackColor = true;
            this.button_pokazWypozyczenia.Click += new System.EventHandler(this.button_pokazWypozyczenia_Click);
            // 
            // comboBox_rodzajeKsiazke
            // 
            this.comboBox_rodzajeKsiazke.FormattingEnabled = true;
            this.comboBox_rodzajeKsiazke.Items.AddRange(new object[] {
            "powieść",
            "kryminał",
            "popularno-naukowa",
            "języki obce",
            "liryki",
            "horror",
            "romans"});
            this.comboBox_rodzajeKsiazke.Location = new System.Drawing.Point(87, 290);
            this.comboBox_rodzajeKsiazke.Name = "comboBox_rodzajeKsiazke";
            this.comboBox_rodzajeKsiazke.Size = new System.Drawing.Size(121, 21);
            this.comboBox_rodzajeKsiazke.TabIndex = 50;
            // 
            // comboBox_stan
            // 
            this.comboBox_stan.FormattingEnabled = true;
            this.comboBox_stan.Items.AddRange(new object[] {
            "true",
            "false"});
            this.comboBox_stan.Location = new System.Drawing.Point(87, 317);
            this.comboBox_stan.Name = "comboBox_stan";
            this.comboBox_stan.Size = new System.Drawing.Size(121, 21);
            this.comboBox_stan.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "stan (dostepna)";
            // 
            // comboBox_sortowanieNaj
            // 
            this.comboBox_sortowanieNaj.FormattingEnabled = true;
            this.comboBox_sortowanieNaj.Items.AddRange(new object[] {
            "najczęściej czytane",
            "najrzadziej czytane"});
            this.comboBox_sortowanieNaj.Location = new System.Drawing.Point(486, 12);
            this.comboBox_sortowanieNaj.Name = "comboBox_sortowanieNaj";
            this.comboBox_sortowanieNaj.Size = new System.Drawing.Size(121, 21);
            this.comboBox_sortowanieNaj.TabIndex = 54;
            this.comboBox_sortowanieNaj.SelectedIndexChanged += new System.EventHandler(this.comboBox_sortowanieNaj_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "sortuj tytuły";
            // 
            // textBox_limit
            // 
            this.textBox_limit.Location = new System.Drawing.Point(667, 213);
            this.textBox_limit.Name = "textBox_limit";
            this.textBox_limit.Size = new System.Drawing.Size(100, 20);
            this.textBox_limit.TabIndex = 57;
            this.textBox_limit.TextChanged += new System.EventHandler(this.textBox_limit_TextChanged);
            // 
            // label_limit
            // 
            this.label_limit.AutoSize = true;
            this.label_limit.Location = new System.Drawing.Point(619, 216);
            this.label_limit.Name = "label_limit";
            this.label_limit.Size = new System.Drawing.Size(24, 13);
            this.label_limit.TabIndex = 56;
            this.label_limit.Text = "limit";
            this.label_limit.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_kategoria
            // 
            this.label_kategoria.AutoSize = true;
            this.label_kategoria.Location = new System.Drawing.Point(600, 190);
            this.label_kategoria.Name = "label_kategoria";
            this.label_kategoria.Size = new System.Drawing.Size(51, 13);
            this.label_kategoria.TabIndex = 59;
            this.label_kategoria.Text = "kategoria";
            // 
            // comboBox_kategoria
            // 
            this.comboBox_kategoria.FormattingEnabled = true;
            this.comboBox_kategoria.Items.AddRange(new object[] {
            "wykładowca",
            "student",
            "zwykły czytelnik",
            "pracownik"});
            this.comboBox_kategoria.Location = new System.Drawing.Point(667, 187);
            this.comboBox_kategoria.Name = "comboBox_kategoria";
            this.comboBox_kategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBox_kategoria.TabIndex = 58;
            this.comboBox_kategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox_kategoria_SelectedIndexChanged);
            // 
            // textBox_maxCzasWypozyczenia
            // 
            this.textBox_maxCzasWypozyczenia.Location = new System.Drawing.Point(663, 240);
            this.textBox_maxCzasWypozyczenia.Name = "textBox_maxCzasWypozyczenia";
            this.textBox_maxCzasWypozyczenia.Size = new System.Drawing.Size(100, 20);
            this.textBox_maxCzasWypozyczenia.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "max czas wypozyczenia";
            // 
            // textBox_stanowisko
            // 
            this.textBox_stanowisko.Location = new System.Drawing.Point(663, 266);
            this.textBox_stanowisko.Name = "textBox_stanowisko";
            this.textBox_stanowisko.Size = new System.Drawing.Size(100, 20);
            this.textBox_stanowisko.TabIndex = 63;
            // 
            // label_stanowisko
            // 
            this.label_stanowisko.AutoSize = true;
            this.label_stanowisko.Location = new System.Drawing.Point(615, 266);
            this.label_stanowisko.Name = "label_stanowisko";
            this.label_stanowisko.Size = new System.Drawing.Size(60, 13);
            this.label_stanowisko.TabIndex = 62;
            this.label_stanowisko.Text = "stanowisko";
            // 
            // button_pokazPracownikow
            // 
            this.button_pokazPracownikow.Location = new System.Drawing.Point(741, 433);
            this.button_pokazPracownikow.Name = "button_pokazPracownikow";
            this.button_pokazPracownikow.Size = new System.Drawing.Size(117, 23);
            this.button_pokazPracownikow.TabIndex = 64;
            this.button_pokazPracownikow.Text = "pokaz pracowników";
            this.button_pokazPracownikow.UseVisualStyleBackColor = true;
            this.button_pokazPracownikow.Click += new System.EventHandler(this.button_pokazPracownikow_Click);
            // 
            // Form2_PanelPracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 464);
            this.Controls.Add(this.button_pokazPracownikow);
            this.Controls.Add(this.textBox_stanowisko);
            this.Controls.Add(this.label_stanowisko);
            this.Controls.Add(this.textBox_maxCzasWypozyczenia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_kategoria);
            this.Controls.Add(this.comboBox_kategoria);
            this.Controls.Add(this.textBox_limit);
            this.Controls.Add(this.label_limit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_sortowanieNaj);
            this.Controls.Add(this.comboBox_stan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_rodzajeKsiazke);
            this.Controls.Add(this.button_pokazWypozyczenia);
            this.Controls.Add(this.button_usunKsiazkezTabeli);
            this.Controls.Add(this.button_pokazKsiazkiTabela);
            this.Controls.Add(this.dataGridView_ksiazkiTabela);
            this.Controls.Add(this.button_usunUserazTabeli);
            this.Controls.Add(this.button_pokazCzytelnikow);
            this.Controls.Add(this.dataGridViewPokazUserow);
            this.Controls.Add(this.listBox2_uzytkownicy);
            this.Controls.Add(this.listBox_ksiazkiPracownik);
            this.Controls.Add(this.button_dodajUsera);
            this.Controls.Add(this.text_haslo);
            this.Controls.Add(this.label4_haslo);
            this.Controls.Add(this.textEMail);
            this.Controls.Add(this.label_emial);
            this.Controls.Add(this.textPesel);
            this.Controls.Add(this.label_pesel);
            this.Controls.Add(this.text_IdUsera);
            this.Controls.Add(this.label_IdUsera);
            this.Controls.Add(this.text_nazwiskoUsera);
            this.Controls.Add(this.label_NazwiskoUsera);
            this.Controls.Add(this.text_ImieUsera);
            this.Controls.Add(this.label_Imie);
            this.Controls.Add(this.textISBN);
            this.Controls.Add(this.label10_nrISBN);
            this.Controls.Add(this.textNazwiskoAutora);
            this.Controls.Add(this.label9_nazwiskoAutora);
            this.Controls.Add(this.textImieAutora);
            this.Controls.Add(this.label8_imieAutora);
            this.Controls.Add(this.textIloscStron);
            this.Controls.Add(this.label7_iloscStron);
            this.Controls.Add(this.textLicznikPrzed);
            this.Controls.Add(this.label6_licznikPrzedluzen);
            this.Controls.Add(this.textLicznikWyp);
            this.Controls.Add(this.label5_licznikWypozyczen);
            this.Controls.Add(this.textRodzaj);
            this.Controls.Add(this.label4_rodzaj);
            this.Controls.Add(this.textStan);
            this.Controls.Add(this.label3_stan);
            this.Controls.Add(this.textTytul);
            this.Controls.Add(this.label2_tytul);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label1_id);
            this.Controls.Add(this.button1_dodajKsiazke);
            this.Controls.Add(this.button1_powrotDoGlownego);
            this.Name = "Form2_PanelPracownika";
            this.Text = "Form2_PanelPracownika";
            this.Load += new System.EventHandler(this.Form2_PanelPracownika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokazUserow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ksiazkiTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_powrotDoGlownego;
        private System.Windows.Forms.Button button1_dodajKsiazke;
        private System.Windows.Forms.Label label1_id;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textTytul;
        private System.Windows.Forms.Label label2_tytul;
        private System.Windows.Forms.TextBox textStan;
        private System.Windows.Forms.Label label3_stan;
        private System.Windows.Forms.TextBox textRodzaj;
        private System.Windows.Forms.Label label4_rodzaj;
        private System.Windows.Forms.TextBox textLicznikWyp;
        private System.Windows.Forms.Label label5_licznikWypozyczen;
        private System.Windows.Forms.TextBox textLicznikPrzed;
        private System.Windows.Forms.Label label6_licznikPrzedluzen;
        private System.Windows.Forms.TextBox textIloscStron;
        private System.Windows.Forms.Label label7_iloscStron;
        private System.Windows.Forms.TextBox textImieAutora;
        private System.Windows.Forms.Label label8_imieAutora;
        private System.Windows.Forms.TextBox textNazwiskoAutora;
        private System.Windows.Forms.Label label9_nazwiskoAutora;
        private System.Windows.Forms.TextBox textISBN;
        private System.Windows.Forms.Label label10_nrISBN;
        private System.Windows.Forms.TextBox textEMail;
        private System.Windows.Forms.Label label_emial;
        private System.Windows.Forms.TextBox textPesel;
        private System.Windows.Forms.Label label_pesel;
        private System.Windows.Forms.TextBox text_IdUsera;
        private System.Windows.Forms.Label label_IdUsera;
        private System.Windows.Forms.TextBox text_nazwiskoUsera;
        private System.Windows.Forms.Label label_NazwiskoUsera;
        private System.Windows.Forms.TextBox text_ImieUsera;
        private System.Windows.Forms.Label label_Imie;
        private System.Windows.Forms.TextBox text_haslo;
        private System.Windows.Forms.Label label4_haslo;
        private System.Windows.Forms.Button button_dodajUsera;
        private System.Windows.Forms.ListBox listBox_ksiazkiPracownik;
        private System.Windows.Forms.ListBox listBox2_uzytkownicy;
        private System.Windows.Forms.DataGridView dataGridViewPokazUserow;
        private System.Windows.Forms.Button button_pokazCzytelnikow;
        private System.Windows.Forms.Button button_usunUserazTabeli;
        private System.Windows.Forms.DataGridView dataGridView_ksiazkiTabela;
        private System.Windows.Forms.Button button_usunKsiazkezTabeli;
        private System.Windows.Forms.Button button_pokazKsiazkiTabela;
        private System.Windows.Forms.Button button_pokazWypozyczenia;
        private System.Windows.Forms.ComboBox comboBox_rodzajeKsiazke;
        private System.Windows.Forms.ComboBox comboBox_stan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_sortowanieNaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_limit;
        private System.Windows.Forms.Label label_limit;
        private System.Windows.Forms.Label label_kategoria;
        private System.Windows.Forms.ComboBox comboBox_kategoria;
        private System.Windows.Forms.TextBox textBox_maxCzasWypozyczenia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_stanowisko;
        private System.Windows.Forms.Label label_stanowisko;
        private System.Windows.Forms.Button button_pokazPracownikow;
    }
}