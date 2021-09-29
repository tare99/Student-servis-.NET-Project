
namespace DLWMS.SQLite
{
    partial class frmSQLite
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
            this.dgvPrisustva = new System.Windows.Forms.DataGridView();
            this.btnDodajPrisustvo = new System.Windows.Forms.Button();
            this.btnStudenti = new System.Windows.Forms.Button();
            this.BrojIndeksa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrisustva)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrisustva
            // 
            this.dgvPrisustva.AllowUserToAddRows = false;
            this.dgvPrisustva.AllowUserToDeleteRows = false;
            this.dgvPrisustva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrisustva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrojIndeksa,
            this.Ime,
            this.Prezime});
            this.dgvPrisustva.Location = new System.Drawing.Point(13, 114);
            this.dgvPrisustva.Name = "dgvPrisustva";
            this.dgvPrisustva.ReadOnly = true;
            this.dgvPrisustva.Size = new System.Drawing.Size(603, 273);
            this.dgvPrisustva.TabIndex = 0;
            // 
            // btnDodajPrisustvo
            // 
            this.btnDodajPrisustvo.Location = new System.Drawing.Point(503, 85);
            this.btnDodajPrisustvo.Name = "btnDodajPrisustvo";
            this.btnDodajPrisustvo.Size = new System.Drawing.Size(113, 23);
            this.btnDodajPrisustvo.TabIndex = 1;
            this.btnDodajPrisustvo.Text = "Dodaj prisustvo";
            this.btnDodajPrisustvo.UseVisualStyleBackColor = true;
            this.btnDodajPrisustvo.Click += new System.EventHandler(this.btnDodajPrisustvo_Click);
            // 
            // btnStudenti
            // 
            this.btnStudenti.Location = new System.Drawing.Point(503, 56);
            this.btnStudenti.Name = "btnStudenti";
            this.btnStudenti.Size = new System.Drawing.Size(113, 23);
            this.btnStudenti.TabIndex = 2;
            this.btnStudenti.Text = "Studenti";
            this.btnStudenti.UseVisualStyleBackColor = true;
            this.btnStudenti.Click += new System.EventHandler(this.btnStudenti_Click);
            // 
            // BrojIndeksa
            // 
            this.BrojIndeksa.DataPropertyName = "BrojIndeksa";
            this.BrojIndeksa.HeaderText = "Broj indeksa";
            this.BrojIndeksa.Name = "BrojIndeksa";
            this.BrojIndeksa.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // frmSQLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 399);
            this.Controls.Add(this.btnStudenti);
            this.Controls.Add(this.btnDodajPrisustvo);
            this.Controls.Add(this.dgvPrisustva);
            this.Name = "frmSQLite";
            this.Text = "Prisustva";
            this.Load += new System.EventHandler(this.frmSQLite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrisustva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrisustva;
        private System.Windows.Forms.Button btnDodajPrisustvo;
        private System.Windows.Forms.Button btnStudenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojIndeksa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
    }
}

