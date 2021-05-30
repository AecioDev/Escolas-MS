using EscolaMS_Dados.Context;
using EscolaMS_Domain.Entities;
using EscolaMS_Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EscolaMS_Dados.Repositories
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        //Aqui eu crio as consultas específicas para essa entidade.
        private readonly SqlServerContext _Db;
        public AlunoRepositorio(SqlServerContext dbContext)
        {
            _Db = dbContext;
        }

        public void Add(Aluno obj)
        {
            _Db.Set<Aluno>().Add(obj);
            _Db.SaveChanges();
        }

        public void Update(Aluno obj)
        {
            _Db.Entry(obj).State = EntityState.Modified;
            _Db.SaveChanges();
        }

        public IEnumerable<Aluno> GetAll()
        {
            return _Db.Set<Aluno>()
                .Include(r => r.Responsavel)
                .ToList();
        }

        public Aluno GetById(int id)
        {
            return _Db.Set<Aluno>().Find(id);
        }

        public void Remove(Aluno obj)
        {
            _Db.Set<Aluno>().Remove(obj);
            _Db.SaveChanges();
        }

        public void Dispose()
        {
            _Db.Dispose();
        }

        public Aluno GetAlunoByResp(int id)
        {
            return _Db.Set<Aluno>().Where(a => a.ResponsavelId == id).FirstOrDefault();
        }
    }
}
