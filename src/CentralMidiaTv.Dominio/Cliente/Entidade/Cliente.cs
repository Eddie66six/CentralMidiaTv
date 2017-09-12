using CentralMidiaTv.Dominio._Comum.Entidade;
using System.Collections.Generic;

namespace CentralMidiaTv.Dominio.Cliente.Entidade
{
    public class Cliente
    {
        protected Cliente()
        {
            Contatos = new List<Contato>();
            Pontos = new List<Ponto>();
        }

        public int IdCliente { get; private set; }
        public string Nome { get; private set; }
        public virtual List<Contato> Contatos { get; private set; }
        public virtual List<Ponto> Pontos { get; private set; }
        public int IdCategoriaCliente { get; private set; }
        public CategoriaCliente CategoriaCliente { get; private set; }
    }
}
