
using Goclinic.Agendamento.Core.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Goclinic.Agendamento.Core.Data.Mappings
{
   public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
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
