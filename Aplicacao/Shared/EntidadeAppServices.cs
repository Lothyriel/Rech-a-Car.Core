﻿using Dominio.Shared;
using Infra.NLogger;
using System;
using System.Collections.Generic;

namespace Aplicacao.Shared
{
    public abstract class EntidadeAppServices<T> where T : IEntidade
    {
        public abstract IRepository<T> Repositorio { get; }
        public virtual ResultadoOperacao Inserir(T entidade)
        {
            NLogger.Logger.Info($"Validando Entidade: {typeof(T).Name}");
            var validacao = entidade.Validar();
            NLogger.Logger.Info($"Validado com sucesso{(validacao != string.Empty ? ", erros: {validacao}": "")}");

            if (validacao != string.Empty)
            {
                return new ResultadoOperacao(validacao, EnumResultado.Falha);
            }
            NLogger.Logger.Info($"Inserindo Entidade: {typeof(T).Name}");
            Repositorio.Inserir(entidade);
            NLogger.Logger.Info("Inserido com sucesso");

            return new ResultadoOperacao("Inserido com sucesso!", EnumResultado.Sucesso);
        }
        public virtual ResultadoOperacao Editar(int id, T entidade)
        {
            NLogger.Logger.Info($"Validando Entidade: {typeof(T).Name}");
            var validacao = entidade.Validar();
            NLogger.Logger.Info($"Validado com sucesso{(validacao != string.Empty ? $", erros: {validacao}" : "")}");

            if (validacao != string.Empty)
            {
                return new ResultadoOperacao(validacao, EnumResultado.Falha);
            }
            NLogger.Logger.Info($"Editando Entidade: {typeof(T).Name} | ID: {id}");
            Repositorio.Editar(id, entidade);
            NLogger.Logger.Info("Editado com sucesso");
            return new ResultadoOperacao("Editado com sucesso!", EnumResultado.Sucesso);
        }
        public virtual void Excluir(int id, Type tipo = null)
        {
            NLogger.Logger.Info($"Excluindo Entidade: {typeof(T).Name} | ID: {id}");
            Repositorio.Excluir(id, tipo);
            NLogger.Logger.Info("Excluido com sucesso");
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