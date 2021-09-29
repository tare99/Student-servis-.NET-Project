using DLWMS.SQLite.Report;
using DLWMS.WinForms.forma_folder;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DLWMS.WinForms.forma_folder.frmStudentiPredmeti;

namespace DLWMS.SQLite.forma_folder
{
    public partial class frmIzvjestaji : Form
    {
        private printStudent printStudent;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(printStudent printStudent):this()
        {
            this.printStudent = printStudent;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var prosjek = printStudent.Polozeni.Any() ? printStudent.Polozeni.Select(x => x.Ocjena).Average() : 0;
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("BrojIndeksa", printStudent.BrojIndeksa));
            rpc.Add(new ReportParameter("ImePrezime", printStudent.ImePrezime));
            rpc.Add(new ReportParameter("ProsjekOcjena", prosjek.ToString()));


            var tblPolozeni = new dsDLWMS.PolozeniDataTable();
            for (int i = 0; i < printStudent.Polozeni.Count ; i++)
            {
                var red = tblPolozeni.NewPolozeniRow();
                var polozeni = printStudent.Polozeni[i];
                red.Id = polozeni.Predmet.Id;
                red.Naziv = polozeni.Predmet.Naziv;
                red.Ocjena = polozeni.Ocjena;
                red.Datum = polozeni.DatumPolaganja.ToString();
                tblPolozeni.Rows.Add(red);
            }

            var rds = new ReportDataSource();
            rds.Name = "dsPolozeni";
            rds.Value = tblPolozeni;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
