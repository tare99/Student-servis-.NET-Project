using DLWMS.SQLite.Folder1;
using DLWMS.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DLWMS.SQLite
{
    public partial class frmSQLite : Form
    {
        KonekcijaNaBazu _db = new KonekcijaNaBazu();
        public frmSQLite()
        {
            InitializeComponent();
        }

        private void frmSQLite_Load(object sender, EventArgs e)
        {
            dgvPrisustva.AutoGenerateColumns = false;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            try
            {
                dgvPrisustva.DataSource = null;
                dgvPrisustva.DataSource = _db.Prisustva.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void btnDodajPrisustvo_Click(object sender, EventArgs e)
        {
            _db.Prisustva.Add(new Prisustva
            {
                BrojIndeksa = $"BB200{(100 + DateTime.Now.Second).ToString()}",
                Ime = ImePrezimeGenerator.GetIme(),
                Prezime = ImePrezimeGenerator.GetPrezime()
            });
            _db.SaveChanges();
            UcitajPodatke();

        }

        private void btnStudenti_Click(object sender, EventArgs e)
        {
            frmStudenti frmStudenti = new frmStudenti();
            frmStudenti.ShowDialog();
        }
    }
}
