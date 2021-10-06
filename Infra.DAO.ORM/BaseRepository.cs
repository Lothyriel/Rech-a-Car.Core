using Dominio.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.DAO.ORM
{
    public class BaseRepository<T> : rech_a_carDbContext, IRepository<T> where T : Entidade
    {
        public List<T> Registros => Set<T>().ToList();

        public void Editar(int id, T entidade)
        {
            Entry(entidade).State = EntityState.Modified;
            SaveChanges();
        }

        public void Excluir(int id, Type tipo = null)
        {
            var entidade = GetById(id);
            Set<T>().Remove(entidade);
            SaveChanges();
        }

        public bool Existe(int id, Type tipo = null)
        {
            return Set<T>().Find(id) != null;
        }

        public List<T> FiltroGenerico(string filtro)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id, Type tipo = null)
        {
            return Set<T>().Find(id);
        }

        public void Inserir(T entidade)
        {
            Set<T>().Add(entidade);
            SaveChanges();
        }
    }
}
