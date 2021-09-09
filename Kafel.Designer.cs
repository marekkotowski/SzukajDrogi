namespace SzukajDrogi
{
    partial class Kafel
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWartosc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWartosc
            // 
            this.lblWartosc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWartosc.Enabled = false;
            this.lblWartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWartosc.Location = new System.Drawing.Point(0, 0);
            this.lblWartosc.Margin = new System.Windows.Forms.Padding(0);
            this.lblWartosc.Name = "lblWartosc";
            this.lblWartosc.Size = new System.Drawing.Size(30, 30);
            this.lblWartosc.TabIndex = 0;
            this.lblWartosc.Text = "0";
            this.lblWartosc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWartosc.Click += new System.EventHandler(this.lblWartosc_Click);
            // 
            // Kafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.lblWartosc);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Kafel";
            this.Size = new System.Drawing.Size(30, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWartosc;
    }
}
