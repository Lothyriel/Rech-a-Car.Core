using Dominio.Entities.PessoaModule.Condutor;

namespace Infra.DAO.ORM.Repositories
{
    public class DadosCondutorORM : BaseORM<DadosCondutor>
    {
        public DadosCondutorORM(Rech_a_carDbContext context) : base(context)
        {
        }
    }
}
