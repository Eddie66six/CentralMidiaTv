using CentralMidiaTv.Dominio.Administrativo.Entidade;
using System.Collections.Generic;

namespace CentralMidiaTv.Dominio.Cliente.Entidade
{
    public class Ponto
    {
        protected Ponto()
        {
            Trocas = new List<TrocaAparelho>();
        }
        public int IdPonto { get; private set; }
        public string Descricao { get; private set; }
        public int IdCliente { get; private set; }
        public Cliente Cliente { get; set; }
        public virtual List<TrocaAparelho> Trocas { get; private set; }
    }
}
