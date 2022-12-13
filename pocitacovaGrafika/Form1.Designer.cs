namespace pocitacovaGrafika
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zobrazitFotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zobrazitFotoOVelikostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.přehrávatFotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zobrazitFotoToolStripMenuItem,
            this.zobrazitFotoOVelikostiToolStripMenuItem,
            this.přehrávatFotoToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // zobrazitFotoToolStripMenuItem
            // 
            this.zobrazitFotoToolStripMenuItem.Name = "zobrazitFotoToolStripMenuItem";
            this.zobrazitFotoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.zobrazitFotoToolStripMenuItem.Text = "Zobrazit foto";
            this.zobrazitFotoToolStripMenuItem.Click += new System.EventHandler(this.zobrazitFotoToolStripMenuItem_Click);
            // 
            // zobrazitFotoOVelikostiToolStripMenuItem
            // 
            this.zobrazitFotoOVelikostiToolStripMenuItem.Name = "zobrazitFotoOVelikostiToolStripMenuItem";
            this.zobrazitFotoOVelikostiToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.zobrazitFotoOVelikostiToolStripMenuItem.Text = "Zobrazit foto o velikosti...";
            // 
            // přehrávatFotoToolStripMenuItem
            // 
            this.přehrávatFotoToolStripMenuItem.Name = "přehrávatFotoToolStripMenuItem";
            this.přehrávatFotoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.přehrávatFotoToolStripMenuItem.Text = "Přehrávat foto";
            this.přehrávatFotoToolStripMenuItem.Click += new System.EventHandler(this.přehrávatFotoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 566);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zobrazitFotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zobrazitFotoOVelikostiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem přehrávatFotoToolStripMenuItem;
    }
}

