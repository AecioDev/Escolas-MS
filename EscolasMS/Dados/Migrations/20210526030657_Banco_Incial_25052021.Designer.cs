﻿// <auto-generated />
using System;
using EscolaMS_Dados.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EscolaMS_Dados.Migrations
{
    [DbContext(typeof(SqlServerContext))]
    [Migration("20210526030657_Banco_Incial_25052021")]
    partial class Banco_Incial_25052021
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EscolaMS_Domain.Entities.Aluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AlunoId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("CPF");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataNascimento");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Nome");

                    b.Property<string>("NumeroCertidaoNova")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("NumeroCertidaoNova");

                    b.Property<int>("ResponsavelId")
                        .HasColumnType("int")
                        .HasColumnName("ResponsavelId");

                    b.HasKey("AlunoId")
                        .HasName("PK_Alunos");

                    b.HasIndex("ResponsavelId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("EscolaMS_Domain.Entities.Responsavel", b =>
                {
                    b.Property<int>("ResponsavelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ResponsavelId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("CPF");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataNascimento");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Nome");

                    b.HasKey("ResponsavelId")
                        .HasName("PK_Responsavel");

                    b.ToTable("RESPONSAVEL");
                });

            modelBuilder.Entity("EscolaMS_Domain.Entities.Aluno", b =>
                {
                    b.HasOne("EscolaMS_Domain.Entities.Responsavel", "Responsavel")
                        .WithMany("Alunos")
                        .HasForeignKey("ResponsavelId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Responsavel");
                });

            modelBuilder.Entity("EscolaMS_Domain.Entities.Responsavel", b =>
                {
                    b.Navigation("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}