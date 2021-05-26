using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EscolaMS_Domain.Entities;

namespace EscolaMS_Dados.Configuration
{
    public class ResponsavelConf : IEntityTypeConfiguration<Responsavel>
    {
        public void Configure(EntityTypeBuilder<Responsavel> builder)
        {
            builder.ToTable("RESPONSAVEL");
            builder.HasKey(r => r.ResponsavelId).HasName("PK_Responsavel");
            builder.Property(r => r.ResponsavelId).HasColumnName("ResponsavelId").ValueGeneratedOnAdd();
            builder.Property(r => r.Nome).HasColumnName("Nome").HasColumnType("varchar").HasMaxLength(100);
            builder.Property(r => r.DataNascimento).HasColumnName("DataNascimento");
            builder.Property(r => r.CPF).HasColumnName("CPF").HasColumnType("varchar").HasMaxLength(11); //01321302118
        }
    }
}
