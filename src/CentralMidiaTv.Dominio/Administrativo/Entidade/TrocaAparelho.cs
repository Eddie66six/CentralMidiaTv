using CentralMidiaTv.Dominio.Cliente.Entidade;
using System;

namespace CentralMidiaTv.Dominio.Administrativo.Entidade
{
    public class TrocaAparelho
    {
        public int IdTrocaAparelho { get; private set; }
        public DateTime Data { get; set; }
        public Aparelho AparelhoTroca { get; private set; }
        public Ponto PontoTroca { get; private set; }
    }
}
