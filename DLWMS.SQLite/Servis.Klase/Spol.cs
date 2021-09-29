using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DLWMS.WinForms.DLWMS.Klase
{
    [Table("Spolovi")]
    public class Spol
    {
        public int Id{ get; set; }
        public string Naziv { get; set; }
        public override string ToString() => Naziv;
        
    }
}
