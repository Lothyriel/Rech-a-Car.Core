using Dominio.Shared;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.DAO.ORM
{
    public class BaseORM<T> : IRepository<T> where T : Entidade
    {
        protected Rech_a_carDbContext Context { get; init; }

        public BaseORM(Rech_a_carDbContext context)
        {
            Context = context;
        }
        public List<T> Registros => Context.Set<T>().ToList();

        public T GetById(int id, Type tipo = null)
        {
            return Context.Set<T>().Find(id);
        }
        public void Inserir(T entidade)
        {
            Context.Set<T>().Add(entidade);
            Context.SaveChanges();
        }
        public void Editar(int id, T entidade)
        {
            entidade.Id = id;
            Context.Update(entidade);
            Context.SaveChanges();
        }
        public bool Excluir(int id, Type tipo = null)
        {
            var entidade = GetById(id);
            try
            {
                Context.Remove(entidade);
                Context.SaveChanges();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
        public bool Existe(int id, Type tipo = null)
        {
            return Context.Set<T>().Where(x => x.Id == id).Any();
        }
        public List<T> FiltroGenerico(string filtro)
        {
            var palavras = filtro.Split(' ');
            return Context.Set<T>().ToList().Where(i => palavras.Any(p => i.ToString().Contains(p, StringComparison.OrdinalIgnoreCase))).ToList();
        }
    }
}
