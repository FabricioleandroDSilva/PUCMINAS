using Goclinic.AgendaMedica.Core.Business.Models;
using Goclinic.AgendaMedica.Core.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Goclinic.AgendaMedica.Core.Data
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Medico> Medicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MedicoMapping());
           

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder
       .UseSqlServer(
           @"Server=tcp:goclinicpucminasdatabase.database.windows.net,1433;Initial Catalog=GoclinicaPucMinasSql;Persist Security Info=true;User ID=admpucminas;Password=senha12345$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=130;",
           options => options.EnableRetryOnFailure());

        }
    }
}
