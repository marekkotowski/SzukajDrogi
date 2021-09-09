namespace SzukajDrogi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.nX = new System.Windows.Forms.NumericUpDown();
            this.nY = new System.Windows.Forms.NumericUpDown();
            this.pMapa = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lbxLog = new System.Windows.Forms.ListBox();
            this.btnSzukajDrogi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWartosc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj wymiary mapy:";
            // 
            // nX
            // 
            this.nX.Location = new System.Drawing.Point(185, 20);
            this.nX.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nX.Name = "nX";
            this.nX.Size = new System.Drawing.Size(68, 20);
            this.nX.TabIndex = 1;
            this.nX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nX.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nY
            // 
            this.nY.Location = new System.Drawing.Point(290, 20);
            this.nY.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nY.Name = "nY";
            this.nY.Size = new System.Drawing.Size(68, 20);
            this.nY.TabIndex = 2;
            this.nY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nY.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // pMapa
            // 
            this.pMapa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pMapa.Location = new System.Drawing.Point(29, 65);
            this.pMapa.Margin = new System.Windows.Forms.Padding(0);
            this.pMapa.Name = "pMapa";
            this.pMapa.Size = new System.Drawing.Size(747, 449);
            this.pMapa.TabIndex = 3;
            this.pMapa.Click += new System.EventHandler(this.pMapa_Click);
            this.pMapa.Paint += new System.Windows.Forms.PaintEventHandler(this.pMapa_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generuj Mape";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(803, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "X:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(803, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblX
            // 
            this.lblX.Location = new System.Drawing.Point(901, 79);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(91, 23);
            this.lblX.TabIndex = 7;
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblY
            // 
            this.lblY.Location = new System.Drawing.Point(901, 106);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(91, 23);
            this.lblY.TabIndex = 8;
            this.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbxLog
            // 
            this.lbxLog.FormattingEnabled = true;
            this.lbxLog.Location = new System.Drawing.Point(29, 530);
            this.lbxLog.Name = "lbxLog";
            this.lbxLog.Size = new System.Drawing.Size(747, 56);
            this.lbxLog.TabIndex = 9;
            // 
            // btnSzukajDrogi
            // 
            this.btnSzukajDrogi.Location = new System.Drawing.Point(779, 178);
            this.btnSzukajDrogi.Name = "btnSzukajDrogi";
            this.btnSzukajDrogi.Size = new System.Drawing.Size(154, 77);
            this.btnSzukajDrogi.TabIndex = 10;
            this.btnSzukajDrogi.Text = "SzukajDrogi";
            this.btnSzukajDrogi.UseVisualStyleBackColor = true;
            this.btnSzukajDrogi.Click += new System.EventHandler(this.btnSzukajDrogi_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(803, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Wartosc:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWartosc
            // 
            this.lblWartosc.Location = new System.Drawing.Point(901, 138);
            this.lblWartosc.Name = "lblWartosc";
            this.lblWartosc.Size = new System.Drawing.Size(91, 23);
            this.lblWartosc.TabIndex = 12;
            this.lblWartosc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 644);
            this.Controls.Add(this.lblWartosc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSzukajDrogi);
            this.Controls.Add(this.lbxLog);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pMapa);
            this.Controls.Add(this.nY);
            this.Controls.Add(this.nX);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Szukaj Drogi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nX;
        private System.Windows.Forms.NumericUpDown nY;
        private System.Windows.Forms.FlowLayoutPanel pMapa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.ListBox lbxLog;
        private System.Windows.Forms.Button btnSzukajDrogi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWartosc;
    }
}

