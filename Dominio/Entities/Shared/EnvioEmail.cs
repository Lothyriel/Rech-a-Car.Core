using System;
using System.IO;

namespace Dominio.Shared
{
    public abstract class EnvioEmail : Entidade
    {
        public DateTime? DataEnvio { get; set; }
        public abstract MemoryStream StreamAttachment { get; }
    }
}