using Goclinic.AgendaMedica.Core.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goclinic.AgendaMedica.Core.Data.Mappings
{
   public class AgendaMapping
    {
        public void Configure(EntityTypeBuilder<Agenda> builder)
        {
            builder.HasKey(a => a.Id);

            builder.HasKey(a => a.MedicoResponsavelId);

            builder.Property(a => a.Id).ValueGeneratedOnAdd();

            builder.Property(a => a.DataInicialAtendimento).IsRequired();

            builder.Property(a => a.DataFinalAtendimento).IsRequired();

            builder.Property(a => a.DiasSemanaAtendimento).IsRequired();

            builder.Property(a => a.HorarioInicialAtendimento).IsRequired();
            
            builder.Property(a => a.HorarioFinalAtendimento).IsRequired();

            builder.Property(a => a.TempoAgendamento).IsRequired();

            builder.Property(a => a.MedicoResponsavelId).IsRequired();

            builder.ToTable("AgendaMedica");

        }
       

     
    }
}
