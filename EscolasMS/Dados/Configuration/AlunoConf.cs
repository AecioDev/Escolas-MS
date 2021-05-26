using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EscolaMS_Domain.Entities;

namespace EscolaMS_Dados.Configuration
{
    public class AlunoConf : IEntityTypeConfiguration<Aluno>
    {        
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("ALUNOS");
            builder.HasKey(a => a.AlunoId).HasName("PK_Alunos");
            builder.Property(a => a.AlunoId).HasColumnName("AlunoId").ValueGeneratedOnAdd();
            builder.Property(a => a.Nome).HasColumnName("Nome").HasColumnType("varchar").HasMaxLength(100);
            builder.Property(a => a.DataNascimento).HasColumnName("DataNascimento");
            builder.Property(a => a.NumeroCertidaoNova).HasColumnName("NumeroCertidaoNova").HasColumnType("varchar").HasMaxLength(50);
            builder.Property(a => a.CPF).HasColumnName("CPF").HasColumnType("varchar").HasMaxLength(11); //01321302118
            builder.Property(a => a.ResponsavelId).HasColumnName("ResponsavelId");

            builder.HasOne(a => a.Responsavel).WithMany(d => d.Alunos)
            .HasForeignKey(a => a.ResponsavelId)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
