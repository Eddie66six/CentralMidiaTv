using System.Collections.Generic;

namespace CentralMidiaTv.Dominio.Cliente.Entidade
{
    public class CategoriaCliente
    {
        protected CategoriaCliente()
        {
            Clientes = new List<Cliente>();
        }
        public int IdCategoriaCliente { get; private set; }
        public string Descricao { get; private set; }
        public virtual List<Cliente> Clientes { get; private set; }
    }
}
