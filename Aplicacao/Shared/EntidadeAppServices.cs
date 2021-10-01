using Dominio.Shared;
using Infra.NLogger;
using System;
using System.Collections.Generic;

namespace Aplicacao.Shared
{
    public abstract class EntidadeAppServices<T> where T : IEntidade
    {
        protected abstract IRepository<T> Repositorio { get; }
        public virtual ResultadoOperacao Inserir(T entidade)
        {
            NLogger.Logger.Aqui().Debug("Validando {tipo} {entidade}", entidade.GetType().Name, entidade);
            var validacao = entidade.Validar();
            NLogger.Logger.Aqui().Info("Validação completa{resultado}", validacao != string.Empty ? $" , erros: {validacao}" : "");
            
            if (validacao != string.Empty)
            {
                return new ResultadoOperacao(validacao, EnumResultado.Falha);
            }
            NLogger.Logger.Aqui().Debug("Inserindo {tipo} {entidade}", entidade.GetType().Name, entidade);
            Repositorio.Inserir(entidade);
            NLogger.Logger.Aqui().Info("Inserido com sucesso {tipo} {entidade}", entidade.GetType().Name, entidade);

            return new ResultadoOperacao("Inserido com sucesso!", EnumResultado.Sucesso);
        }
        public virtual ResultadoOperacao Editar(int id, T entidade)
        {
            var tipo = entidade.GetType().Name;

            NLogger.Logger.Aqui().Debug("Validando {tipo} {entidade}", tipo, entidade);
            var validacao = entidade.Validar();
            NLogger.Logger.Aqui().Info("Validação completa{resultado}", validacao != string.Empty ? $" , erros: {validacao}" : "");

            if (validacao != string.Empty)
            {
                return new ResultadoOperacao(validacao, EnumResultado.Falha);
            }
            NLogger.Logger.Aqui().Debug($"Editando {{tipo}} {{entidade}} | ID: {{id{char.ToUpper(tipo[0]) + tipo.Substring(1)}}}", tipo, entidade, id);
            Repositorio.Editar(id, entidade);
            NLogger.Logger.Aqui().Info("Editado com sucesso {{tipo}} {{entidade}} | ID: {{id{char.ToUpper(tipo[0]) + tipo.Substring(1)}}}", tipo, entidade, id);
            return new ResultadoOperacao("Editado com sucesso!", EnumResultado.Sucesso);
        }
        public virtual void Excluir(int id, Type tipo = null)
        {
            var nTipo = typeof(T).Name;
            NLogger.Logger.Aqui().Debug($"Excluindo {{tipo}} | ID: {{id{char.ToUpper(nTipo[0]) + nTipo.Substring(1)}}}", nTipo, id);
            Repositorio.Excluir(id, tipo);
            NLogger.Logger.Aqui().Info("Excluido com sucesso {{tipo}} | ID: {{id{char.ToUpper(nTipo[0]) + nTipo.Substring(1)}}}", nTipo, id);
        }
        public bool Existe(int id)
        {
            return Repositorio.Existe(id);
        }
        public List<T> FiltroGenerico(string filtro)
        {
            return Repositorio.FiltroGenerico(filtro);
        }
        public T GetById(int id, Type tipo = null)
        {
            return Repositorio.GetById(id, tipo);
        }
        public List<T> Registros => Repositorio.Registros;

    }
    public enum EnumResultado { Sucesso, Falha }
    public class ResultadoOperacao
    {
        public ResultadoOperacao Append(ResultadoOperacao operacao)
        {
            Mensagem += "\n" + operacao.Mensagem;
            Resultado = operacao.Resultado;
            return this;
        }

        public string Mensagem;
        public EnumResultado Resultado;
        public ResultadoOperacao(string mensagem, EnumResultado resultado)
        {
            Mensagem = mensagem;
            Resultado = resultado;
        }
    }
}