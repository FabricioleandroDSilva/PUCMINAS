using Goclinic.Core.Business;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace Goclinic.Agendamento.Core.Data
{
    public class Contexto : DbContext
    {
        
        public Contexto(DbContextOptions<Contexto> options) : base(options) 
        { 
                
        }

        public DbSet<Paciente> Pacientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:goclinicpucminasdatabase.database.windows.net,1433;Initial Catalog=GoclinicaPucMinasSql;Persist Security Info=False;User ID=admpucminas;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        
    }
}

