
namespace DLWMS.WinForms.forma_folder
{
    partial class frmStudentiPredmeti
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
            this.components = new System.ComponentModel.Container();
            this.dgvPolozeniPredmeti = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPolaganja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPredmet = new System.Windows.Forms.ComboBox();
            this.cmbOcjena = new System.Windows.Forms.ComboBox();
            this.dtpDatumPolaganja = new System.Windows.Forms.DateTimePicker();
            this.btnDodajPredmet = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPolozeniPredmeti
            // 
            this.dgvPolozeniPredmeti.AllowUserToAddRows = false;
            this.dgvPolozeniPredmeti.AllowUserToDeleteRows = false;
            this.dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolozeniPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Ocjena,
            this.DatumPolaganja});
            this.dgvPolozeniPredmeti.Location = new System.Drawing.Point(10, 73);
            this.dgvPolozeniPredmeti.Name = "dgvPolozeniPredmeti";
            this.dgvPolozeniPredmeti.ReadOnly = true;
            this.dgvPolozeniPredmeti.RowTemplate.Height = 25;
            this.dgvPolozeniPredmeti.Size = new System.Drawing.Size(431, 179);
            this.dgvPolozeniPredmeti.TabIndex = 0;
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // DatumPolaganja
            // 
            this.DatumPolaganja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumPolaganja.DataPropertyName = "DatumPolaganja";
            this.DatumPolaganja.HeaderText = "Datum polaganja";
            this.DatumPolaganja.Name = "DatumPolaganja";
            this.DatumPolaganja.ReadOnly = true;
            // 
            // cmbPredmet
            // 
            this.cmbPredmet.FormattingEnabled = true;
            this.cmbPredmet.Location = new System.Drawing.Point(8, 48);
            this.cmbPredmet.Name = "cmbPredmet";
            this.cmbPredmet.Size = new System.Drawing.Size(138, 21);
            this.cmbPredmet.TabIndex = 1;
            this.cmbPredmet.Text = "Predmet";
            // 
            // cmbOcjena
            // 
            this.cmbOcjena.FormattingEnabled = true;
            this.cmbOcjena.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbOcjena.Location = new System.Drawing.Point(150, 48);
            this.cmbOcjena.Name = "cmbOcjena";
            this.cmbOcjena.Size = new System.Drawing.Size(79, 21);
            this.cmbOcjena.TabIndex = 2;
            this.cmbOcjena.Text = "Ocjena";
            // 
            // dtpDatumPolaganja
            // 
            this.dtpDatumPolaganja.Location = new System.Drawing.Point(233, 48);
            this.dtpDatumPolaganja.Name = "dtpDatumPolaganja";
            this.dtpDatumPolaganja.Size = new System.Drawing.Size(126, 20);
            this.dtpDatumPolaganja.TabIndex = 3;
            // 
            // btnDodajPredmet
            // 
            this.btnDodajPredmet.Location = new System.Drawing.Point(364, 48);
            this.btnDodajPredmet.Name = "btnDodajPredmet";
            this.btnDodajPredmet.Size = new System.Drawing.Size(75, 20);
            this.btnDodajPredmet.TabIndex = 4;
            this.btnDodajPredmet.Text = "Dodaj";
            this.btnDodajPredmet.UseVisualStyleBackColor = true;
            this.btnDodajPredmet.Click += new System.EventHandler(this.btnDodajPredmet_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(366, 258);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmStudentiPredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 285);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDodajPredmet);
            this.Controls.Add(this.dtpDatumPolaganja);
            this.Controls.Add(this.cmbOcjena);
            this.Controls.Add(this.cmbPredmet);
            this.Controls.Add(this.dgvPolozeniPredmeti);
            this.Name = "frmStudentiPredmeti";
            this.Text = "Polozeni predmeti";
            this.Load += new System.EventHandler(this.frmStudentiPredmeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPolozeniPredmeti;
        private System.Windows.Forms.ComboBox cmbPredmet;
        private System.Windows.Forms.ComboBox cmbOcjena;
        private System.Windows.Forms.DateTimePicker dtpDatumPolaganja;
        private System.Windows.Forms.Button btnDodajPredmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPolaganja;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btnPrint;
    }
}