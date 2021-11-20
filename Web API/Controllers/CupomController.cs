using Aplicacao.CupomModule;
using Aplicacao.Shared;
using AutoMapper;
using Dominio.CupomModule;
using Web_API.Models_View;

namespace Web_API.Controllers
{
    public class CupomController : EntidadeController<Cupom, CupomListViewModel, CupomDetailsViewModel, CupomCreateViewModel, CupomEditViewModel>
    {
        protected override MapperConfiguration ConfigureMapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Cupom, CupomListViewModel>();

                cfg.CreateMap<Cupom, CupomDetailsViewModel>()
                    .ForMember(dest => dest.ParceiroNome, opt => opt.MapFrom(src => src.Parceiro.Nome))
                    .ForMember(dest => dest.ParceiroId, opt => opt.MapFrom(src => src.Parceiro.Id));

                cfg.CreateMap<CupomCreateViewModel, Cupom>();

                cfg.CreateMap<CupomEditViewModel, Cupom>();
            });
        }

        protected override EntidadeAppServices<Cupom> GetServices()
        {
            return new CupomAppServices();
        }
    }
}
