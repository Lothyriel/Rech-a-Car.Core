using System;
using System.Collections.Generic;

namespace Dominio.Shared
{
    public interface IEntidadeRepository<T> where T : IEntidade
    {
        void Inserir(T entidade);
        void Editar(int id, T entidade);
        void Excluir(int id, Type tipo = null);
        bool Existe(int id, Type tipo = null);
        T GetById(int id, Type tipo = null);
        List<T> TodosRegistros { get; }

        List<T> FiltroGenerico(string filtro);
    }
}
