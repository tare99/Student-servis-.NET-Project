using DLWMS.WinForms.DLWMS.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace DLWMS.SQLite.DLWMS.Klase
{
    [Table("StudentiPredmeti")]
    public class StudentiPredmeti
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Predmet Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }
    }
}
