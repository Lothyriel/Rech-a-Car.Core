using Dominio.PessoaModule.ClienteModule;
using Dominio.Shared;
using Infra.DAO.Shared;
using System;
using System.Collections.Generic;

namespace Infra.DAO.PessoaModule
{
    public class ClienteDAO : DAO<ICliente>, IClienteRepository
    {
        public IEntidadeRepository<ClientePF> RepositorioClientePF => new ClientePFDAO();
        public IClientePJRepository RepositorioClientePJ => new ClientePJDAO();

        public override void Inserir(ICliente cliente)
        {
            if (cliente is ClientePF pF)
                RepositorioClientePF.Inserir(pF);
            else if (cliente is ClientePJ pJ)
                RepositorioClientePJ.Inserir(pJ);
            else
                throw new ArgumentException();
        }
        public override void Editar(int id, ICliente cliente)
        {
            if (cliente is ClientePF pF)
                RepositorioClientePF.Editar(cliente.Id, pF);
            else if (cliente is ClientePJ pJ)
                RepositorioClientePJ.Editar(cliente.Id, pJ);
            else
                throw new ArgumentException();
        }
        public override List<ICliente> Registros => TodosRegistros();

        IEntidadeRepository<ClientePF> IClienteRepository.RepositorioClientePF => throw new NotImplementedException();


        private List<ICliente> TodosRegistros()
        {
            List<ICliente> Clientes = new();
            Clientes.AddRange(RepositorioClientePF.Registros);
            Clientes.AddRange(RepositorioClientePJ.Registros);
            return Clientes;
        }
        public override void Excluir(int id, Type tipo = null)
        {
            if (tipo.IsAssignableFrom(typeof(ClientePF)))
                RepositorioClientePF.Excluir(id);
            else if (tipo.IsAssignableFrom(typeof(ClientePJ)))
                RepositorioClientePJ.Excluir(id);
            else
                throw new ArgumentException();
        }
        public override ICliente GetById(int id, Type tipo)
        {
            if (tipo.IsAssignableFrom(typeof(ClientePF)))
                return RepositorioClientePF.GetById(id);
            else if (tipo.IsAssignableFrom(typeof(ClientePJ)))
                return RepositorioClientePJ.GetById(id);
            else
                throw new ArgumentException();
        }
        public override bool Existe(int id, Type tipo)
        {
            if (tipo.IsAssignableFrom(typeof(ClientePF)))
                return RepositorioClientePF.Existe(id);
            else if (tipo.IsAssignableFrom(typeof(ClientePJ)))
                return RepositorioClientePJ.Existe(id);
            else
                throw new ArgumentException();
        }
    }
}
