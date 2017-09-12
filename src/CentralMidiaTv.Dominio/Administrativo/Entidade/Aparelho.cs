using CentralMidiaTv.Dominio.Administrativo.Enum;
using System.Collections.Generic;

namespace CentralMidiaTv.Dominio.Administrativo.Entidade
{
    public class Aparelho
    {
        protected Aparelho()
        {
            Trocas = new List<TrocaAparelho>();
        }
        public int IdAparelho { get; private set; }
        public string Descricao { get; private set; }
        public ETipoAparelho TipoAparelho { get; private set; }
        public virtual List<TrocaAparelho> Trocas { get; private set; }
        public int IdFuncionarioCadastro { get; private set; }
        public Funcionario.Entidade.Funcionario FuncionarioCadastro { get; private set; }
    }
}
