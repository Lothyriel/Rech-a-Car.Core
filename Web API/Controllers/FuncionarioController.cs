using Aplicacao.FuncionarioModule;
using Aplicacao.Shared;
using AutoMapper;
using Dominio.PessoaModule;
using Web_API.Models;

namespace Web_API.Controllers
{
    public class FuncionarioController : EntidadeController<Funcionario, FuncionarioListViewModel, FuncionarioDetailsViewModel, FuncionarioCreateViewModel, FuncionarioEditViewModel>
    {
        protected override MapperConfiguration ConfigureMapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Funcionario, FuncionarioListViewModel>()
                    .ForMember(dest => dest.Cargo, opt => opt.MapFrom(src => src.Cargo));

                cfg.CreateMap<Funcionario, FuncionarioDetailsViewModel>()
                    .ForMember(dest => dest.Cargo, opt => opt.MapFrom(src => (int)src.Cargo));

                cfg.CreateMap<FuncionarioCreateViewModel, Funcionario>()
                    .ForMember(dest => dest.Cargo, opt => opt.MapFrom(src => (Cargo)src.Cargo));

                cfg.CreateMap<FuncionarioEditViewModel, Funcionario>()
                    .ForMember(dest => dest.Cargo, opt => opt.MapFrom(src => (Cargo)src.Cargo));
            });
        }

        protected override EntidadeAppServices<Funcionario> GetServices()
        {
            return new FuncionarioAppServices();
        }
    }
}
