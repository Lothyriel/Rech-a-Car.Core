using Controladores.Shared;
using Dominio.PessoaModule.ClienteModule;
using System;
using System.Collections.Generic;

namespace Controladores.PessoaModule
{
    public class ControladorCliente : Controlador<ICliente>
    {
        private ControladorClientePF ControladorPF = new ControladorClientePF();
        private ControladorClientePJ ControladorPJ = new ControladorClientePJ();

        public override void Inserir(ICliente cliente)
        {
            if (cliente is ClientePF)
                ControladorPF.Inserir((ClientePF)cliente);
            else if (cliente is ClientePJ)
                ControladorPJ.Inserir((ClientePJ)cliente);
            else
                throw new ArgumentException();
        }
        public override void Editar(int id, ICliente cliente)
        {
            if (cliente is ClientePF)
                ControladorPF.Editar(cliente.Id, (ClientePF)cliente);
            else if (cliente is ClientePJ)
                ControladorPJ.Editar(cliente.Id, (ClientePJ)cliente);
            else
                throw new ArgumentException();
        }
        protected override List<ICliente> ObterRegistros()
        {
            List<ICliente> Clientes = new List<ICliente>();
            Clientes.AddRange(ControladorPF.Registros);
            Clientes.AddRange(ControladorPJ.Registros);
            return Clientes;
        }
        public override void Excluir(int id, Type tipo = null)
        {
            if (tipo.IsAssignableFrom(typeof(ClientePF)))
                ControladorPF.Excluir(id);
            else if (tipo.IsAssignableFrom(typeof(ClientePJ)))
                ControladorPJ.Excluir(id);
            else
                throw new ArgumentException();
        }
        public override ICliente GetById(int id, Type tipo)
        {
            if (tipo.IsAssignableFrom(typeof(ClientePF)))
                return ControladorPF.GetById(id);
            else if (tipo.IsAssignableFrom(typeof(ClientePJ)))
                return ControladorPJ.GetById(id);
            else
                throw new ArgumentException();
        }
    }
}
