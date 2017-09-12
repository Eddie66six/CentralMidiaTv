using System.Data.Entity.ModelConfiguration;

namespace CentralMidiaTv.Aplicacao._2_Data.Map.Cliente
{
    public class PontoMap : EntityTypeConfiguration<Dominio.Cliente.Entidade.Ponto>
    {
        public PontoMap()
        {
            HasRequired(p => p.Cliente)
                .WithMany(p => p.Pontos)
                .HasForeignKey(p => p.IdCliente);
        }
    }
}