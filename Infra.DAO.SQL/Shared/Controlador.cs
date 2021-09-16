using Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controladores.Shared
{
    public abstract class DAO<T> where T : IEntidade
    {
        public List<T> Registros => ObterRegistros();
        public abstract void Inserir(T entidade);
        public abstract void Editar(int id, T entidade);
        public abstract void Excluir(int id, Type tipo = null);
        public abstract T GetById(int id, Type tipo = null);
        protected abstract List<T> ObterRegistros();
        public List<T> FiltroTunado(string filtro)
        {
            var palavras = filtro.Split(' ');

            return Registros.Where(i => palavras.Any(p => i.ToString().IndexOf(p, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
        }
    }
}