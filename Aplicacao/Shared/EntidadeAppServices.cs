using Dominio.Shared;
using System.Collections.Generic;

namespace Aplicacao.Shared
{
    public abstract class EntidadeAppServices<T> where T : IEntidade
    {
        public abstract IEntidadeRepository<T> Repositorio { get; }
        public virtual ResultadoOperacao Inserir(T entidade)
        {
            var validacao = entidade.Validar();

            if (validacao != string.Empty)
            {
                return new ResultadoOperacao(validacao, EnumResultado.Falha);
            }
            Repositorio.Inserir(entidade);
            return new ResultadoOperacao("Inserido com sucesso!", EnumResultado.Sucesso);
        }
        public virtual ResultadoOperacao Editar(int id, T entidade)
        {
            var validacao = entidade.Validar();

            if (validacao != string.Empty)
            {
                return new ResultadoOperacao(validacao, EnumResultado.Falha);
            }
            Repositorio.Editar(id, entidade);
            return new ResultadoOperacao("Editado com sucesso!", EnumResultado.Falha);
        }
        public virtual void Excluir(int id)
        {
            Repositorio.Excluir(id);
        }
        public bool Existe(int id)
        {
            return Repositorio.Existe(id);
        }
        public List<T> FiltroGenerico(string filtro)
        {
            return Repositorio.FiltroGenerico(filtro);
        }
        public T GetById(int id)
        {
            return Repositorio.GetById(id);
        }
        public List<T> TodosRegistros()
        {
            return Repositorio.Registros;
        }

    }
    public enum EnumResultado { Sucesso, Falha }
    public class ResultadoOperacao
    {
        public string Mensagem;
        public EnumResultado Resultado;
        public ResultadoOperacao(string mensagem, EnumResultado resultado)
        {
            Mensagem = mensagem;
            Resultado = resultado;
        }
    }
}