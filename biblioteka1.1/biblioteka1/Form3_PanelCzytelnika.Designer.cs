namespace biblioteka1
{
    partial class Form3_PanelCzytelnika
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
            this.components = new System.ComponentModel.Container();
            this.button1_powrotDoGlownego = new System.Windows.Forms.Button();
            this.compositeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_ksiazki = new System.Windows.Forms.DataGridView();
            this.button_pokazKsiazkiTabela = new System.Windows.Forms.Button();
            this.button_Wyszukaj = new System.Windows.Forms.Button();
            this.textBox_imieAutora = new System.Windows.Forms.TextBox();
            this.textBox_nazwiskoAutora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_tytul = new System.Windows.Forms.TextBox();
            this.textBox_nrISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Wypozycz = new System.Windows.Forms.Button();
            this.button_dodajDoUlubionych = new System.Windows.Forms.Button();
            this.button_zwroc = new System.Windows.Forms.Button();
            this.button_przegladajkatalogWlasny = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7_witajUserName = new System.Windows.Forms.Label();
            this.label7_witaJUser = new System.Windows.Forms.Label();
            this.dataGridView_katalogUsera = new System.Windows.Forms.DataGridView();
            this.button_pokazAktualneWypUsera = new System.Windows.Forms.Button();
            this.button_pokazArchiwalneWypUsera = new System.Windows.Forms.Button();
            this.textBox_witajUser = new System.Windows.Forms.TextBox();
            this.button1_pokazDaneWybranejKs = new System.Windows.Forms.Button();
            this.dataGridView_wybrana = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.button_przedłuż = new System.Windows.Forms.Button();
            this.button_pokazZarezerwowane = new System.Windows.Forms.Button();
            this.button_ZarezerwujKsiazke = new System.Windows.Forms.Button();
            this.button_pozycjeNaRezerwacji = new System.Windows.Forms.Button();
            this.textBox_nrWKolejce = new System.Windows.Forms.TextBox();
            this.button_usunRezerwacje = new System.Windows.Forms.Button();
            this.label_limit = new System.Windows.Forms.Label();
            this.textBox_limit = new System.Windows.Forms.TextBox();
            this.label_czasWypozyczenia = new System.Windows.Forms.Label();
            this.textBox_czasWypozyczenia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.compositeTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ksiazki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_katalogUsera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_wybrana)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1_powrotDoGlownego
            // 
            this.button1_powrotDoGlownego.Location = new System.Drawing.Point(1054, 2);
            this.button1_powrotDoGlownego.Name = "button1_powrotDoGlownego";
            this.button1_powrotDoGlownego.Size = new System.Drawing.Size(104, 36);
            this.button1_powrotDoGlownego.TabIndex = 0;
            this.button1_powrotDoGlownego.Text = "powrót do ekranu głównego";
            this.button1_powrotDoGlownego.UseVisualStyleBackColor = true;
            this.button1_powrotDoGlownego.Click += new System.EventHandler(this.button1_powrotDoGlownego_Click);
            // 
            // compositeTypeBindingSource
            // 
            this.compositeTypeBindingSource.CurrentChanged += new System.EventHandler(this.compositeTypeBindingSource_CurrentChanged);
            // 
            // dataGridView_ksiazki
            // 
            this.dataGridView_ksiazki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ksiazki.Location = new System.Drawing.Point(208, 13);
            this.dataGridView_ksiazki.Name = "dataGridView_ksiazki";
            this.dataGridView_ksiazki.Size = new System.Drawing.Size(903, 249);
            this.dataGridView_ksiazki.TabIndex = 3;
            this.dataGridView_ksiazki.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ksiazki_CellContentClick);
            // 
            // button_pokazKsiazkiTabela
            // 
            this.button_pokazKsiazkiTabela.Location = new System.Drawing.Point(6, 181);
            this.button_pokazKsiazkiTabela.Name = "button_pokazKsiazkiTabela";
            this.button_pokazKsiazkiTabela.Size = new System.Drawing.Size(196, 23);
            this.button_pokazKsiazkiTabela.TabIndex = 4;
            this.button_pokazKsiazkiTabela.Text = "pokaż wszystkie";
            this.button_pokazKsiazkiTabela.UseVisualStyleBackColor = true;
            this.button_pokazKsiazkiTabela.Click += new System.EventHandler(this.pokazWszytskieKsiazki);
            // 
            // button_Wyszukaj
            // 
            this.button_Wyszukaj.Location = new System.Drawing.Point(6, 123);
            this.button_Wyszukaj.Name = "button_Wyszukaj";
            this.button_Wyszukaj.Size = new System.Drawing.Size(196, 23);
            this.button_Wyszukaj.TabIndex = 5;
            this.button_Wyszukaj.Text = "wyszukaj";
            this.button_Wyszukaj.UseVisualStyleBackColor = true;
            this.button_Wyszukaj.Click += new System.EventHandler(this.wyszukajEgzemplarz);
            // 
            // textBox_imieAutora
            // 
            this.textBox_imieAutora.Location = new System.Drawing.Point(102, 19);
            this.textBox_imieAutora.Name = "textBox_imieAutora";
            this.textBox_imieAutora.Size = new System.Drawing.Size(100, 20);
            this.textBox_imieAutora.TabIndex = 6;
            this.textBox_imieAutora.TextChanged += new System.EventHandler(this.textBox_imieAutora_TextChanged);
            // 
            // textBox_nazwiskoAutora
            // 
            this.textBox_nazwiskoAutora.Location = new System.Drawing.Point(102, 45);
            this.textBox_nazwiskoAutora.Name = "textBox_nazwiskoAutora";
            this.textBox_nazwiskoAutora.Size = new System.Drawing.Size(100, 20);
            this.textBox_nazwiskoAutora.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "imie autora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "nazwisko autora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "tytul";
            // 
            // textBox_tytul
            // 
            this.textBox_tytul.Location = new System.Drawing.Point(102, 71);
            this.textBox_tytul.Name = "textBox_tytul";
            this.textBox_tytul.Size = new System.Drawing.Size(100, 20);
            this.textBox_tytul.TabIndex = 11;
            // 
            // textBox_nrISBN
            // 
            this.textBox_nrISBN.Location = new System.Drawing.Point(102, 97);
            this.textBox_nrISBN.Name = "textBox_nrISBN";
            this.textBox_nrISBN.Size = new System.Drawing.Size(100, 20);
            this.textBox_nrISBN.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "nrISBN";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button_Wypozycz
            // 
            this.button_Wypozycz.Location = new System.Drawing.Point(6, 152);
            this.button_Wypozycz.Name = "button_Wypozycz";
            this.button_Wypozycz.Size = new System.Drawing.Size(196, 23);
            this.button_Wypozycz.TabIndex = 15;
            this.button_Wypozycz.Text = "wypozycz";
            this.button_Wypozycz.UseVisualStyleBackColor = true;
            this.button_Wypozycz.Click += new System.EventHandler(this.wypozycEgzemplarz);
            // 
            // button_dodajDoUlubionych
            // 
            this.button_dodajDoUlubionych.Location = new System.Drawing.Point(6, 239);
            this.button_dodajDoUlubionych.Name = "button_dodajDoUlubionych";
            this.button_dodajDoUlubionych.Size = new System.Drawing.Size(196, 23);
            this.button_dodajDoUlubionych.TabIndex = 16;
            this.button_dodajDoUlubionych.Text = "TODO dodaj do ulubionych";
            this.button_dodajDoUlubionych.UseVisualStyleBackColor = true;
            this.button_dodajDoUlubionych.Click += new System.EventHandler(this.dodajDoUlubionych);
            // 
            // button_zwroc
            // 
            this.button_zwroc.Location = new System.Drawing.Point(208, 19);
            this.button_zwroc.Name = "button_zwroc";
            this.button_zwroc.Size = new System.Drawing.Size(196, 23);
            this.button_zwroc.TabIndex = 17;
            this.button_zwroc.Text = "zwróc wybraną ksiązke";
            this.button_zwroc.UseVisualStyleBackColor = true;
            this.button_zwroc.Click += new System.EventHandler(this.zwrocWybranaKsiazke);
            // 
            // button_przegladajkatalogWlasny
            // 
            this.button_przegladajkatalogWlasny.Location = new System.Drawing.Point(6, 18);
            this.button_przegladajkatalogWlasny.Name = "button_przegladajkatalogWlasny";
            this.button_przegladajkatalogWlasny.Size = new System.Drawing.Size(196, 23);
            this.button_przegladajkatalogWlasny.TabIndex = 18;
            this.button_przegladajkatalogWlasny.Text = "przeglądaj katalog własny";
            this.button_przegladajkatalogWlasny.UseVisualStyleBackColor = true;
            this.button_przegladajkatalogWlasny.Click += new System.EventHandler(this.przegladajKatalogWlasny);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 22;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(35, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Witaj";
            // 
            // label7_witajUserName
            // 
            this.label7_witajUserName.AutoSize = true;
            this.label7_witajUserName.Location = new System.Drawing.Point(76, 9);
            this.label7_witajUserName.Name = "label7_witajUserName";
            this.label7_witajUserName.Size = new System.Drawing.Size(0, 13);
            this.label7_witajUserName.TabIndex = 24;
            this.label7_witajUserName.Click += new System.EventHandler(this.label7_witajUserName_Click);
            // 
            // label7_witaJUser
            // 
            this.label7_witaJUser.AutoSize = true;
            this.label7_witaJUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7_witaJUser.Location = new System.Drawing.Point(107, 9);
            this.label7_witaJUser.Name = "label7_witaJUser";
            this.label7_witaJUser.Size = new System.Drawing.Size(0, 24);
            this.label7_witaJUser.TabIndex = 25;
            // 
            // dataGridView_katalogUsera
            // 
            this.dataGridView_katalogUsera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_katalogUsera.Location = new System.Drawing.Point(441, 13);
            this.dataGridView_katalogUsera.Name = "dataGridView_katalogUsera";
            this.dataGridView_katalogUsera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_katalogUsera.Size = new System.Drawing.Size(670, 182);
            this.dataGridView_katalogUsera.TabIndex = 26;
            this.dataGridView_katalogUsera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_katalogUsera_CellContentClick);
            // 
            // button_pokazAktualneWypUsera
            // 
            this.button_pokazAktualneWypUsera.Location = new System.Drawing.Point(6, 47);
            this.button_pokazAktualneWypUsera.Name = "button_pokazAktualneWypUsera";
            this.button_pokazAktualneWypUsera.Size = new System.Drawing.Size(196, 23);
            this.button_pokazAktualneWypUsera.TabIndex = 27;
            this.button_pokazAktualneWypUsera.Text = "pokaz moje aktualne wypozyczenia";
            this.button_pokazAktualneWypUsera.UseVisualStyleBackColor = true;
            this.button_pokazAktualneWypUsera.Click += new System.EventHandler(this.pokazAktualneWypozyczeniaCzytelnika);
            // 
            // button_pokazArchiwalneWypUsera
            // 
            this.button_pokazArchiwalneWypUsera.Location = new System.Drawing.Point(6, 76);
            this.button_pokazArchiwalneWypUsera.Name = "button_pokazArchiwalneWypUsera";
            this.button_pokazArchiwalneWypUsera.Size = new System.Drawing.Size(196, 23);
            this.button_pokazArchiwalneWypUsera.TabIndex = 28;
            this.button_pokazArchiwalneWypUsera.Text = "pokaz moje archiwalne wypozyczenia";
            this.button_pokazArchiwalneWypUsera.UseVisualStyleBackColor = true;
            this.button_pokazArchiwalneWypUsera.Click += new System.EventHandler(this.pokazArchiwalneWypozyczeniaCzytelnika);
            // 
            // textBox_witajUser
            // 
            this.textBox_witajUser.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_witajUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_witajUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_witajUser.Location = new System.Drawing.Point(91, 6);
            this.textBox_witajUser.Name = "textBox_witajUser";
            this.textBox_witajUser.ReadOnly = true;
            this.textBox_witajUser.Size = new System.Drawing.Size(124, 22);
            this.textBox_witajUser.TabIndex = 29;
            this.textBox_witajUser.TextChanged += new System.EventHandler(this.textBox_witajUser_TextChanged);
            // 
            // button1_pokazDaneWybranejKs
            // 
            this.button1_pokazDaneWybranejKs.Location = new System.Drawing.Point(208, 77);
            this.button1_pokazDaneWybranejKs.Name = "button1_pokazDaneWybranejKs";
            this.button1_pokazDaneWybranejKs.Size = new System.Drawing.Size(196, 23);
            this.button1_pokazDaneWybranejKs.TabIndex = 30;
            this.button1_pokazDaneWybranejKs.Text = "pokaz dane wybranej pozycji";
            this.button1_pokazDaneWybranejKs.UseVisualStyleBackColor = true;
            this.button1_pokazDaneWybranejKs.Click += new System.EventHandler(this.pokazDaneWybranejPozycji);
            // 
            // dataGridView_wybrana
            // 
            this.dataGridView_wybrana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_wybrana.Location = new System.Drawing.Point(6, 201);
            this.dataGridView_wybrana.Name = "dataGridView_wybrana";
            this.dataGridView_wybrana.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_wybrana.Size = new System.Drawing.Size(1105, 63);
            this.dataGridView_wybrana.TabIndex = 31;
            this.dataGridView_wybrana.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_wybrana_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "jesli nie ma tz ksiazka została wycofana";
            // 
            // button_przedłuż
            // 
            this.button_przedłuż.Location = new System.Drawing.Point(208, 48);
            this.button_przedłuż.Name = "button_przedłuż";
            this.button_przedłuż.Size = new System.Drawing.Size(196, 23);
            this.button_przedłuż.TabIndex = 33;
            this.button_przedłuż.Text = "przedłuż wybraną ksiązke";
            this.button_przedłuż.UseVisualStyleBackColor = true;
            this.button_przedłuż.Click += new System.EventHandler(this.przedluzWybranaKsiazke);
            // 
            // button_pokazZarezerwowane
            // 
            this.button_pokazZarezerwowane.Location = new System.Drawing.Point(6, 143);
            this.button_pokazZarezerwowane.Name = "button_pokazZarezerwowane";
            this.button_pokazZarezerwowane.Size = new System.Drawing.Size(196, 23);
            this.button_pokazZarezerwowane.TabIndex = 34;
            this.button_pokazZarezerwowane.Text = "pokaz moje zarezerwowane ksiązki";
            this.button_pokazZarezerwowane.UseVisualStyleBackColor = true;
            this.button_pokazZarezerwowane.Click += new System.EventHandler(this.pokazZarezerwowaneKsiazkiUzytkownika);
            // 
            // button_ZarezerwujKsiazke
            // 
            this.button_ZarezerwujKsiazke.Location = new System.Drawing.Point(6, 210);
            this.button_ZarezerwujKsiazke.Name = "button_ZarezerwujKsiazke";
            this.button_ZarezerwujKsiazke.Size = new System.Drawing.Size(196, 23);
            this.button_ZarezerwujKsiazke.TabIndex = 35;
            this.button_ZarezerwujKsiazke.Text = "zarezerwuj";
            this.button_ZarezerwujKsiazke.UseVisualStyleBackColor = true;
            this.button_ZarezerwujKsiazke.Click += new System.EventHandler(this.zarezerwujEgzemplarz);
            // 
            // button_pozycjeNaRezerwacji
            // 
            this.button_pozycjeNaRezerwacji.Location = new System.Drawing.Point(208, 143);
            this.button_pozycjeNaRezerwacji.Name = "button_pozycjeNaRezerwacji";
            this.button_pozycjeNaRezerwacji.Size = new System.Drawing.Size(196, 23);
            this.button_pozycjeNaRezerwacji.TabIndex = 36;
            this.button_pozycjeNaRezerwacji.Text = " pokaz moj nr w kolejce";
            this.button_pozycjeNaRezerwacji.UseVisualStyleBackColor = true;
            this.button_pozycjeNaRezerwacji.Click += new System.EventHandler(this.pokazNumerCzytelnikaWKolejceRezerwacji);
            // 
            // textBox_nrWKolejce
            // 
            this.textBox_nrWKolejce.Location = new System.Drawing.Point(410, 143);
            this.textBox_nrWKolejce.Name = "textBox_nrWKolejce";
            this.textBox_nrWKolejce.Size = new System.Drawing.Size(25, 20);
            this.textBox_nrWKolejce.TabIndex = 37;
            // 
            // button_usunRezerwacje
            // 
            this.button_usunRezerwacje.Location = new System.Drawing.Point(6, 172);
            this.button_usunRezerwacje.Name = "button_usunRezerwacje";
            this.button_usunRezerwacje.Size = new System.Drawing.Size(196, 23);
            this.button_usunRezerwacje.TabIndex = 38;
            this.button_usunRezerwacje.Text = "usun rezerwacje";
            this.button_usunRezerwacje.UseVisualStyleBackColor = true;
            this.button_usunRezerwacje.Click += new System.EventHandler(this.usunRezerwacje);
            // 
            // label_limit
            // 
            this.label_limit.AutoSize = true;
            this.label_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_limit.Location = new System.Drawing.Point(221, 6);
            this.label_limit.Name = "label_limit";
            this.label_limit.Size = new System.Drawing.Size(159, 24);
            this.label_limit.TabIndex = 42;
            this.label_limit.Text = "limit egzemplarzy:";
            this.label_limit.Click += new System.EventHandler(this.label_limit_Click);
            // 
            // textBox_limit
            // 
            this.textBox_limit.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_limit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_limit.Location = new System.Drawing.Point(386, 6);
            this.textBox_limit.Name = "textBox_limit";
            this.textBox_limit.ReadOnly = true;
            this.textBox_limit.Size = new System.Drawing.Size(50, 22);
            this.textBox_limit.TabIndex = 43;
            this.textBox_limit.TextChanged += new System.EventHandler(this.textBox_limit_TextChanged);
            // 
            // label_czasWypozyczenia
            // 
            this.label_czasWypozyczenia.AutoSize = true;
            this.label_czasWypozyczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_czasWypozyczenia.Location = new System.Drawing.Point(474, 6);
            this.label_czasWypozyczenia.Name = "label_czasWypozyczenia";
            this.label_czasWypozyczenia.Size = new System.Drawing.Size(176, 24);
            this.label_czasWypozyczenia.TabIndex = 44;
            this.label_czasWypozyczenia.Text = "czas wypozyczenia:";
            // 
            // textBox_czasWypozyczenia
            // 
            this.textBox_czasWypozyczenia.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_czasWypozyczenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_czasWypozyczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_czasWypozyczenia.Location = new System.Drawing.Point(656, 6);
            this.textBox_czasWypozyczenia.Name = "textBox_czasWypozyczenia";
            this.textBox_czasWypozyczenia.ReadOnly = true;
            this.textBox_czasWypozyczenia.Size = new System.Drawing.Size(38, 22);
            this.textBox_czasWypozyczenia.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dataGridView_katalogUsera);
            this.groupBox1.Controls.Add(this.button_zwroc);
            this.groupBox1.Controls.Add(this.button_przegladajkatalogWlasny);
            this.groupBox1.Controls.Add(this.button_pokazAktualneWypUsera);
            this.groupBox1.Controls.Add(this.button_pokazArchiwalneWypUsera);
            this.groupBox1.Controls.Add(this.button_usunRezerwacje);
            this.groupBox1.Controls.Add(this.textBox_nrWKolejce);
            this.groupBox1.Controls.Add(this.button1_pokazDaneWybranejKs);
            this.groupBox1.Controls.Add(this.button_pozycjeNaRezerwacji);
            this.groupBox1.Controls.Add(this.dataGridView_wybrana);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button_przedłuż);
            this.groupBox1.Controls.Add(this.button_pokazZarezerwowane);
            this.groupBox1.Location = new System.Drawing.Point(32, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1117, 270);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MOJE KONTO";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.groupBox2.Controls.Add(this.dataGridView_ksiazki);
            this.groupBox2.Controls.Add(this.button_pokazKsiazkiTabela);
            this.groupBox2.Controls.Add(this.button_Wyszukaj);
            this.groupBox2.Controls.Add(this.textBox_imieAutora);
            this.groupBox2.Controls.Add(this.textBox_nazwiskoAutora);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button_ZarezerwujKsiazke);
            this.groupBox2.Controls.Add(this.textBox_tytul);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_nrISBN);
            this.groupBox2.Controls.Add(this.button_Wypozycz);
            this.groupBox2.Controls.Add(this.button_dodajDoUlubionych);
            this.groupBox2.Location = new System.Drawing.Point(32, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1117, 273);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BAZA BIBLIOTECZNA";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Form3_PanelCzytelnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_czasWypozyczenia);
            this.Controls.Add(this.label_czasWypozyczenia);
            this.Controls.Add(this.textBox_limit);
            this.Controls.Add(this.label_limit);
            this.Controls.Add(this.textBox_witajUser);
            this.Controls.Add(this.label7_witaJUser);
            this.Controls.Add(this.label7_witajUserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1_powrotDoGlownego);
            this.Name = "Form3_PanelCzytelnika";
            this.Text = "Form3_PanelCzytelnika";
            this.Load += new System.EventHandler(this.Form3_PanelCzytelnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compositeTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ksiazki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_katalogUsera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_wybrana)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_powrotDoGlownego;
        private System.Windows.Forms.BindingSource compositeTypeBindingSource;
        private System.Windows.Forms.DataGridView dataGridView_ksiazki;
        private System.Windows.Forms.Button button_pokazKsiazkiTabela;
        private System.Windows.Forms.Button button_Wyszukaj;
        private System.Windows.Forms.TextBox textBox_imieAutora;
        private System.Windows.Forms.TextBox textBox_nazwiskoAutora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_tytul;
        private System.Windows.Forms.TextBox textBox_nrISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Wypozycz;
        private System.Windows.Forms.Button button_dodajDoUlubionych;
        private System.Windows.Forms.Button button_zwroc;
        private System.Windows.Forms.Button button_przegladajkatalogWlasny;
       // private System.Windows.Forms.Button button_zarezerwuj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7_witajUserName;
        private System.Windows.Forms.Label label7_witaJUser;
        private System.Windows.Forms.DataGridView dataGridView_katalogUsera;
        private System.Windows.Forms.Button button_pokazAktualneWypUsera;
        private System.Windows.Forms.Button button_pokazArchiwalneWypUsera;
        private System.Windows.Forms.TextBox textBox_witajUser;
        private System.Windows.Forms.Button button1_pokazDaneWybranejKs;
        private System.Windows.Forms.DataGridView dataGridView_wybrana;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_przedłuż;
        private System.Windows.Forms.Button button_pokazZarezerwowane;
        private System.Windows.Forms.Button button_ZarezerwujKsiazke;
        private System.Windows.Forms.Button button_pozycjeNaRezerwacji;
        private System.Windows.Forms.TextBox textBox_nrWKolejce;
        private System.Windows.Forms.Button button_usunRezerwacje;
        private System.Windows.Forms.Label label_limit;
        private System.Windows.Forms.TextBox textBox_limit;
        private System.Windows.Forms.Label label_czasWypozyczenia;
        private System.Windows.Forms.TextBox textBox_czasWypozyczenia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}