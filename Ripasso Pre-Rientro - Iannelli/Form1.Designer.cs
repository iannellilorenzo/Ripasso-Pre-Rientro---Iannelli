namespace Ripasso_Pre_Rientro___Iannelli
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
            this.Azione1 = new System.Windows.Forms.Button();
            this.Azione2 = new System.Windows.Forms.Button();
            this.Azione3 = new System.Windows.Forms.Button();
            this.Azione3Avanzato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Azione1
            // 
            this.Azione1.Location = new System.Drawing.Point(36, 44);
            this.Azione1.Name = "Azione1";
            this.Azione1.Size = new System.Drawing.Size(117, 55);
            this.Azione1.TabIndex = 0;
            this.Azione1.Text = "Azione 1";
            this.Azione1.UseVisualStyleBackColor = true;
            this.Azione1.Click += new System.EventHandler(this.Azione1_Click);
            // 
            // Azione2
            // 
            this.Azione2.Location = new System.Drawing.Point(36, 117);
            this.Azione2.Name = "Azione2";
            this.Azione2.Size = new System.Drawing.Size(117, 55);
            this.Azione2.TabIndex = 1;
            this.Azione2.Text = "Azione 2";
            this.Azione2.UseVisualStyleBackColor = true;
            this.Azione2.Click += new System.EventHandler(this.Azione2_Click);
            // 
            // Azione3
            // 
            this.Azione3.Location = new System.Drawing.Point(36, 198);
            this.Azione3.Name = "Azione3";
            this.Azione3.Size = new System.Drawing.Size(117, 55);
            this.Azione3.TabIndex = 2;
            this.Azione3.Text = "Azione 3";
            this.Azione3.UseVisualStyleBackColor = true;
            this.Azione3.Click += new System.EventHandler(this.Azione3_Click);
            // 
            // Azione3Avanzato
            // 
            this.Azione3Avanzato.Location = new System.Drawing.Point(36, 284);
            this.Azione3Avanzato.Name = "Azione3Avanzato";
            this.Azione3Avanzato.Size = new System.Drawing.Size(117, 55);
            this.Azione3Avanzato.TabIndex = 3;
            this.Azione3Avanzato.Text = "Azione 3 Avanzato";
            this.Azione3Avanzato.UseVisualStyleBackColor = true;
            this.Azione3Avanzato.Click += new System.EventHandler(this.Azione3Avanzato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 737);
            this.Controls.Add(this.Azione3Avanzato);
            this.Controls.Add(this.Azione3);
            this.Controls.Add(this.Azione2);
            this.Controls.Add(this.Azione1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Azione1;
        private System.Windows.Forms.Button Azione2;
        private System.Windows.Forms.Button Azione3;
        private System.Windows.Forms.Button Azione3Avanzato;
    }
}

