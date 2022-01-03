
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // koupeni
            // 
            this.koupeni.AutoSize = true;
            this.koupeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.koupeni.ForeColor = System.Drawing.Color.White;
            this.koupeni.Location = new System.Drawing.Point(497, 382);
            this.koupeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.koupeni.Name = "koupeni";
            this.koupeni.Size = new System.Drawing.Size(114, 29);
            this.koupeni.TabIndex = 0;
            this.koupeni.TabStop = true;
            this.koupeni.Text = "KOUPIT";
            this.koupeni.UseVisualStyleBackColor = true;
            // 
            // rezervace
            // 
            this.rezervace.AutoSize = true;
            this.rezervace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rezervace.ForeColor = System.Drawing.Color.White;
            this.rezervace.Location = new System.Drawing.Point(188, 382);
            this.rezervace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rezervace.Name = "rezervace";
            this.rezervace.Size = new System.Drawing.Size(178, 29);
            this.rezervace.TabIndex = 1;
            this.rezervace.TabStop = true;
            this.rezervace.Text = "REZERVOVAT";
            this.rezervace.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CineKometa.Properties.Resources.CineKometa_nadpis;
            this.panel1.Location = new System.Drawing.Point(188, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 76);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rezervace);
            this.Controls.Add(this.koupeni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "CineKometa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton koupeni;
        private System.Windows.Forms.RadioButton rezervace;
        private System.Windows.Forms.Panel panel1;
    }
}

