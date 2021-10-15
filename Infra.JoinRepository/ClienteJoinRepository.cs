using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;
using Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Join.ClienteModule
{
    public class ClienteJoinRepository : IRepository<ICliente>
    {
        public IClientePFRepository RepositorioClientePF { get; }
        public IClientePJRepository RepositorioClientePJ { get; }

        public ClienteJoinRepository(IClientePFRepository repositorioClientePF, IClientePJRepository repositorioClientePJ)
        {
            RepositorioClientePF = repositorioClientePF;
            RepositorioClientePJ = repositorioClientePJ;
        }
        public void Inserir(ICliente cliente)
        {
            if (cliente is ClientePF pF)
                RepositorioClientePF.Inserir(pF);
            else if (cliente is ClientePJ pJ)
                RepositorioClientePJ.Inserir(pJ);
            else
                throw new ArgumentException();
        }
        public void Editar(int id, ICliente cliente)
        {
            if (cliente is ClientePF pF)
                RepositorioClientePF.Editar(cliente.Id, pF);
            else if (cliente is ClientePJ pJ)
                RepositorioClientePJ.Editar(cliente.Id, pJ);
            else
                throw new ArgumentException();
        }
        public List<ICliente> Registros => TodosRegistros();
        private List<ICliente> TodosRegistros()
        {
            List<ICliente> Clientes = new();
            Clientes.AddRange(RepositorioClientePF.Registros);
            Clientes.AddRange(RepositorioClientePJ.Registros);
            return Clientes;
        }
        public void Excluir(int id, Type tipo = null)
        {
            if (tipo.IsAssignableFrom(typeof(ClientePF)))
                RepositorioClientePF.Excluir(id);
            else if (tipo.IsAssignableFrom(typeof(ClientePJ)))
                RepositorioClientePJ.Excluir(id);
            else
                throw new ArgumentException();
        }
        public ICliente GetById(int id, Type tipo)
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
                return RepositorioClientePF.ExisteDocumento(documento, tipo);
            else if (tipo.IsAssignableFrom(typeof(ClientePJ)))
                return RepositorioClientePJ.ExisteDocumento(documento, tipo);
            else
                throw new ArgumentException();
        }
        public List<ICliente> FiltroGenerico(string filtro)
        {
            var palavras = filtro.Split(' ');

            return Registros.Where(i => palavras.Any(p => i.ToString().IndexOf(p, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
        }
    }
}
