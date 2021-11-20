using Web_API.Models_View.Shared;

namespace Web_API.Models
{
    public class FuncionarioListViewModel : EntidadeListViewModel
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Cargo { get; set; }
        public string Usuario { get; set; }
    }

    public class FuncionarioDetailsViewModel : EntidadeDetailsViewModel
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Cargo { get; set; }
        public string Endereço { get; set; }
        public string Usuario { get; set; }
        public string Documento { get; set; }
    }

    public class FuncionarioCreateViewModel : EntidadeCreateViewModel
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Cargo { get; set; }
        public string Endereço { get; set; }
        public string Usuario { get; set; }
        public string Documento { get; set; }
    }

    public class FuncionarioEditViewModel : EntidadeEditViewModel
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Cargo { get; set; }
        public string Endereço { get; set; }
        public string Usuario { get; set; }
        public string Documento { get; set; }
    }
}