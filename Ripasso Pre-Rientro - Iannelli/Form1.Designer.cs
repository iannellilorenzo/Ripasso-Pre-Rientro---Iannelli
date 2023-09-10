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
            this.SuspendLayout();
            // 
            // Azione1
            // 
            this.Azione1.Location = new System.Drawing.Point(129, 135);
            this.Azione1.Name = "Azione1";
            this.Azione1.Size = new System.Drawing.Size(117, 55);
            this.Azione1.TabIndex = 0;
            this.Azione1.Text = "Azione 1";
            this.Azione1.UseVisualStyleBackColor = true;
            this.Azione1.Click += new System.EventHandler(this.Azione1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 737);
            this.Controls.Add(this.Azione1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Azione1;
    }
}

