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
            this.button1_powrotDoGlownego = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_powrotDoGlownego
            // 
            this.button1_powrotDoGlownego.Location = new System.Drawing.Point(684, 12);
            this.button1_powrotDoGlownego.Name = "button1_powrotDoGlownego";
            this.button1_powrotDoGlownego.Size = new System.Drawing.Size(104, 48);
            this.button1_powrotDoGlownego.TabIndex = 0;
            this.button1_powrotDoGlownego.Text = "powrót do ekranu głównego";
            this.button1_powrotDoGlownego.UseVisualStyleBackColor = true;
            this.button1_powrotDoGlownego.Click += new System.EventHandler(this.button1_powrotDoGlownego_Click);
            // 
            // Form3_PanelCzytelnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1_powrotDoGlownego);
            this.Name = "Form3_PanelCzytelnika";
            this.Text = "Form3_PanelCzytelnika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_powrotDoGlownego;
    }
}