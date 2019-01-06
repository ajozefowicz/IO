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
            this.textTytul = new System.Windows.Forms.TextBox();
            this.label2_tytul = new System.Windows.Forms.Label();
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
            this.textBox_iloscMinut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ktoCzyta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_kategoriaEgzemplarza = new System.Windows.Forms.ComboBox();
            this.button_przejscieDoSekcjiCzytelnika = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokazUserow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ksiazkiTabela)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1_powrotDoGlownego
            // 
            this.button1_powrotDoGlownego.Location = new System.Drawing.Point(1007, 0);
            this.button1_powrotDoGlownego.Name = "button1_powrotDoGlownego";
            this.button1_powrotDoGlownego.Size = new System.Drawing.Size(124, 36);
            this.button1_powrotDoGlownego.TabIndex = 0;
            this.button1_powrotDoGlownego.Text = "powrót do ekranu głównego";
            this.button1_powrotDoGlownego.UseVisualStyleBackColor = true;
            this.button1_powrotDoGlownego.Click += new System.EventHandler(this.button1_powrotDoGlownego_Click);
            // 
            // button1_dodajKsiazke
            // 
            this.button1_dodajKsiazke.Location = new System.Drawing.Point(465, 146);
            this.button1_dodajKsiazke.Name = "button1_dodajKsiazke";
            this.button1_dodajKsiazke.Size = new System.Drawing.Size(103, 23);
            this.button1_dodajKsiazke.TabIndex = 1;
            this.button1_dodajKsiazke.Text = "dodaj egzemplarz";
            this.button1_dodajKsiazke.UseVisualStyleBackColor = true;
            this.button1_dodajKsiazke.Click += new System.EventHandler(this.dodajEgzemplarz);
            // 
            // textTytul
            // 
            this.textTytul.Location = new System.Drawing.Point(109, 41);
            this.textTytul.Name = "textTytul";
            this.textTytul.Size = new System.Drawing.Size(100, 20);
            this.textTytul.TabIndex = 5;
            // 
            // label2_tytul
            // 
            this.label2_tytul.AutoSize = true;
            this.label2_tytul.Location = new System.Drawing.Point(13, 44);
            this.label2_tytul.Name = "label2_tytul";
            this.label2_tytul.Size = new System.Drawing.Size(26, 13);
            this.label2_tytul.TabIndex = 4;
            this.label2_tytul.Text = "tytul";
            this.label2_tytul.Click += new System.EventHandler(this.label2_tytul_Click);
            // 
            // label4_rodzaj
            // 
            this.label4_rodzaj.AutoSize = true;
            this.label4_rodzaj.Location = new System.Drawing.Point(13, 70);
            this.label4_rodzaj.Name = "label4_rodzaj";
            this.label4_rodzaj.Size = new System.Drawing.Size(35, 13);
            this.label4_rodzaj.TabIndex = 8;
            this.label4_rodzaj.Text = "rodzaj";
            // 
            // textLicznikWyp
            // 
            this.textLicznikWyp.Location = new System.Drawing.Point(109, 120);
            this.textLicznikWyp.Name = "textLicznikWyp";
            this.textLicznikWyp.Size = new System.Drawing.Size(100, 20);
            this.textLicznikWyp.TabIndex = 11;
            // 
            // label5_licznikWypozyczen
            // 
            this.label5_licznikWypozyczen.AutoSize = true;
            this.label5_licznikWypozyczen.Location = new System.Drawing.Point(13, 124);
            this.label5_licznikWypozyczen.Name = "label5_licznikWypozyczen";
            this.label5_licznikWypozyczen.Size = new System.Drawing.Size(97, 13);
            this.label5_licznikWypozyczen.TabIndex = 10;
            this.label5_licznikWypozyczen.Text = "licznik wypożyczeń";
            // 
            // textLicznikPrzed
            // 
            this.textLicznikPrzed.Location = new System.Drawing.Point(109, 146);
            this.textLicznikPrzed.Name = "textLicznikPrzed";
            this.textLicznikPrzed.Size = new System.Drawing.Size(100, 20);
            this.textLicznikPrzed.TabIndex = 13;
            // 
            // label6_licznikPrzedluzen
            // 
            this.label6_licznikPrzedluzen.AutoSize = true;
            this.label6_licznikPrzedluzen.Location = new System.Drawing.Point(13, 149);
            this.label6_licznikPrzedluzen.Name = "label6_licznikPrzedluzen";
            this.label6_licznikPrzedluzen.Size = new System.Drawing.Size(92, 13);
            this.label6_licznikPrzedluzen.TabIndex = 12;
            this.label6_licznikPrzedluzen.Text = "licznik przedłużeń";
            this.label6_licznikPrzedluzen.Click += new System.EventHandler(this.label6_licznikPrzedluzen_Click);
            // 
            // textIloscStron
            // 
            this.textIloscStron.Location = new System.Drawing.Point(298, 45);
            this.textIloscStron.Name = "textIloscStron";
            this.textIloscStron.Size = new System.Drawing.Size(100, 20);
            this.textIloscStron.TabIndex = 15;
            // 
            // label7_iloscStron
            // 
            this.label7_iloscStron.AutoSize = true;
            this.label7_iloscStron.Location = new System.Drawing.Point(215, 44);
            this.label7_iloscStron.Name = "label7_iloscStron";
            this.label7_iloscStron.Size = new System.Drawing.Size(54, 13);
            this.label7_iloscStron.TabIndex = 14;
            this.label7_iloscStron.Text = "ilosc stron";
            // 
            // textImieAutora
            // 
            this.textImieAutora.Location = new System.Drawing.Point(298, 71);
            this.textImieAutora.Name = "textImieAutora";
            this.textImieAutora.Size = new System.Drawing.Size(100, 20);
            this.textImieAutora.TabIndex = 17;
            // 
            // label8_imieAutora
            // 
            this.label8_imieAutora.AutoSize = true;
            this.label8_imieAutora.Location = new System.Drawing.Point(215, 70);
            this.label8_imieAutora.Name = "label8_imieAutora";
            this.label8_imieAutora.Size = new System.Drawing.Size(58, 13);
            this.label8_imieAutora.TabIndex = 16;
            this.label8_imieAutora.Text = "imie autora";
            // 
            // textNazwiskoAutora
            // 
            this.textNazwiskoAutora.Location = new System.Drawing.Point(298, 96);
            this.textNazwiskoAutora.Name = "textNazwiskoAutora";
            this.textNazwiskoAutora.Size = new System.Drawing.Size(100, 20);
            this.textNazwiskoAutora.TabIndex = 19;
            // 
            // label9_nazwiskoAutora
            // 
            this.label9_nazwiskoAutora.AutoSize = true;
            this.label9_nazwiskoAutora.Location = new System.Drawing.Point(215, 95);
            this.label9_nazwiskoAutora.Name = "label9_nazwiskoAutora";
            this.label9_nazwiskoAutora.Size = new System.Drawing.Size(84, 13);
            this.label9_nazwiskoAutora.TabIndex = 18;
            this.label9_nazwiskoAutora.Text = "nazwisko autora";
            // 
            // textISBN
            // 
            this.textISBN.Location = new System.Drawing.Point(298, 122);
            this.textISBN.Name = "textISBN";
            this.textISBN.Size = new System.Drawing.Size(100, 20);
            this.textISBN.TabIndex = 21;
            this.textISBN.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label10_nrISBN
            // 
            this.label10_nrISBN.AutoSize = true;
            this.label10_nrISBN.Location = new System.Drawing.Point(215, 121);
            this.label10_nrISBN.Name = "label10_nrISBN";
            this.label10_nrISBN.Size = new System.Drawing.Size(44, 13);
            this.label10_nrISBN.TabIndex = 20;
            this.label10_nrISBN.Text = "nr ISBN";
            this.label10_nrISBN.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textEMail
            // 
            this.textEMail.Location = new System.Drawing.Point(238, 39);
            this.textEMail.Name = "textEMail";
            this.textEMail.Size = new System.Drawing.Size(100, 20);
            this.textEMail.TabIndex = 31;
            // 
            // label_emial
            // 
            this.label_emial.AutoSize = true;
            this.label_emial.Location = new System.Drawing.Point(164, 40);
            this.label_emial.Name = "label_emial";
            this.label_emial.Size = new System.Drawing.Size(34, 13);
            this.label_emial.TabIndex = 30;
            this.label_emial.Text = "e-mail";
            // 
            // textPesel
            // 
            this.textPesel.Location = new System.Drawing.Point(58, 139);
            this.textPesel.Name = "textPesel";
            this.textPesel.Size = new System.Drawing.Size(100, 20);
            this.textPesel.TabIndex = 29;
            // 
            // label_pesel
            // 
            this.label_pesel.AutoSize = true;
            this.label_pesel.Location = new System.Drawing.Point(10, 139);
            this.label_pesel.Name = "label_pesel";
            this.label_pesel.Size = new System.Drawing.Size(32, 13);
            this.label_pesel.TabIndex = 28;
            this.label_pesel.Text = "pesel";
            // 
            // text_IdUsera
            // 
            this.text_IdUsera.Location = new System.Drawing.Point(58, 40);
            this.text_IdUsera.Name = "text_IdUsera";
            this.text_IdUsera.Size = new System.Drawing.Size(100, 20);
            this.text_IdUsera.TabIndex = 27;
            // 
            // label_IdUsera
            // 
            this.label_IdUsera.AutoSize = true;
            this.label_IdUsera.Location = new System.Drawing.Point(10, 43);
            this.label_IdUsera.Name = "label_IdUsera";
            this.label_IdUsera.Size = new System.Drawing.Size(15, 13);
            this.label_IdUsera.TabIndex = 26;
            this.label_IdUsera.Text = "id";
            // 
            // text_nazwiskoUsera
            // 
            this.text_nazwiskoUsera.Location = new System.Drawing.Point(58, 113);
            this.text_nazwiskoUsera.Name = "text_nazwiskoUsera";
            this.text_nazwiskoUsera.Size = new System.Drawing.Size(100, 20);
            this.text_nazwiskoUsera.TabIndex = 25;
            // 
            // label_NazwiskoUsera
            // 
            this.label_NazwiskoUsera.AutoSize = true;
            this.label_NazwiskoUsera.Location = new System.Drawing.Point(10, 113);
            this.label_NazwiskoUsera.Name = "label_NazwiskoUsera";
            this.label_NazwiskoUsera.Size = new System.Drawing.Size(46, 13);
            this.label_NazwiskoUsera.TabIndex = 24;
            this.label_NazwiskoUsera.Text = "nawsiko";
            // 
            // text_ImieUsera
            // 
            this.text_ImieUsera.Location = new System.Drawing.Point(58, 88);
            this.text_ImieUsera.Name = "text_ImieUsera";
            this.text_ImieUsera.Size = new System.Drawing.Size(100, 20);
            this.text_ImieUsera.TabIndex = 23;
            // 
            // label_Imie
            // 
            this.label_Imie.AutoSize = true;
            this.label_Imie.Location = new System.Drawing.Point(10, 88);
            this.label_Imie.Name = "label_Imie";
            this.label_Imie.Size = new System.Drawing.Size(25, 13);
            this.label_Imie.TabIndex = 22;
            this.label_Imie.Text = "imie";
            // 
            // text_haslo
            // 
            this.text_haslo.Location = new System.Drawing.Point(58, 64);
            this.text_haslo.Name = "text_haslo";
            this.text_haslo.Size = new System.Drawing.Size(100, 20);
            this.text_haslo.TabIndex = 35;
            // 
            // label4_haslo
            // 
            this.label4_haslo.AutoSize = true;
            this.label4_haslo.Location = new System.Drawing.Point(10, 64);
            this.label4_haslo.Name = "label4_haslo";
            this.label4_haslo.Size = new System.Drawing.Size(32, 13);
            this.label4_haslo.TabIndex = 34;
            this.label4_haslo.Text = "haslo";
            // 
            // button_dodajUsera
            // 
            this.button_dodajUsera.Location = new System.Drawing.Point(408, 138);
            this.button_dodajUsera.Name = "button_dodajUsera";
            this.button_dodajUsera.Size = new System.Drawing.Size(103, 23);
            this.button_dodajUsera.TabIndex = 36;
            this.button_dodajUsera.Text = "dodaj uzytkownika";
            this.button_dodajUsera.UseVisualStyleBackColor = true;
            this.button_dodajUsera.Click += new System.EventHandler(this.dodajUzytkownika);
            // 
            // listBox_ksiazkiPracownik
            // 
            this.listBox_ksiazkiPracownik.FormattingEnabled = true;
            this.listBox_ksiazkiPracownik.Location = new System.Drawing.Point(127, 502);
            this.listBox_ksiazkiPracownik.Name = "listBox_ksiazkiPracownik";
            this.listBox_ksiazkiPracownik.Size = new System.Drawing.Size(1004, 69);
            this.listBox_ksiazkiPracownik.TabIndex = 38;
            // 
            // dataGridViewPokazUserow
            // 
            this.dataGridViewPokazUserow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPokazUserow.Location = new System.Drawing.Point(127, 233);
            this.dataGridViewPokazUserow.Name = "dataGridViewPokazUserow";
            this.dataGridViewPokazUserow.Size = new System.Drawing.Size(1004, 119);
            this.dataGridViewPokazUserow.TabIndex = 43;
            this.dataGridViewPokazUserow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPokazUserow_CellContentClick);
            // 
            // button_pokazCzytelnikow
            // 
            this.button_pokazCzytelnikow.Location = new System.Drawing.Point(8, 262);
            this.button_pokazCzytelnikow.Name = "button_pokazCzytelnikow";
            this.button_pokazCzytelnikow.Size = new System.Drawing.Size(113, 23);
            this.button_pokazCzytelnikow.TabIndex = 44;
            this.button_pokazCzytelnikow.Text = "pokaz czytelników";
            this.button_pokazCzytelnikow.UseVisualStyleBackColor = true;
            this.button_pokazCzytelnikow.Click += new System.EventHandler(this.pokazCzytelnikow);
            // 
            // button_usunUserazTabeli
            // 
            this.button_usunUserazTabeli.Location = new System.Drawing.Point(8, 291);
            this.button_usunUserazTabeli.Name = "button_usunUserazTabeli";
            this.button_usunUserazTabeli.Size = new System.Drawing.Size(113, 23);
            this.button_usunUserazTabeli.TabIndex = 45;
            this.button_usunUserazTabeli.Text = "usun uzytkownika";
            this.button_usunUserazTabeli.UseVisualStyleBackColor = true;
            this.button_usunUserazTabeli.Click += new System.EventHandler(this.usunCzytelnikow);
            // 
            // dataGridView_ksiazkiTabela
            // 
            this.dataGridView_ksiazkiTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ksiazkiTabela.Location = new System.Drawing.Point(127, 358);
            this.dataGridView_ksiazkiTabela.Name = "dataGridView_ksiazkiTabela";
            this.dataGridView_ksiazkiTabela.Size = new System.Drawing.Size(1004, 111);
            this.dataGridView_ksiazkiTabela.TabIndex = 46;
            // 
            // button_usunKsiazkezTabeli
            // 
            this.button_usunKsiazkezTabeli.Location = new System.Drawing.Point(5, 387);
            this.button_usunKsiazkezTabeli.Name = "button_usunKsiazkezTabeli";
            this.button_usunKsiazkezTabeli.Size = new System.Drawing.Size(116, 23);
            this.button_usunKsiazkezTabeli.TabIndex = 48;
            this.button_usunKsiazkezTabeli.Text = "usun ksiazke";
            this.button_usunKsiazkezTabeli.UseVisualStyleBackColor = true;
            this.button_usunKsiazkezTabeli.Click += new System.EventHandler(this.usunKsiazke);
            // 
            // button_pokazKsiazkiTabela
            // 
            this.button_pokazKsiazkiTabela.Location = new System.Drawing.Point(5, 358);
            this.button_pokazKsiazkiTabela.Name = "button_pokazKsiazkiTabela";
            this.button_pokazKsiazkiTabela.Size = new System.Drawing.Size(116, 23);
            this.button_pokazKsiazkiTabela.TabIndex = 47;
            this.button_pokazKsiazkiTabela.Text = "pokaz ksiazki";
            this.button_pokazKsiazkiTabela.UseVisualStyleBackColor = true;
            this.button_pokazKsiazkiTabela.Click += new System.EventHandler(this.pokazKsiazki);
            // 
            // button_pokazWypozyczenia
            // 
            this.button_pokazWypozyczenia.Location = new System.Drawing.Point(5, 416);
            this.button_pokazWypozyczenia.Name = "button_pokazWypozyczenia";
            this.button_pokazWypozyczenia.Size = new System.Drawing.Size(117, 23);
            this.button_pokazWypozyczenia.TabIndex = 49;
            this.button_pokazWypozyczenia.Text = "pokaz wypozyczenia";
            this.button_pokazWypozyczenia.UseVisualStyleBackColor = true;
            this.button_pokazWypozyczenia.Click += new System.EventHandler(this.pokazWypozyczenia);
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
            this.comboBox_rodzajeKsiazke.Location = new System.Drawing.Point(109, 67);
            this.comboBox_rodzajeKsiazke.Name = "comboBox_rodzajeKsiazke";
            this.comboBox_rodzajeKsiazke.Size = new System.Drawing.Size(100, 21);
            this.comboBox_rodzajeKsiazke.TabIndex = 50;
            // 
            // comboBox_stan
            // 
            this.comboBox_stan.FormattingEnabled = true;
            this.comboBox_stan.Items.AddRange(new object[] {
            "true",
            "false"});
            this.comboBox_stan.Location = new System.Drawing.Point(109, 93);
            this.comboBox_stan.Name = "comboBox_stan";
            this.comboBox_stan.Size = new System.Drawing.Size(100, 21);
            this.comboBox_stan.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "stan (dostepna)";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // comboBox_sortowanieNaj
            // 
            this.comboBox_sortowanieNaj.FormattingEnabled = true;
            this.comboBox_sortowanieNaj.Items.AddRange(new object[] {
            "najczęściej czytane",
            "najrzadziej czytane"});
            this.comboBox_sortowanieNaj.Location = new System.Drawing.Point(289, 475);
            this.comboBox_sortowanieNaj.Name = "comboBox_sortowanieNaj";
            this.comboBox_sortowanieNaj.Size = new System.Drawing.Size(107, 21);
            this.comboBox_sortowanieNaj.TabIndex = 54;
            this.comboBox_sortowanieNaj.SelectedIndexChanged += new System.EventHandler(this.pokazInformacjeOPoczytnosci);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "pokaz informacje o poczytności";
            // 
            // textBox_limit
            // 
            this.textBox_limit.Location = new System.Drawing.Point(238, 91);
            this.textBox_limit.Name = "textBox_limit";
            this.textBox_limit.Size = new System.Drawing.Size(100, 20);
            this.textBox_limit.TabIndex = 57;
            this.textBox_limit.TextChanged += new System.EventHandler(this.textBox_limit_TextChanged);
            // 
            // label_limit
            // 
            this.label_limit.AutoSize = true;
            this.label_limit.Location = new System.Drawing.Point(164, 95);
            this.label_limit.Name = "label_limit";
            this.label_limit.Size = new System.Drawing.Size(24, 13);
            this.label_limit.TabIndex = 56;
            this.label_limit.Text = "limit";
            this.label_limit.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_kategoria
            // 
            this.label_kategoria.AutoSize = true;
            this.label_kategoria.Location = new System.Drawing.Point(164, 68);
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
            this.comboBox_kategoria.Location = new System.Drawing.Point(238, 65);
            this.comboBox_kategoria.Name = "comboBox_kategoria";
            this.comboBox_kategoria.Size = new System.Drawing.Size(100, 21);
            this.comboBox_kategoria.TabIndex = 58;
            this.comboBox_kategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox_kategoria_SelectedIndexChanged);
            // 
            // textBox_maxCzasWypozyczenia
            // 
            this.textBox_maxCzasWypozyczenia.Location = new System.Drawing.Point(238, 140);
            this.textBox_maxCzasWypozyczenia.Name = "textBox_maxCzasWypozyczenia";
            this.textBox_maxCzasWypozyczenia.Size = new System.Drawing.Size(100, 20);
            this.textBox_maxCzasWypozyczenia.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "max czas";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // textBox_stanowisko
            // 
            this.textBox_stanowisko.Location = new System.Drawing.Point(410, 40);
            this.textBox_stanowisko.Name = "textBox_stanowisko";
            this.textBox_stanowisko.Size = new System.Drawing.Size(100, 20);
            this.textBox_stanowisko.TabIndex = 63;
            // 
            // label_stanowisko
            // 
            this.label_stanowisko.AutoSize = true;
            this.label_stanowisko.Location = new System.Drawing.Point(344, 45);
            this.label_stanowisko.Name = "label_stanowisko";
            this.label_stanowisko.Size = new System.Drawing.Size(60, 13);
            this.label_stanowisko.TabIndex = 62;
            this.label_stanowisko.Text = "stanowisko";
            // 
            // button_pokazPracownikow
            // 
            this.button_pokazPracownikow.Location = new System.Drawing.Point(8, 233);
            this.button_pokazPracownikow.Name = "button_pokazPracownikow";
            this.button_pokazPracownikow.Size = new System.Drawing.Size(113, 23);
            this.button_pokazPracownikow.TabIndex = 64;
            this.button_pokazPracownikow.Text = "pokaz pracowników";
            this.button_pokazPracownikow.UseVisualStyleBackColor = true;
            this.button_pokazPracownikow.Click += new System.EventHandler(this.pokazPracownikow);
            // 
            // textBox_iloscMinut
            // 
            this.textBox_iloscMinut.Location = new System.Drawing.Point(465, 45);
            this.textBox_iloscMinut.Name = "textBox_iloscMinut";
            this.textBox_iloscMinut.Size = new System.Drawing.Size(100, 20);
            this.textBox_iloscMinut.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "ilosc minut";
            // 
            // textBox_ktoCzyta
            // 
            this.textBox_ktoCzyta.Location = new System.Drawing.Point(465, 71);
            this.textBox_ktoCzyta.Name = "textBox_ktoCzyta";
            this.textBox_ktoCzyta.Size = new System.Drawing.Size(100, 20);
            this.textBox_ktoCzyta.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "kto czyta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "kategoria";
            // 
            // comboBox_kategoriaEgzemplarza
            // 
            this.comboBox_kategoriaEgzemplarza.FormattingEnabled = true;
            this.comboBox_kategoriaEgzemplarza.Items.AddRange(new object[] {
            "książka",
            "audiobook"});
            this.comboBox_kategoriaEgzemplarza.Location = new System.Drawing.Point(109, 14);
            this.comboBox_kategoriaEgzemplarza.Name = "comboBox_kategoriaEgzemplarza";
            this.comboBox_kategoriaEgzemplarza.Size = new System.Drawing.Size(100, 21);
            this.comboBox_kategoriaEgzemplarza.TabIndex = 69;
            // 
            // button_przejscieDoSekcjiCzytelnika
            // 
            this.button_przejscieDoSekcjiCzytelnika.Location = new System.Drawing.Point(877, 0);
            this.button_przejscieDoSekcjiCzytelnika.Name = "button_przejscieDoSekcjiCzytelnika";
            this.button_przejscieDoSekcjiCzytelnika.Size = new System.Drawing.Size(124, 36);
            this.button_przejscieDoSekcjiCzytelnika.TabIndex = 71;
            this.button_przejscieDoSekcjiCzytelnika.Text = "przejscie do sekcji czytelnika";
            this.button_przejscieDoSekcjiCzytelnika.UseVisualStyleBackColor = true;
            this.button_przejscieDoSekcjiCzytelnika.Click += new System.EventHandler(this.button_przejscieDoSekcjiCzytelnika_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button1_dodajKsiazke);
            this.groupBox1.Controls.Add(this.comboBox_kategoriaEgzemplarza);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2_tytul);
            this.groupBox1.Controls.Add(this.textTytul);
            this.groupBox1.Controls.Add(this.textBox_ktoCzyta);
            this.groupBox1.Controls.Add(this.label4_rodzaj);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label5_licznikWypozyczen);
            this.groupBox1.Controls.Add(this.textBox_iloscMinut);
            this.groupBox1.Controls.Add(this.textLicznikWyp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6_licznikPrzedluzen);
            this.groupBox1.Controls.Add(this.textLicznikPrzed);
            this.groupBox1.Controls.Add(this.label7_iloscStron);
            this.groupBox1.Controls.Add(this.textIloscStron);
            this.groupBox1.Controls.Add(this.label8_imieAutora);
            this.groupBox1.Controls.Add(this.textImieAutora);
            this.groupBox1.Controls.Add(this.label9_nazwiskoAutora);
            this.groupBox1.Controls.Add(this.textNazwiskoAutora);
            this.groupBox1.Controls.Add(this.label10_nrISBN);
            this.groupBox1.Controls.Add(this.textISBN);
            this.groupBox1.Controls.Add(this.comboBox_rodzajeKsiazke);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_stan);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 175);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BAZA EGZEMPLARZY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "wypozyczenia";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.textEMail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label_Imie);
            this.groupBox2.Controls.Add(this.text_ImieUsera);
            this.groupBox2.Controls.Add(this.label_NazwiskoUsera);
            this.groupBox2.Controls.Add(this.text_nazwiskoUsera);
            this.groupBox2.Controls.Add(this.textBox_stanowisko);
            this.groupBox2.Controls.Add(this.label_IdUsera);
            this.groupBox2.Controls.Add(this.label_stanowisko);
            this.groupBox2.Controls.Add(this.text_IdUsera);
            this.groupBox2.Controls.Add(this.textBox_maxCzasWypozyczenia);
            this.groupBox2.Controls.Add(this.label_pesel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textPesel);
            this.groupBox2.Controls.Add(this.label_kategoria);
            this.groupBox2.Controls.Add(this.label_emial);
            this.groupBox2.Controls.Add(this.comboBox_kategoria);
            this.groupBox2.Controls.Add(this.label4_haslo);
            this.groupBox2.Controls.Add(this.textBox_limit);
            this.groupBox2.Controls.Add(this.text_haslo);
            this.groupBox2.Controls.Add(this.label_limit);
            this.groupBox2.Controls.Add(this.button_dodajUsera);
            this.groupBox2.Location = new System.Drawing.Point(592, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 175);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BAZA UŻYTKOWNIKÓW";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "wypełnij dla książki";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(462, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 72;
            this.label9.Text = "wypełnij dla audio";
            // 
            // Form2_PanelPracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_przejscieDoSekcjiCzytelnika);
            this.Controls.Add(this.button_pokazPracownikow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_sortowanieNaj);
            this.Controls.Add(this.button_pokazWypozyczenia);
            this.Controls.Add(this.button_usunKsiazkezTabeli);
            this.Controls.Add(this.button_pokazKsiazkiTabela);
            this.Controls.Add(this.dataGridView_ksiazkiTabela);
            this.Controls.Add(this.button_usunUserazTabeli);
            this.Controls.Add(this.button_pokazCzytelnikow);
            this.Controls.Add(this.dataGridViewPokazUserow);
            this.Controls.Add(this.listBox_ksiazkiPracownik);
            this.Controls.Add(this.button1_powrotDoGlownego);
            this.Name = "Form2_PanelPracownika";
            this.Text = "Form2_PanelPracownika";
            this.Load += new System.EventHandler(this.Form2_PanelPracownika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokazUserow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ksiazkiTabela)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_powrotDoGlownego;
        private System.Windows.Forms.Button button1_dodajKsiazke;
        private System.Windows.Forms.TextBox textTytul;
        private System.Windows.Forms.Label label2_tytul;
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
        private System.Windows.Forms.TextBox textBox_iloscMinut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ktoCzyta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_kategoriaEgzemplarza;
        private System.Windows.Forms.Button button_przejscieDoSekcjiCzytelnika;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}