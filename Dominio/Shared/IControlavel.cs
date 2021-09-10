namespace Dominio.Shared
{
    public interface IControlavel
    {
        int Id { get; set; }

        string Validar();
    }
}
