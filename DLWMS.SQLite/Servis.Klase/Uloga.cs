using DLWMS.WinForms.DLWMS.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.SQLite.DLWMS.Klase
{
    [Table("Uloge")]
    public class Uloga
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public virtual ICollection<Student> Studenti { get; set; } = new HashSet<Student>();
        public override string ToString()
        {
            return Naziv;
        }
    }
}
