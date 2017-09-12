using System.Data.Entity.ModelConfiguration;

namespace CentralMidiaTv.Aplicacao._2_Data.Map.Cliente
{
    public class ClienteMap : EntityTypeConfiguration<Dominio.Cliente.Entidade.Cliente>
    {
        public ClienteMap()
        {
            HasRequired(p => p.CategoriaCliente)
                .WithMany(p => p.Clientes)
                .HasForeignKey(p => p.IdCategoriaCliente);
        }
    }
}