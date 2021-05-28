using EscolaMS_Dados.Context;
using EscolaMS_Domain.Entities;
using EscolaMS_Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EscolaMS_Dados.Repositories
{
    public class ResponsavelRepositorio : IResponsavelRepositorio
    {
        //Aqui eu crio as consultas específicas para essa entidade.
        private readonly SqlServerContext _Db;
        public ResponsavelRepositorio(SqlServerContext dbContext)
        {
            _Db = dbContext;
        }

        public void Add(Responsavel obj)
        {
            _Db.Set<Responsavel>().Add(obj);
            _Db.SaveChanges();
        }
        public void Update(Responsavel obj)
        {
            _Db.Entry(obj).State = EntityState.Modified;
            _Db.SaveChanges();
        }

        public IEnumerable<Responsavel> GetAll()
        {
            return _Db.Set<Responsavel>().ToList();
        }

        public Responsavel GetById(int id)
        {
            return _Db.Set<Responsavel>().Find(id);
        }

        public void Remove(Responsavel obj)
        {
            _Db.Set<Responsavel>().Remove(obj);
            _Db.SaveChanges();
        }

        public void Dispose()
        {
            _Db.Dispose();
        }
    }
}
