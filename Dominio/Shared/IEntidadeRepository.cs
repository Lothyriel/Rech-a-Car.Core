using System.Collections.Generic;

namespace Dominio.Shared
{
    public interface IEntidadeRepository<T> where T : IEntidade
    {
        void Inserir(T entidade);
        void Editar(int id, T entidade);
        void Excluir(int id);
        bool Existe(int id);
        T GetById(int id);
        List<T> TodosRegistros();
        List<T> FiltroGenerico(string filtro);
    }
}
