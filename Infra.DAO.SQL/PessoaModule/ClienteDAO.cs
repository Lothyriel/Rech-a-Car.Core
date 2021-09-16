using Dominio.PessoaModule.ClienteModule;
using Infra.DAO.Shared;
using System;
using System.Collections.Generic;

namespace Infra.DAO.PessoaModule
{
    public class ClienteDAO : DAO<ICliente>
    {
        private ClientePFDAO PFDAO = new();
        private ClientePJDAO PJDAO = new();

        public override void Inserir(ICliente cliente)
        {
            if (cliente is ClientePF pF)
                PFDAO.Inserir(pF);
            else if (cliente is ClientePJ pJ)
                PJDAO.Inserir(pJ);
            else
                throw new ArgumentException();
        }
        public override void Editar(int id, ICliente cliente)
        {
            if (cliente is ClientePF pF)
                PFDAO.Editar(cliente.Id, pF);
            else if (cliente is ClientePJ pJ)
                PJDAO.Editar(cliente.Id, pJ);
            else
                throw new ArgumentException();
        }
        public override List<ICliente> Registros => TodosRegistros();
        private List<ICliente> TodosRegistros()
        {
            List<ICliente> Clientes = new();
            Clientes.AddRange(PFDAO.Registros);
            Clientes.AddRange(PJDAO.Registros);
            return Clientes;
        }
        public override void Excluir(int id, Type tipo = null)
        {
            if (tipo.IsAssignableFrom(typeof(ClientePF)))
                PFDAO.Excluir(id);
            else if (tipo.IsAssignableFrom(typeof(ClientePJ)))
                PJDAO.Excluir(id);
            else
                throw new ArgumentException();
        }
        public override ICliente GetById(int id, Type tipo)
        {
            if (tipo.IsAssignableFrom(typeof(ClientePF)))
                return PFDAO.GetById(id);
            else if (tipo.IsAssignableFrom(typeof(ClientePJ)))
                return PJDAO.GetById(id);
            else
                throw new ArgumentException();
        }
        public override bool Existe(int id, Type tipo)
        {
            if (tipo.IsAssignableFrom(typeof(ClientePF)))
                return PFDAO.Existe(id);
            else if (tipo.IsAssignableFrom(typeof(ClientePJ)))
                return PJDAO.Existe(id);
            else
                throw new ArgumentException();
        }
    }
}
