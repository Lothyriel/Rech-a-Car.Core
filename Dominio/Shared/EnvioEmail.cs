using System.IO;

namespace Dominio.Shared
{
    public abstract class EnvioEmail
    {
        public EnvioEmail(MemoryStream streamAttachment)
        {
            StreamAttachment = streamAttachment;
        }
        public MemoryStream StreamAttachment { get; }
        public int Id { get; set; }
    }
}