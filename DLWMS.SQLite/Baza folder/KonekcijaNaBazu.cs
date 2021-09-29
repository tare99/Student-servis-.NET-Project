using DLWMS.SQLite.DLWMS.Klase;
using DLWMS.WinForms.DLWMS.Klase;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SQLite;

namespace DLWMS.SQLite.Folder1
{
    public class KonekcijaNaBazu : DbContext
    {

        public KonekcijaNaBazu() : base("PutanjaDoBaze")
        {

        }
        public virtual DbSet<Prisustva> Prisustva { get; set; }
        public virtual DbSet<Student> Studenti { get; set; }
        public virtual DbSet <Spol> Spolovi { get; set; }
        public virtual DbSet<Predmet> Predmeti { get; set; }
        public virtual DbSet<StudentiPredmeti> StudentiPredmeti { get; set; }
        public virtual DbSet<Uloga> Uloge { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasMany(x => x.Uloge).WithMany(x => x.Studenti)
                .Map(su =>
                {
                    su.MapLeftKey("Student_Id");
                    su.MapRightKey("Uloga_Id");
                    su.ToTable("StudentiUloge");
                });
        }

    }
    [Table("Prisustva")]
    public class Prisustva
    {
        public int Id { get; set; }
        public string BrojIndeksa { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
    }
}
