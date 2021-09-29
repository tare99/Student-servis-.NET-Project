using DLWMS.SQLite.DLWMS.Klase;
using DLWMS.SQLite.Folder1;
using DLWMS.SQLite.forma_folder;
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
    
    public partial class frmStudentiPredmeti : Form
    {
        KonekcijaNaBazu _baza = ServisDb.Baza;
        Student _student;
      
        public frmStudentiPredmeti(Student student)
        {
            InitializeComponent();
            _student = student;
        }

        private void frmStudentiPredmeti_Load(object sender, EventArgs e)
        {
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
            UcitajPredmete();
            UcitajPodatkeOPredmetima();
        }
        private void UcitajPodatkeOPredmetima()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = _baza.StudentiPredmeti.Where(x => x.Student.Id == _student.Id).ToList();
        }

        private void UcitajPredmete()
        {
            cmbPredmet.DataSource = _baza.Predmeti.ToList();
            cmbPredmet.ValueMember = "Id";
            cmbPredmet.DisplayMember = "Naziv";
        }

        private void btnDodajPredmet_Click(object sender, EventArgs e)
        {
            if (ValidanUnos() && ProvjeriPredmet())
            {
                _baza.StudentiPredmeti.Add(new StudentiPredmeti()
                {
                    Predmet = cmbPredmet.SelectedItem as Predmet,
                    Student = _student,
                    DatumPolaganja=dtpDatumPolaganja.Value,
                    Ocjena=int.Parse(cmbOcjena.SelectedItem.ToString())
                });
            };
            _baza.SaveChanges();
            UcitajPodatkeOPredmetima();
        }
         
        private bool ProvjeriPredmet()
        {
            var odabraniPredmet = cmbPredmet.SelectedItem as Predmet;
            var predmet = _baza.StudentiPredmeti.Where(x => x.Student.Id == _student.Id && odabraniPredmet.Id==x.Predmet.Id).ToList();
        if (predmet.Any())
            {
                MessageBox.Show("Predmet vec unesen!");
                return false;
            }
            return true;
        }

        private bool ValidanUnos()
        {
            return Validator.Validiraj(cmbPredmet, err, "Predmet obavezan") &&
                   Validator.Validiraj(cmbOcjena, err, "Ocjena obavezna");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printStudent printStudent = new printStudent()
            {
                BrojIndeksa = _student.Indeks,
                ImePrezime = $"{_student.Ime} {_student.Prezime}",
                Polozeni = dgvPolozeniPredmeti.DataSource as List<StudentiPredmeti>
        };
            frmIzvjestaji frmIzvjestaji = new frmIzvjestaji(printStudent);
            frmIzvjestaji.ShowDialog();
        }
        public class printStudent
        {
            public string BrojIndeksa{ get; set; }
            public string ImePrezime{ get; set; }
            public List<StudentiPredmeti> Polozeni{ get; set; }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var predmet = dgvPolozeniPredmeti.SelectedRows[0].DataBoundItem as StudentiPredmeti;
            if(MessageBox.Show("Jeste li sigurni da zelite ukloniti polozeni predmet?",
                "Ukloni polozeni predmet", 
                MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                _baza.StudentiPredmeti.Remove(predmet);
                _baza.SaveChanges();
                UcitajPodatkeOPredmetima();
            }
        }
    }
}
