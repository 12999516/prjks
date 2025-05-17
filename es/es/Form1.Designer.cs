namespace es
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_parola = new System.Windows.Forms.Label();
            this.txt_guess = new System.Windows.Forms.TextBox();
            this.lbl_messaggio = new System.Windows.Forms.Label();
            this.btn_guess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_parola
            // 
            this.lbl_parola.Location = new System.Drawing.Point(24, 128);
            this.lbl_parola.Name = "lbl_parola";
            this.lbl_parola.Size = new System.Drawing.Size(228, 48);
            this.lbl_parola.TabIndex = 0;
            // 
            // txt_guess
            // 
            this.txt_guess.Location = new System.Drawing.Point(15, 42);
            this.txt_guess.Name = "txt_guess";
            this.txt_guess.Size = new System.Drawing.Size(127, 22);
            this.txt_guess.TabIndex = 1;
            // 
            // lbl_messaggio
            // 
            this.lbl_messaggio.Location = new System.Drawing.Point(12, 9);
            this.lbl_messaggio.Name = "lbl_messaggio";
            this.lbl_messaggio.Size = new System.Drawing.Size(130, 30);
            this.lbl_messaggio.TabIndex = 2;
            this.lbl_messaggio.Text = "inserisci una parola";
            // 
            // btn_guess
            // 
            this.btn_guess.Location = new System.Drawing.Point(183, 9);
            this.btn_guess.Name = "btn_guess";
            this.btn_guess.Size = new System.Drawing.Size(69, 55);
            this.btn_guess.TabIndex = 3;
            this.btn_guess.Text = "make guess";
            this.btn_guess.UseVisualStyleBackColor = true;
            this.btn_guess.Click += new System.EventHandler(this.btn_guess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 453);
            this.Controls.Add(this.btn_guess);
            this.Controls.Add(this.lbl_messaggio);
            this.Controls.Add(this.txt_guess);
            this.Controls.Add(this.lbl_parola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_parola;
        private System.Windows.Forms.TextBox txt_guess;
        private System.Windows.Forms.Label lbl_messaggio;
        private System.Windows.Forms.Button btn_guess;
    }
}

