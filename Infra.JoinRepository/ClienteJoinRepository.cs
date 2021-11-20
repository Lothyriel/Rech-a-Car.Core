using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;
using Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Join.ClienteModule
{
    public class ClienteJoinRepository : IRepository<Cliente>
    {
        public IClientePFRepository RepositorioClientePF { get; }
        public IClientePJRepository RepositorioClientePJ { get; }

        public ClienteJoinRepository(IClientePFRepository repositorioClientePF, IClientePJRepository repositorioClientePJ)
        {
            RepositorioClientePF = repositorioClientePF;
            RepositorioClientePJ = repositorioClientePJ;
        }
        public bool Inserir(Cliente cliente)
        {
            if (cliente is ClientePF pF)
                return RepositorioClientePF.Inserir(pF);
            else if (cliente is ClientePJ pJ)
                return RepositorioClientePJ.Inserir(pJ);
            else
                throw new ArgumentException();
        }
        public bool Editar(int id, Cliente cliente)
        {
            if (cliente is ClientePF pF)
                return RepositorioClientePF.Editar(cliente.Id, pF);
            else if (cliente is ClientePJ pJ)
                return RepositorioClientePJ.Editar(cliente.Id, pJ);
            else
                throw new ArgumentException();
        }
        public List<Cliente> Registros => TodosRegistros();
        private List<Cliente> TodosRegistros()
        {
            List<Cliente> Clientes = new();
            Clientes.AddRange(RepositorioClientePF.Registros);
            Clientes.AddRange(RepositorioClientePJ.Registros);
            return Clientes;
        }
        public bool Excluir(int id, Type tipo = null)
        {
            if (tipo.IsAssignableFrom(typeof(ClientePF)))
                return RepositorioClientePF.Excluir(id);
            else if (tipo.IsAssignableFrom(typeof(ClientePJ)))
                return RepositorioClientePJ.Excluir(id);
            else
                throw new ArgumentException();
        }
        public Cliente GetById(int id, Type tipo)
        {
            if (tipo.IsAssignableFrom(typeof(ClientePF)))
                return RepositorioClientePF.GetById(id);
            else if (tipo.IsAssignableFrom(typeof(ClientePJ)))
                return RepositorioClientePJ.GetById(id);
            else
                throw new ArgumentException();
        }
        public bool Existe(int id, Type tipo)
        {
            if (tipo.IsAssignableFrom(typeof(ClientePF)))
                return RepositorioClientePF.Existe(id);
            else if (tipo.IsAssignableFrom(typeof(ClientePJ)))
                return RepositorioClientePJ.Existe(id);
            else
                throw new ArgumentException();
        }
        public bool ExisteDocumento(string documento, Type tipo)
        {
            if (tipo.IsAssignableFrom(typeof(ClientePF)))
                return RepositorioClientePF.ExisteDocumento(documento);
            else if (tipo.IsAssignableFrom(typeof(ClientePJ)))
                return RepositorioClientePJ.ExisteDocumento(documento);
            else
                throw new ArgumentException();
        }
        public List<Cliente> FiltroGenerico(string filtro)
        {
            var palavras = filtro.Split(' ');

            return Registros.Where(i => palavras.Any(p => i.ToString().IndexOf(p, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
        }
    }
}
