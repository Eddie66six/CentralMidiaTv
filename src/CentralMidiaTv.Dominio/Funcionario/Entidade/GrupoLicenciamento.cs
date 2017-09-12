using System.Collections.Generic;

namespace CentralMidiaTv.Dominio.Funcionario.Entidade
{
    public class GrupoLicenciamento
    {
        protected GrupoLicenciamento()
        {
            Funcionarios = new List<Funcionario>();
        }
        public int IdGrupoLicenciamento { get; private set; }
        public string Descrica { get; set; }
        public virtual List<Funcionario> Funcionarios { get; private set; }
    }
}
