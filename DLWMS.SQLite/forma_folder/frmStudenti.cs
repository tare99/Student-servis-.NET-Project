using DLWMS.SQLite.Folder1;
using DLWMS.WinForms.DLWMS.Klase;
using DLWMS.WinForms.forma_folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms
{
    public partial class frmStudenti : Form
    {
        KonekcijaNaBazu _baza = ServisDb.Baza;
        List<Student> rezultat = null;
        private bool promjena = true;
        public frmStudenti()
        {
            InitializeComponent();
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;
            dgvStudenti.DataSource = _baza.Studenti.ToList();
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {
            frmNoviStudent frmNoviStudent = new frmNoviStudent();
            UcitajFormu(frmNoviStudent);
            RefresajBazu(rezultat);
        }

        private void RefresajBazu(List<Student> studenti=null)
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = studenti ?? _baza.Studenti.ToList();
            _baza.SaveChanges();
        }

        private void UcitajFormu(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void dgvStudenti_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Student student = new Student();
            student=dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            if(student!=null)
            {
                frmNoviStudent frmNoviStudent = new frmNoviStudent(student);
                UcitajFormu(frmNoviStudent);
                RefresajBazu(rezultat);
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var filter = txtPretraga.Text.ToLower();
            var rezultat = _baza.Studenti.ToList().Where(s => (s.Ime.ToLower() + " " + s.Prezime.ToLower()).Contains(filter));
            if(rezultat!=null)
            {
                RefresajBazu(rezultat.ToList());
            }
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Sender = sender as DataGridView;
            if(Sender.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex==6)
            {
                Student student = new Student();
                student= dgvStudenti.SelectedRows[0].DataBoundItem as Student;
                if (student != null)
                {
                    frmStudentiPredmeti frmStudentiPredmeti = new frmStudentiPredmeti(student);
                    frmStudentiPredmeti.ShowDialog();
                    RefresajBazu(rezultat);
                }
            }
        }

        private void SortirajUzlazno(int index)
        {
            if(index==0)
                rezultat = _baza.Studenti.OrderBy(x => x.Indeks.ToLower()).ToList();
            else if (index == 1)
                rezultat = _baza.Studenti.OrderBy(x => x.Ime.ToLower()).ToList();
            else if(index==3)
                rezultat = _baza.Studenti.OrderBy(x => x.Spol.Naziv.ToLower()).ToList();
            else if (index == 2)
                rezultat = _baza.Studenti.OrderBy(x => x.Prezime.ToLower()).ToList();
            else if (index == 4)
                rezultat = _baza.Studenti.OrderBy(x => x.GodinaStudija).ToList();
            promjena = false;
        }

        private void dgvStudenti_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (promjena)
                SortirajUzlazno(e.ColumnIndex);
            else
                SortitajSilazno(e.ColumnIndex);
            RefresajBazu(rezultat);
        }

        private void SortitajSilazno(int index)
        {
            if (index == 0)
                rezultat = _baza.Studenti.OrderByDescending(x => x.Indeks.ToLower()).ToList();
            else if (index == 1)
                rezultat = _baza.Studenti.OrderByDescending(x => x.Ime.ToLower()).ToList();
            else if (index == 2)
                rezultat = _baza.Studenti.OrderByDescending(x => x.Prezime.ToLower()).ToList();
            else if (index == 3)
                rezultat = _baza.Studenti.OrderByDescending(x => x.Spol.Naziv.ToLower()).ToList();
            else if (index == 4)
                rezultat = _baza.Studenti.OrderByDescending(x => x.GodinaStudija).ToList();
            promjena = true;
        }
    }
}
