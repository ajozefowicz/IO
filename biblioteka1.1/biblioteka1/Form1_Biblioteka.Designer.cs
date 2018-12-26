
using biblioteka1;

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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_loginCzytelnika = new System.Windows.Forms.TextBox();
            this.textBox1_loginPracownika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "login";
            // 
            // textBox1_loginCzytelnika
            // 
            this.textBox1_loginCzytelnika.Location = new System.Drawing.Point(151, 93);
            this.textBox1_loginCzytelnika.Name = "textBox1_loginCzytelnika";
            this.textBox1_loginCzytelnika.Size = new System.Drawing.Size(100, 20);
            this.textBox1_loginCzytelnika.TabIndex = 3;
            // 
            // textBox1_loginPracownika
            // 
            this.textBox1_loginPracownika.Location = new System.Drawing.Point(533, 93);
            this.textBox1_loginPracownika.Name = "textBox1_loginPracownika";
            this.textBox1_loginPracownika.Size = new System.Drawing.Size(100, 20);
            this.textBox1_loginPracownika.TabIndex = 5;
            this.textBox1_loginPracownika.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "login";
            // 
            // Form1_Biblioteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1_loginPracownika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_loginCzytelnika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2_Log_Czytelnik);
            this.Controls.Add(this.button1_Log_Pracownik);
            this.Name = "Form1_Biblioteka";
            this.Text = "Form1_Biblioteka";
            this.Load += new System.EventHandler(this.Form1_Biblioteka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Log_Pracownik;
        private System.Windows.Forms.Button button2_Log_Czytelnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_loginCzytelnika;
        private System.Windows.Forms.TextBox textBox1_loginPracownika;
        private System.Windows.Forms.Label label2;
    }
}

