using Aplicacao.Shared;
using Autofac;
using AutoMapper;
using DependencyInjector;
using Dominio.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Web_API.Models_View.Shared;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class EntidadeController<TEntidade, TListViewModel, TDetailsViewModel, TCreateViewModel, TEditViewModel> :
        ControllerBase where TEntidade : IEntidade where TCreateViewModel : EntidadeCreateViewModel where TEditViewModel : EntidadeEditViewModel
    {
        private readonly EntidadeAppServices<TEntidade> AppService;
        private readonly IMapper Mapper;

        public EntidadeController()
        {
            AppService = DependencyInjection.Container.Resolve<EntidadeAppServices<TEntidade>>();
            Mapper = ConfigureMapper().CreateMapper();
        }

        protected abstract MapperConfiguration ConfigureMapper();

        [HttpGet]
        public List<TListViewModel> GetAll()
        {
            var entidades = AppService.Registros;

            return Mapper.Map<List<TListViewModel>>(entidades);
        }

        [HttpGet("{id:int}")]
        public ActionResult<TDetailsViewModel> Get(int id)
        {
            var entidade = AppService.GetById(id);

            if (entidade == null)
                return NotFound(id);

            var viewModel = Mapper.Map<TDetailsViewModel>(entidade);

            return Ok(viewModel);
        }

        [HttpPost]
        public ActionResult<TCreateViewModel> Post(TCreateViewModel viewModel)
        {
            var tarefa = Mapper.Map<TEntidade>(viewModel);

            if (AppService.Inserir(tarefa).Resultado == EnumResultado.Sucesso)
            {
                return CreatedAtAction(nameof(Post), viewModel);
            }

            return NoContent();
        }

        [HttpPut("{id:int}")]
        public ActionResult<TEditViewModel> Put(int id, TEditViewModel viewModel)
        {
            if (id != viewModel.Id)
                return BadRequest();

            TEntidade newEntidade = Mapper.Map<TEntidade>(viewModel);

            if (AppService.Editar(id, newEntidade).Resultado == EnumResultado.Sucesso)
            {
                return Ok(viewModel);
            }

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Id não pode ser menor que 0");

            if (AppService.Excluir(id))
            {
                return Ok(id);
            }

            return NoContent();
        }
    }
}