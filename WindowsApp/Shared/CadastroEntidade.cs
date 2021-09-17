using Aplicacao.Shared;
using Dominio.Shared;
using System.Windows.Forms;

namespace WindowsApp.Shared
{
    public abstract class CadastroEntidade<T> : Form, IEditavel where T : IEntidade
    {
        public T entidade { get; set; }
        public abstract EntidadeAppServices<T> Services { get; }

        public virtual CadastroEntidade<T> Inserir() { return this; }
        public abstract T GetNovaEntidade();
        public IEditavel ConfigurarEditar(T entidade)
        {
            this.entidade = entidade;
            return Editar();
        }

        protected abstract IEditavel Editar();
        protected bool Salva(bool mostraSucesso = true)
        {
            var validacaoCampos = ValidacaoCampos();

            if (validacaoCampos != string.Empty)
            {
                MessageBox.Show(validacaoCampos);
                return false;
            }

            T entidade = GetNovaEntidade();
            ResultadoOperacao resultado;
            if (this.entidade == null)
                resultado = Services.Inserir(entidade);
            else
            {
                AdicionarDependencias(entidade);
                resultado = Services.Editar(this.entidade.Id, entidade);
            }

            if (mostraSucesso)
                MessageBox.Show(resultado.Mensagem, resultado.Resultado.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        protected virtual void AdicionarDependencias(T entidade)
        {
            return;//if entidade tem chaves estrangeiras adicionarDependencias else return;
        }

        protected virtual string ValidacaoCampos() { return string.Empty; }
    }
}