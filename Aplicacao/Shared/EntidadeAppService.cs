using Dominio.Shared;
using System.Collections.Generic;

namespace Aplicacao.Shared
{
    public abstract class EntidadeAppService<T> : IEntidadeRepository<T> where T : IEntidade
    {
        public abstract void Editar(int id, T entidade);
        public abstract void Excluir(int id);
        public abstract bool Existe(int id);
        public abstract List<T> FiltroGenerico(string filtro);
        public abstract T GetById(int id);
        public abstract void Inserir(T entidade);
        public abstract List<T> TodosRegistros();
    }
}
