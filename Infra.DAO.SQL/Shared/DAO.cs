using Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAO.Shared
{
    public abstract class DAO<T> : IEntidadeRepository<T> where T : IEntidade
    {
        public abstract void Inserir(T entidade);
        public abstract void Editar(int id, T entidade);
        public abstract void Excluir(int id, Type tipo = null);
        public abstract bool Existe(int id, Type tipo = null);
        public abstract T GetById(int id, Type tipo = null);
        public abstract List<T> TodosRegistros { get; }
        public List<T> FiltroGenerico(string filtro)
        {
            var palavras = filtro.Split(' ');

            return TodosRegistros.Where(i => palavras.Any(p => i.ToString().IndexOf(p, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
        }
    }
}