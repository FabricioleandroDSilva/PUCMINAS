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
   public class UsuarioMapping
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Login)
                .IsRequired(true);

            builder.Property(p => p.Senha)
                .IsRequired(true);

            builder.Property(p => p.TipoAcesso)
               .IsRequired(true);


            builder.ToTable("Usuario");
        }
    }
}
