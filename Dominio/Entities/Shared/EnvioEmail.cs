using System.IO;

namespace Dominio.Shared
{
    public abstract class EnvioEmail : Entidade
    {
        public EnvioEmail(MemoryStream streamAttachment)
        {
            StreamAttachment = streamAttachment;
        }
        public MemoryStream StreamAttachment { get; }
    }
}