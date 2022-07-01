
using Goclinic.Core.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Goclinic.Agendamento.Data.Mappings
{
    public class PacienteMapping : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Nome)
                .IsRequired(true);

            builder.Property(p => p.Cpf)
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

            builder.ToTable("Paciente");
        }
    }
}
