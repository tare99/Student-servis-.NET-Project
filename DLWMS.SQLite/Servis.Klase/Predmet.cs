using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DLWMS.WinForms.DLWMS.Klase
{
    [Table("Predmeti")]
    public class Predmet
    {
        public int Id{ get; set; }
        public string Naziv { get; set; }

        public override string ToString()
        {
            return $"{Naziv}";
        }
    }
}
