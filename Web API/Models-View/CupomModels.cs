using System;
using System.ComponentModel.DataAnnotations;
using Web_API.Models_View.Shared;

namespace Web_API.Models_View
{
    public class CupomListViewModel : EntidadeListViewModel
    {
        public string Nome { get; set; }
        public DateTime DataValidade { get; set; }
        public decimal ValorMinimo { get; set; }
    }

    public class CupomDetailsViewModel : EntidadeDetailsViewModel
    {
        public string Nome { get; set; }
        public int ValorPercentual { get; set; }
        public decimal ValorFixo { get; set; }
        public DateTime DataValidade { get; set; }
        public string ParceiroNome { get; set; }
        public int ParceiroId { get; set; }
        public decimal ValorMinimo { get; set; }
        public int Usos { get; set; }
    }

    public class CupomCreateViewModel : EntidadeCreateViewModel
    {
        [Required(ErrorMessage = "Campo nome é obrigatório.")]
        public string Nome { get; set; }
        public int ValorPercentual { get; set; }
        public decimal ValorFixo { get; set; }
        public DateTime DataValidade { get; set; }
        public int ParceiroId { get; set; }
        public decimal ValorMinimo { get; set; }
    }
    public class CupomEditViewModel : EntidadeEditViewModel
    {
        [Required(ErrorMessage = "Campo nome é obrigatório.")]
        public string Nome { get; set; }
        public int ValorPercentual { get; set; }
        public decimal ValorFixo { get; set; }
        public DateTime DataValidade { get; set; }
        public int ParceiroId { get; set; }
        public decimal ValorMinimo { get; set; }
    }
}
