using DLWMS.SQLite.DLWMS.Klase;
using DLWMS.SQLite.Folder1;
using DLWMS.WinForms.DLWMS.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DLWMS.WinForms.forma_folder
{
    public partial class frmNoviStudent : Form
    {
        private Student _student;
        private bool _promjena;
        KonekcijaNaBazu _baza = ServisDb.Baza;
        public frmNoviStudent()
        {
            InitializeComponent();
            UcitajSpolove();
            UcitajUloge();
        }

        private void UcitajUloge()
        {
            clbULoge.DataSource = _baza.Uloge.ToList();
            clbULoge.DisplayMember = "Naziv";
        }

        private void UcitajSpolove()
        {
            cmbSpol.DataSource= _baza.Spolovi.ToList();
            cmbSpol.DisplayMember = "Naziv";
            cmbSpol.ValueMember = "Id";
        }

        public frmNoviStudent(Student student):this()
        {
            this._student = student;
            UcitajStudenta();
        }

        private void UcitajStudenta()
        {
            if(_student!=null)
            {
                txtIme.Text = _student.Ime;
                txtPrezime.Text = _student.Prezime;
                txtBrojIndeksa.Text = _student.Indeks;
                txtEmail.Text = _student.Email;
                pbSlika.Image = ImageHelper.FromByteToImage(_student.Slika);
                cbGodinaStudija.SelectedIndex = cbGodinaStudija.Items.IndexOf(_student.GodinaStudija.ToString());
                cmbSpol.SelectedValue = _student.Spol.Id;
                dtpDatumRodjenja.Value = _student.DatumRodjenja;
                cbAktivan.Checked = _student.Aktivan;
                for (int i = 0; i < clbULoge.Items.Count; i++)
                {
                    if (_student.Uloge.Where(x => x.Id == clbULoge.Items.Cast<Uloga>().ToList()[i].Id).Count() > 0)
                        clbULoge.SetItemChecked(i, true);
                }
                this.Text = "Editovanje postojeceg studenta!";
                _promjena = true;
            }
        }

        private void frmNoviStudent_Load(object sender, EventArgs e)
        {
            GenerisiBrojIndeksa();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                if(!_promjena)
                {
                    _student = new Student();
                }
                _student.Ime = txtIme.Text;
                _student.Prezime = txtPrezime.Text;
                _student.Indeks = txtBrojIndeksa.Text;
                _student.Email = txtEmail.Text;
                _student.Spol = cmbSpol.SelectedItem as Spol;
                _student.Slika = ImageHelper.FromImageToByte(pbSlika.Image);
                _student.GodinaStudija = int.Parse(cbGodinaStudija.SelectedItem.ToString());
                _student.DatumRodjenja = dtpDatumRodjenja.Value;
                _student.Aktivan = cbAktivan.Checked;
                _student.Uloge = clbULoge.CheckedItems.Cast<Uloga>().ToList();

                if(!_promjena)
                {
                    _baza.Studenti.Add(_student);
                    MessageBox.Show("Student upsjesno dodat!");
                }
                else
                {
                    _baza.Entry(_student).State = System.Data.Entity.EntityState.Modified;
                    MessageBox.Show("Student uspjesno editovan!");
                }
                _baza.SaveChanges();
                this.Close();
            }
        }

        private void GenerisiBrojIndeksa()
        {
            if(cbGodinaStudija.SelectedItem!=null)
            {
                int godina = int.Parse(cbGodinaStudija.SelectedItem.ToString()) - 1;
                txtBrojIndeksa.Text = $"BB{(DateTime.Now.Year - 2000 - godina) * 10000 + _baza.Studenti.ToList().Count()}";
            }
        }
        private void GenerisiEmail()
        {
            int count = 0;
            txtEmail.Text = txtIme.Text.ToLower() + "." + txtPrezime.Text.ToLower() + "@edu.fit.ba";
            foreach (var student in _baza.Studenti)
            {
                if (txtIme.Text.ToLower() == student.Ime.ToLower() && txtPrezime.Text.ToLower() == student.Prezime.ToLower())
                    count++;
            }
            if(count>0)
                txtEmail.Text = txtIme.Text.ToLower() + "." + txtPrezime.Text.ToLower() + count.ToString() + "@edu.fit.ba";
        }

        private bool ValidirajUnos()
        {
            return Validator.Validiraj(txtIme, err, "Obavezno polje!") &&
                   Validator.Validiraj(txtPrezime, err, "Obavezno polje!") &&
                   Validator.Validiraj(cbGodinaStudija, err, "Obavezno polje!") &&
                   Validator.Validiraj(pbSlika, err, "Slika je obavezna!") &&
                   Validator.Validiraj(cmbSpol, err, "Vrijednost nije validna");
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && CheckIfPictureFormat(openFileDialog1))
            {
                pbSlika.ImageLocation = openFileDialog1.FileName;
            }
        }

        private bool CheckIfPictureFormat(OpenFileDialog ofd)
        {
            return ofd.FileName.EndsWith(".jpg") || ofd.FileName.EndsWith(".png");
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiEmail();
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiEmail();
        }

        private void cbGodinaStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerisiBrojIndeksa();
        }
    }
      
}
