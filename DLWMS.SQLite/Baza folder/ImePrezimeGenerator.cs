using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.SQLite.Folder1
{
    public class ImePrezimeGenerator
    {
        static int seed = DateTime.Now.Millisecond+100000;
        public static List<ImePrezime> imePrezimes { get; set; } = new List<ImePrezime>();
        static ImePrezimeGenerator()
        {
            UcitajImePrezime();
        }

        private static void UcitajImePrezime()
        {
            imePrezimes.Add(new ImePrezime { Ime = "Tarik", Prezime = "Arnaut" });
            imePrezimes.Add(new ImePrezime { Ime = "Haris", Prezime = "Mezit" });
            imePrezimes.Add(new ImePrezime { Ime = "Almir", Prezime = "Hondo" });
            imePrezimes.Add(new ImePrezime { Ime = "Safet", Prezime = "Salihovic" });
            imePrezimes.Add(new ImePrezime { Ime = "Denis", Prezime = "Music" });
            imePrezimes.Add(new ImePrezime { Ime = "Rijad", Prezime = "Piric" });
            imePrezimes.Add(new ImePrezime { Ime = "Amer", Prezime = "Hodzic" });
            imePrezimes.Add(new ImePrezime { Ime = "Namik", Prezime = "Terzic" });
        }
        public static string GetIme()
        {
            return imePrezimes[VratiRadnomBroj()].Ime;
        }
        public static string GetPrezime()
        {
            return imePrezimes[VratiRadnomBroj()].Prezime;
        }

        private static int VratiRadnomBroj()
        {
            Random random = new Random(seed);
            int indeks = random.Next(0, imePrezimes.Count);
            seed += DateTime.Now.Millisecond+3;
            return indeks;
        }
    }
    public class ImePrezime
    {
        public string Ime { get; set; }
        public string Prezime{ get; set; }
    }
}
