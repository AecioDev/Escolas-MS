using EscolaMS_Dados.Configuration;
using EscolaMS_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaMS_Dados.Context
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options)
           : base(options) { }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.HasDefaultSchema("dbo");
                        
            mb.ApplyConfiguration(new AlunoConf());
            mb.ApplyConfiguration(new ResponsavelConf());

        }

        //DBSets das Tabelas
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Responsavel> Responsavel { get; set; }
                
    }
}
