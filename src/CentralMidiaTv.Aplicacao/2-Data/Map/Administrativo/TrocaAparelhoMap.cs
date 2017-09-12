using System.Data.Entity.ModelConfiguration;

namespace CentralMidiaTv.Aplicacao._2_Data.Map.Administrativo
{
    public class TrocaAparelhoMap : EntityTypeConfiguration<Dominio.Administrativo.Entidade.TrocaAparelho>
    {
        public TrocaAparelhoMap()
        {
            HasRequired(p => p.AparelhoTroca)
                .WithMany(p => p.Trocas)
                .HasForeignKey(p => p.IdAparelhoTroca);
            HasRequired(p => p.PontoTroca)
                .WithMany(p => p.Trocas)
                .HasForeignKey(p => p.IdPontoTroca);
        }
    }
}