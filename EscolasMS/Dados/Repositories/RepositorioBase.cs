﻿using EscolaMS_Dados.Context;
using EscolaMS_Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EscolaMS_Dados.Repositories
{
    public class RepositorioBase<TEntity> : IDisposable, IRepositorioBase<TEntity> where TEntity : class
    {
        public readonly SqlServerContext _Db;

        public RepositorioBase(SqlServerContext dbContext)
        {
            _Db = dbContext;
        }

        public void Add(TEntity obj)
        {
            _Db.Set<TEntity>().Add(obj);
            _Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _Db.Entry(obj).State = EntityState.Modified;
            _Db.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _Db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _Db.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            _Db.Set<TEntity>().Remove(obj);
            _Db.SaveChanges();
        }

        public void Dispose()
        {
            _Db.Dispose();
        }
    }
}
