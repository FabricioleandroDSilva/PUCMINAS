
using Goclinic.AgendaMedica.Core.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Goclinic.AgendaMedica.Core.Data.Mappings
{
    public class MedicoMapping : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Nome)
                .IsRequired(true);

            builder.Property(p => p.Cpf)
                .IsRequired(true);

            builder.Property(p => p.CRM)
                .IsRequired(true);

            builder.Property(p => p.DataNascimento)
           .IsRequired(true);


            builder.Property(p => p.Sexo)
           .IsRequired(true);

            builder.Property(p => p.Endereco)
                .IsRequired(true);

            builder.Property(p => p.Numero)
            .IsRequired(true);

            builder.Property(p => p.Cep)
            .IsRequired(true);


            builder.Property(p => p.Celular)
            .IsRequired(true);


            builder.Property(p => p.Cidade)
            .IsRequired(true);

            builder.Property(p => p.Estado)
            .IsRequired(true);

             builder.Property(p => p.LoginId)
            .IsRequired(true);


            builder.ToTable("Medico");
        }
    }
}
