
namespace CineKometa
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.koupeni = new System.Windows.Forms.RadioButton();
            this.rezervace = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // koupeni
            // 
            this.koupeni.AutoSize = true;
            this.koupeni.Location = new System.Drawing.Point(643, 379);
            this.koupeni.Name = "koupeni";
            this.koupeni.Size = new System.Drawing.Size(67, 21);
            this.koupeni.TabIndex = 0;
            this.koupeni.TabStop = true;
            this.koupeni.Text = "koupit";
            this.koupeni.UseVisualStyleBackColor = true;
            // 
            // rezervace
            // 
            this.rezervace.AutoSize = true;
            this.rezervace.Location = new System.Drawing.Point(643, 341);
            this.rezervace.Name = "rezervace";
            this.rezervace.Size = new System.Drawing.Size(92, 21);
            this.rezervace.TabIndex = 1;
            this.rezervace.TabStop = true;
            this.rezervace.Text = "rezervace";
            this.rezervace.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rezervace);
            this.Controls.Add(this.koupeni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CineKometa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton koupeni;
        private System.Windows.Forms.RadioButton rezervace;
    }
}

