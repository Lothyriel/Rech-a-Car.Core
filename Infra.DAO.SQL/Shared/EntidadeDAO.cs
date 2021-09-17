using Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace Infra.DAO.Shared
{
    public abstract class EntidadeDAO<T> : DAO<T> where T : IEntidade
    {
        public abstract string sqlSelecionarPorId { get; }
        public abstract string sqlSelecionarTodos { get; }
        public abstract string sqlInserir { get; }
        public abstract string sqlEditar { get; }
        public abstract string sqlExcluir { get; }
        public abstract string sqlExists { get; }
        public override T GetById(int id, Type tipo = null)
        {
            return Db.Get(sqlSelecionarPorId, ConverterEmEntidade, Db.AdicionarParametro("ID", id));
        }
        public override void Inserir(T entidade)
        {
            entidade.Id = Db.Insert(sqlInserir, ObterParametrosRegistro(entidade));
        }
        public override void Editar(int id, T entidade)
        {
            entidade.Id = id;
            Db.Update(sqlEditar, ObterParametrosRegistro(entidade));
        }
        public override void Excluir(int id, Type tipo = null)
        {
            Db.Delete(sqlExcluir, Db.AdicionarParametro("ID", id));
        }
        public override bool Existe(int id, Type tipo = null)
        {
            return Db.Exists(sqlExists, Db.AdicionarParametro("ID", id));
        }
        public override List<T> Registros => Db.GetAll(sqlSelecionarTodos, ConverterEmEntidade);
        public abstract T ConverterEmEntidade(IDataReader reader);
        public abstract Dictionary<string, object> ObterParametrosRegistro(T entidade);
    }
}