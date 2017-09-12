using CentralMidiaTv.Dominio.Administrativo.Enum;

namespace CentralMidiaTv.Dominio.Administrativo.Entidade
{
    public class Aparelho
    {
        public int IdAparelho { get; private set; }
        public string Descricao { get; private set; }
        public ETipoAparelho TipoAparelho { get; private set; }
    }
}
