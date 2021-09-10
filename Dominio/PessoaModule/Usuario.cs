using System.Drawing;

namespace Dominio.PessoaModule
{
    internal interface Usuario
    {
        string NomeUsuario { get; set; }
        Image Foto { get; set; }
    }
}