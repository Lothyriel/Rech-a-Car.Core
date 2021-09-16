namespace Dominio.Shared
{
    public interface IEntidade
    {
        int Id { get; set; }

        string Validar();
    }
}
