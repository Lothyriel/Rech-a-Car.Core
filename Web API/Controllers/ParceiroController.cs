using Aplicacao.CupomModule;
using Aplicacao.Shared;
using AutoMapper;
using Dominio.ParceiroModule;
using Web_API.Models_View;

namespace Web_API.Controllers
{
    public class ParceiroController : EntidadeController<Parceiro, ParceiroListViewModel, ParceiroDetailsViewModel, ParceiroCreateViewModel, ParceiroEditViewModel>
    {
        protected override MapperConfiguration ConfigureMapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Parceiro, ParceiroListViewModel>();

                cfg.CreateMap<Parceiro, ParceiroDetailsViewModel>();

                cfg.CreateMap<ParceiroCreateViewModel, Parceiro>();

                cfg.CreateMap<ParceiroEditViewModel, Parceiro>();
            });
        }

        protected override EntidadeAppServices<Parceiro> GetServices()
        {
            return new ParceiroAppServices();
        }
    }
}
