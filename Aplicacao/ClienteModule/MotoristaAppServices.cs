using Aplicacao.Shared;
using Dominio.PessoaModule;
using Dominio.Repositories;
using Dominio.Shared;
using System;

namespace Aplicacao.ClienteModule
{
    public class MotoristaAppServices : EntidadeAppServices<Motorista>
    {
        public override IRepository<Motorista> Repositorio { get; }

        public ICnhRepository CnhRepository { get; }

        public MotoristaAppServices(IRepository<Motorista> repositorio)
        {
            Repositorio = repositorio;
        }

        public override ResultadoOperacao Inserir(Motorista entidade)
        {
            var inserir = base.Inserir(entidade);
            if (inserir.Resultado == EnumResultado.Falha)
                return inserir;

            CnhRepository.Inserir(entidade.Cnh);

            return inserir;
        }

        public override ResultadoOperacao Editar(int id, Motorista entidade)
        {
            var edicao = base.Editar(id, entidade);
            if (edicao.Resultado == EnumResultado.Falha)
                return edicao;

            CnhRepository.Editar(id, entidade.Cnh);

            return edicao;
        }

        public override void Excluir(int id, Type tipo = null)
        {
            base.Excluir(id, tipo);
        }
    }
}
