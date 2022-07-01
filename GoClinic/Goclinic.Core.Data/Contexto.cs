using Goclinic.Agendamento.Core.Business.Models;
using Goclinic.Agendamento.Core.Data.Mappings;
using Goclinic.Agendamento.Data.Mappings;
using Goclinic.Core.Business;
using Microsoft.EntityFrameworkCore;


namespace Goclinic.Agendamento.Core.Data
{
    public class Contexto : DbContext
    {
        
        public Contexto(DbContextOptions<Contexto> options) : base(options) 
        { 
                
        }

        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PacienteMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());

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

