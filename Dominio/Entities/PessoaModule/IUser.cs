using System.Drawing;

namespace Dominio.PessoaModule
{
    internal interface IUser
    {
        string Usuario { get; set; }
        Image Foto { get; set; }
    }
}