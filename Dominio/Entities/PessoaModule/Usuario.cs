using System.Drawing;

namespace Dominio.PessoaModule
{
    internal interface Usuario
    {
        string Usuario { get; set; }
        Image Foto { get; set; }
    }
}