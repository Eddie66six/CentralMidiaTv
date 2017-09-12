using CentralMidiaTv.Dominio._Comum.Enum;

namespace CentralMidiaTv.Dominio._Comum.Entidade
{
    public class Contato
    {
        public int IdContato { get; private set; }
        public ETipoContato TipoContato { get; private set; }
        public string Descricao { get; private set; }
        public int? IdFuncionario { get; private set; }
        public Funcionario.Entidade.Funcionario Funcionario { get; private set; }
        public int? IdCliente { get; private set; }
        public Cliente.Entidade.Cliente Cliente { get; private set; }
    }
}
