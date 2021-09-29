
namespace DLWMS.WinForms.forma_folder
{
    partial class frmNoviStudent
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBrojIndeksa = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAktivan = new System.Windows.Forms.CheckBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbGodinaStudija = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.clbULoge = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(310, 127);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(213, 20);
            this.txtIme.TabIndex = 0;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(310, 227);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtBrojIndeksa
            // 
            this.txtBrojIndeksa.Location = new System.Drawing.Point(310, 177);
            this.txtBrojIndeksa.Name = "txtBrojIndeksa";
            this.txtBrojIndeksa.Size = new System.Drawing.Size(213, 20);
            this.txtBrojIndeksa.TabIndex = 2;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(310, 152);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(213, 20);
            this.txtPrezime.TabIndex = 3;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Broj indeksa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-mail:";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(310, 252);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(213, 20);
            this.dtpDatumRodjenja.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Datum rođenja:";
            // 
            // cbAktivan
            // 
            this.cbAktivan.AutoSize = true;
            this.cbAktivan.Location = new System.Drawing.Point(310, 307);
            this.cbAktivan.Name = "cbAktivan";
            this.cbAktivan.Size = new System.Drawing.Size(62, 17);
            this.cbAktivan.TabIndex = 11;
            this.cbAktivan.Text = "Aktivan";
            this.cbAktivan.UseVisualStyleBackColor = true;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(690, 275);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(64, 21);
            this.btnUnesi.TabIndex = 12;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(216, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1, 320);
            this.label6.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(8, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Insert domain name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(10, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Insert name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Slika studenta:";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // cbGodinaStudija
            // 
            this.cbGodinaStudija.FormattingEnabled = true;
            this.cbGodinaStudija.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbGodinaStudija.Location = new System.Drawing.Point(310, 277);
            this.cbGodinaStudija.Name = "cbGodinaStudija";
            this.cbGodinaStudija.Size = new System.Drawing.Size(213, 21);
            this.cbGodinaStudija.TabIndex = 19;
            this.cbGodinaStudija.SelectedIndexChanged += new System.EventHandler(this.cbGodinaStudija_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Godina studija:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbSpol
            // 
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Location = new System.Drawing.Point(310, 202);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(104, 21);
            this.cmbSpol.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(272, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Spol:";
            // 
            // clbULoge
            // 
            this.clbULoge.FormattingEnabled = true;
            this.clbULoge.Location = new System.Drawing.Point(529, 10);
            this.clbULoge.Name = "clbULoge";
            this.clbULoge.Size = new System.Drawing.Size(229, 259);
            this.clbULoge.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DLWMS.SQLite.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pbSlika
            // 
            this.pbSlika.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSlika.Location = new System.Drawing.Point(312, 11);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(144, 110);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 13;
            this.pbSlika.TabStop = false;
            this.pbSlika.Click += new System.EventHandler(this.pbSlika_Click);
            // 
            // frmNoviStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 341);
            this.Controls.Add(this.clbULoge);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbSpol);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbGodinaStudija);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.cbAktivan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtBrojIndeksa);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtIme);
            this.Name = "frmNoviStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos studenta";
            this.Load += new System.EventHandler(this.frmNoviStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBrojIndeksa;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbAktivan;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbGodinaStudija;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSpol;
        private System.Windows.Forms.CheckedListBox clbULoge;
    }
}