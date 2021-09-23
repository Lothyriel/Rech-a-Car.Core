using Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities.PessoaModule
{
    public class Senha : Entidade
    {
        public Senha(byte[] salt, string hash)
        {
            Salt = salt;
            Hash = hash;
        }
        public byte[] Salt { get; }
        public string Hash { get; }

        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
