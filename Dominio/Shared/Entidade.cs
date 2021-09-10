namespace Dominio.Shared
{
    public abstract class Entidade : IControlavel
    {
        public int Id { get; set; }
        public abstract string Validar();
        public override bool Equals(object obj)
        {
            return obj != null && obj.GetType() == GetType() && Id == ((Entidade)obj).Id;
        }
        public override int GetHashCode()
        {
            return 2108858624 ^ Id.GetHashCode() * Validar().GetHashCode();
        }
    }
}
