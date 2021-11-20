using System.Collections.Generic;
using Web_API.Models_View.Shared;

namespace Web_API.Models_View
{
    public class ParceiroListViewModel : EntidadeListViewModel
    {
        public string Nome { get; set; }
    }

    public class ParceiroDetailsViewModel : EntidadeDetailsViewModel
    {
        public string Nome { get; set; }
        public List<CupomListViewModel> Cupons { get; set; }
    }

    public class ParceiroCreateViewModel : EntidadeCreateViewModel
    {
        public string Nome { get; set; }
    }

    public class ParceiroEditViewModel : EntidadeEditViewModel
    {
        public string Nome { get; set; }
    }
}
