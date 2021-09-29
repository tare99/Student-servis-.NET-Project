using DLWMS.SQLite.DLWMS.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Text;

namespace DLWMS.WinForms.DLWMS.Klase
{
    [Table("Student")]
    public class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public int GodinaStudija{ get; set; }
        public virtual Spol Spol { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }
        public virtual ICollection<Uloga> Uloge { get; set; } = new HashSet<Uloga>();
        public string Ime{ get; set; }
        public string Prezime { get; set; }
        public override string ToString()
        {
            return $"{Ime}{Prezime}"; 
        }

    }
}
