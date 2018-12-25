namespace biblioteka1
{
    partial class Form1_Biblioteka
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1_Log_Pracownik = new System.Windows.Forms.Button();
            this.button2_Log_Czytelnik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_Log_Pracownik
            // 
            this.button1_Log_Pracownik.Location = new System.Drawing.Point(515, 129);
            this.button1_Log_Pracownik.Name = "button1_Log_Pracownik";
            this.button1_Log_Pracownik.Size = new System.Drawing.Size(118, 50);
            this.button1_Log_Pracownik.TabIndex = 0;
            this.button1_Log_Pracownik.Text = "Wejscie dla pracownika";
            this.button1_Log_Pracownik.UseVisualStyleBackColor = true;
            this.button1_Log_Pracownik.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2_Log_Czytelnik
            // 
            this.button2_Log_Czytelnik.Location = new System.Drawing.Point(128, 129);
            this.button2_Log_Czytelnik.Name = "button2_Log_Czytelnik";
            this.button2_Log_Czytelnik.Size = new System.Drawing.Size(117, 50);
            this.button2_Log_Czytelnik.TabIndex = 1;
            this.button2_Log_Czytelnik.Text = "Wejscie dla czytelnika";
            this.button2_Log_Czytelnik.UseVisualStyleBackColor = true;
            this.button2_Log_Czytelnik.Click += new System.EventHandler(this.button2_Log_Czytelnik_Click);
            // 
            // Form1_Biblioteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2_Log_Czytelnik);
            this.Controls.Add(this.button1_Log_Pracownik);
            this.Name = "Form1_Biblioteka";
            this.Text = "Form1_Biblioteka";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_Log_Pracownik;
        private System.Windows.Forms.Button button2_Log_Czytelnik;
    }
}

