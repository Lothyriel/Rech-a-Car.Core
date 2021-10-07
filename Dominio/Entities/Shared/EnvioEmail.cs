using System;
using System.IO;

namespace Dominio.Shared
{
    public abstract class EnvioEmail : Entidade
    {
        public DateTime? DataEnvio { get; set; }
        public EnvioEmail(MemoryStream streamAttachment)
        {
            StreamAttachment = streamAttachment;
        }
        public MemoryStream StreamAttachment { get; }
    }
}