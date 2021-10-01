using Dominio.Shared;
using System;

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
