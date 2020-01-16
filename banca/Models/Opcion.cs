using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//https://dzone.com/articles/using-self-referencing-tables
namespace banca.Models
{
    public class Opcion
    {
        private int OpId { get; set; }
        private string OpNombre { get; set; }
        private string OpDescripcion { get; set; }
        private int? OpPadreId { get; set; }
        public virtual Opcion OpPadre { get; set; } 
        public virtual ICollection<Opcion> OpHijos { get; set; }
            

    }

    public class OpcionContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            HasKey(x => x.CategoryId);

            Property(x => x.CategoryId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(255);

            HasOptional(x => x.Parent)
                .WithMany(x => x.Children)
                .HasForeignKey(x => x.ParentId)
                .WillCascadeOnDelete(false);
        }
        public DbSet<Opcion> Opcion { get; set; }


    }
}   