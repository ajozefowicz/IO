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
            this.button_pokazKsiazki = new System.Windows.Forms.Button();
            this.listBoxKsiazki = new System.Windows.Forms.ListBox();
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
            this.button_zarezerwuj = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.compositeTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ksiazki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_katalogUsera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_wybrana)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_powrotDoGlownego
            // 
            this.button1_powrotDoGlownego.Location = new System.Drawing.Point(863, 14);
            this.button1_powrotDoGlownego.Name = "button1_powrotDoGlownego";
            this.button1_powrotDoGlownego.Size = new System.Drawing.Size(104, 48);
            this.button1_powrotDoGlownego.TabIndex = 0;
            this.button1_powrotDoGlownego.Text = "powrót do ekranu głównego";
            this.button1_powrotDoGlownego.UseVisualStyleBackColor = true;
            this.button1_powrotDoGlownego.Click += new System.EventHandler(this.button1_powrotDoGlownego_Click);
            // 
            // button_pokazKsiazki
            // 
            this.button_pokazKsiazki.Location = new System.Drawing.Point(707, 14);
            this.button_pokazKsiazki.Name = "button_pokazKsiazki";
            this.button_pokazKsiazki.Size = new System.Drawing.Size(153, 23);
            this.button_pokazKsiazki.TabIndex = 1;
            this.button_pokazKsiazki.Text = "pokaz wszystkie (lista stringow)";
            this.button_pokazKsiazki.UseVisualStyleBackColor = true;
            this.button_pokazKsiazki.Click += new System.EventHandler(this.button_pokazKsiazki_Click);
            // 
            // listBoxKsiazki
            // 
            this.listBoxKsiazki.FormattingEnabled = true;
            this.listBoxKsiazki.Location = new System.Drawing.Point(564, 14);
            this.listBoxKsiazki.Name = "listBoxKsiazki";
            this.listBoxKsiazki.Size = new System.Drawing.Size(137, 69);
            this.listBoxKsiazki.TabIndex = 2;
            // 
            // compositeTypeBindingSource
            // 
            this.compositeTypeBindingSource.DataSource = typeof(biblioteka1.ServiceReference4.CompositeType);
            // 
            // dataGridView_ksiazki
            // 
            this.dataGridView_ksiazki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ksiazki.Location = new System.Drawing.Point(234, 211);
            this.dataGridView_ksiazki.Name = "dataGridView_ksiazki";
            this.dataGridView_ksiazki.Size = new System.Drawing.Size(680, 235);
            this.dataGridView_ksiazki.TabIndex = 3;
            // 
            // button_pokazKsiazkiTabela
            // 
            this.button_pokazKsiazkiTabela.Location = new System.Drawing.Point(65, 367);
            this.button_pokazKsiazkiTabela.Name = "button_pokazKsiazkiTabela";
            this.button_pokazKsiazkiTabela.Size = new System.Drawing.Size(153, 23);
            this.button_pokazKsiazkiTabela.TabIndex = 4;
            this.button_pokazKsiazkiTabela.Text = "pokaz wszytskie tabela";
            this.button_pokazKsiazkiTabela.UseVisualStyleBackColor = true;
            this.button_pokazKsiazkiTabela.Click += new System.EventHandler(this.button_pokazKsiazkiTabela_Click);
            // 
            // button_Wyszukaj
            // 
            this.button_Wyszukaj.Location = new System.Drawing.Point(143, 309);
            this.button_Wyszukaj.Name = "button_Wyszukaj";
            this.button_Wyszukaj.Size = new System.Drawing.Size(75, 23);
            this.button_Wyszukaj.TabIndex = 5;
            this.button_Wyszukaj.Text = "wyszukaj";
            this.button_Wyszukaj.UseVisualStyleBackColor = true;
            this.button_Wyszukaj.Click += new System.EventHandler(this.button_Wyszukaj_Click);
            // 
            // textBox_imieAutora
            // 
            this.textBox_imieAutora.Location = new System.Drawing.Point(128, 196);
            this.textBox_imieAutora.Name = "textBox_imieAutora";
            this.textBox_imieAutora.Size = new System.Drawing.Size(100, 20);
            this.textBox_imieAutora.TabIndex = 6;
            this.textBox_imieAutora.TextChanged += new System.EventHandler(this.textBox_imieAutora_TextChanged);
            // 
            // textBox_nazwiskoAutora
            // 
            this.textBox_nazwiskoAutora.Location = new System.Drawing.Point(128, 224);
            this.textBox_nazwiskoAutora.Name = "textBox_nazwiskoAutora";
            this.textBox_nazwiskoAutora.Size = new System.Drawing.Size(100, 20);
            this.textBox_nazwiskoAutora.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "imie autora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "nazwisko autora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "tytul";
            // 
            // textBox_tytul
            // 
            this.textBox_tytul.Location = new System.Drawing.Point(128, 257);
            this.textBox_tytul.Name = "textBox_tytul";
            this.textBox_tytul.Size = new System.Drawing.Size(100, 20);
            this.textBox_tytul.TabIndex = 11;
            // 
            // textBox_nrISBN
            // 
            this.textBox_nrISBN.Location = new System.Drawing.Point(128, 283);
            this.textBox_nrISBN.Name = "textBox_nrISBN";
            this.textBox_nrISBN.Size = new System.Drawing.Size(100, 20);
            this.textBox_nrISBN.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "nrISBN";
            // 
            // button_Wypozycz
            // 
            this.button_Wypozycz.Location = new System.Drawing.Point(143, 338);
            this.button_Wypozycz.Name = "button_Wypozycz";
            this.button_Wypozycz.Size = new System.Drawing.Size(75, 23);
            this.button_Wypozycz.TabIndex = 15;
            this.button_Wypozycz.Text = "wypozycz";
            this.button_Wypozycz.UseVisualStyleBackColor = true;
            this.button_Wypozycz.Click += new System.EventHandler(this.button_Wypozycz_Click);
            // 
            // button_dodajDoUlubionych
            // 
            this.button_dodajDoUlubionych.Location = new System.Drawing.Point(22, 396);
            this.button_dodajDoUlubionych.Name = "button_dodajDoUlubionych";
            this.button_dodajDoUlubionych.Size = new System.Drawing.Size(196, 23);
            this.button_dodajDoUlubionych.TabIndex = 16;
            this.button_dodajDoUlubionych.Text = "TODO dodaj do ulubionych";
            this.button_dodajDoUlubionych.UseVisualStyleBackColor = true;
            this.button_dodajDoUlubionych.Click += new System.EventHandler(this.button_dodajDoUlubionych_Click);
            // 
            // button_zwroc
            // 
            this.button_zwroc.Location = new System.Drawing.Point(32, 114);
            this.button_zwroc.Name = "button_zwroc";
            this.button_zwroc.Size = new System.Drawing.Size(196, 23);
            this.button_zwroc.TabIndex = 17;
            this.button_zwroc.Text = "zwróc wybraną ksiązke";
            this.button_zwroc.UseVisualStyleBackColor = true;
            this.button_zwroc.Click += new System.EventHandler(this.button_zwroc_Click);
            // 
            // button_przegladajkatalogWlasny
            // 
            this.button_przegladajkatalogWlasny.Location = new System.Drawing.Point(32, 27);
            this.button_przegladajkatalogWlasny.Name = "button_przegladajkatalogWlasny";
            this.button_przegladajkatalogWlasny.Size = new System.Drawing.Size(196, 23);
            this.button_przegladajkatalogWlasny.TabIndex = 18;
            this.button_przegladajkatalogWlasny.Text = "przeglądaj katalog własny";
            this.button_przegladajkatalogWlasny.UseVisualStyleBackColor = true;
            this.button_przegladajkatalogWlasny.Click += new System.EventHandler(this.button_przegladajkatalogWlasny_Click);
            // 
            // button_zarezerwuj
            // 
            this.button_zarezerwuj.Location = new System.Drawing.Point(12, 426);
            this.button_zarezerwuj.Name = "button_zarezerwuj";
            this.button_zarezerwuj.Size = new System.Drawing.Size(196, 23);
            this.button_zarezerwuj.TabIndex = 19;
            this.button_zarezerwuj.Text = "TODO zarezerwuj";
            this.button_zarezerwuj.UseVisualStyleBackColor = true;
            this.button_zarezerwuj.Click += new System.EventHandler(this.button1_Click_1);
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
            this.label6.Location = new System.Drawing.Point(37, 0);
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
            this.dataGridView_katalogUsera.Location = new System.Drawing.Point(234, 0);
            this.dataGridView_katalogUsera.Name = "dataGridView_katalogUsera";
            this.dataGridView_katalogUsera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_katalogUsera.Size = new System.Drawing.Size(301, 119);
            this.dataGridView_katalogUsera.TabIndex = 26;
            this.dataGridView_katalogUsera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_katalogUsera_CellContentClick);
            // 
            // button_pokazAktualneWypUsera
            // 
            this.button_pokazAktualneWypUsera.Location = new System.Drawing.Point(32, 56);
            this.button_pokazAktualneWypUsera.Name = "button_pokazAktualneWypUsera";
            this.button_pokazAktualneWypUsera.Size = new System.Drawing.Size(196, 23);
            this.button_pokazAktualneWypUsera.TabIndex = 27;
            this.button_pokazAktualneWypUsera.Text = "pokaz moje aktualne wypozyczenia";
            this.button_pokazAktualneWypUsera.UseVisualStyleBackColor = true;
            this.button_pokazAktualneWypUsera.Click += new System.EventHandler(this.button_pokazAktualneWypUsera_Click);
            // 
            // button_pokazArchiwalneWypUsera
            // 
            this.button_pokazArchiwalneWypUsera.Location = new System.Drawing.Point(32, 85);
            this.button_pokazArchiwalneWypUsera.Name = "button_pokazArchiwalneWypUsera";
            this.button_pokazArchiwalneWypUsera.Size = new System.Drawing.Size(196, 23);
            this.button_pokazArchiwalneWypUsera.TabIndex = 28;
            this.button_pokazArchiwalneWypUsera.Text = "pokaz moje archiwalne wypozyczenia";
            this.button_pokazArchiwalneWypUsera.UseVisualStyleBackColor = true;
            this.button_pokazArchiwalneWypUsera.Click += new System.EventHandler(this.button_pokazArchiwalneWypUsera_Click);
            // 
            // textBox_witajUser
            // 
            this.textBox_witajUser.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_witajUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_witajUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_witajUser.Location = new System.Drawing.Point(97, -2);
            this.textBox_witajUser.Name = "textBox_witajUser";
            this.textBox_witajUser.ReadOnly = true;
            this.textBox_witajUser.Size = new System.Drawing.Size(100, 22);
            this.textBox_witajUser.TabIndex = 29;
            // 
            // button1_pokazDaneWybranejKs
            // 
            this.button1_pokazDaneWybranejKs.Location = new System.Drawing.Point(32, 143);
            this.button1_pokazDaneWybranejKs.Name = "button1_pokazDaneWybranejKs";
            this.button1_pokazDaneWybranejKs.Size = new System.Drawing.Size(196, 23);
            this.button1_pokazDaneWybranejKs.TabIndex = 30;
            this.button1_pokazDaneWybranejKs.Text = "pokaz dane wybranej pozycji";
            this.button1_pokazDaneWybranejKs.UseVisualStyleBackColor = true;
            this.button1_pokazDaneWybranejKs.Click += new System.EventHandler(this.button1_pokazDaneWybranejKs_Click);
            // 
            // dataGridView_wybrana
            // 
            this.dataGridView_wybrana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_wybrana.Location = new System.Drawing.Point(234, 125);
            this.dataGridView_wybrana.Name = "dataGridView_wybrana";
            this.dataGridView_wybrana.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_wybrana.Size = new System.Drawing.Size(680, 80);
            this.dataGridView_wybrana.TabIndex = 31;
            this.dataGridView_wybrana.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_wybrana_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "jesli nie ma tz ksiazka została wycofana";
            // 
            // Form3_PanelCzytelnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView_wybrana);
            this.Controls.Add(this.button1_pokazDaneWybranejKs);
            this.Controls.Add(this.textBox_witajUser);
            this.Controls.Add(this.button_pokazArchiwalneWypUsera);
            this.Controls.Add(this.button_pokazAktualneWypUsera);
            this.Controls.Add(this.dataGridView_katalogUsera);
            this.Controls.Add(this.label7_witaJUser);
            this.Controls.Add(this.label7_witajUserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_zarezerwuj);
            this.Controls.Add(this.button_przegladajkatalogWlasny);
            this.Controls.Add(this.button_zwroc);
            this.Controls.Add(this.button_dodajDoUlubionych);
            this.Controls.Add(this.button_Wypozycz);
            this.Controls.Add(this.textBox_nrISBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_tytul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nazwiskoAutora);
            this.Controls.Add(this.textBox_imieAutora);
            this.Controls.Add(this.button_Wyszukaj);
            this.Controls.Add(this.button_pokazKsiazkiTabela);
            this.Controls.Add(this.dataGridView_ksiazki);
            this.Controls.Add(this.listBoxKsiazki);
            this.Controls.Add(this.button_pokazKsiazki);
            this.Controls.Add(this.button1_powrotDoGlownego);
            this.Name = "Form3_PanelCzytelnika";
            this.Text = "Form3_PanelCzytelnika";
            this.Load += new System.EventHandler(this.Form3_PanelCzytelnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compositeTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ksiazki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_katalogUsera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_wybrana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_powrotDoGlownego;
        private System.Windows.Forms.Button button_pokazKsiazki;
        private System.Windows.Forms.ListBox listBoxKsiazki;
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
        private System.Windows.Forms.Button button_zarezerwuj;
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
    }
}