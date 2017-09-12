using System.Data.Entity.ModelConfiguration;

namespace CentralMidiaTv.Aplicacao._2_Data.Map._Comum
{
    public class ContatoMap : EntityTypeConfiguration<Dominio._Comum.Entidade.Contato>
    {
        public ContatoMap()
        {
            HasOptional(p => p.Cliente)
                .WithMany(p => p.Contatos)
                .HasForeignKey(p => p.IdCliente);
            HasOptional(p => p.Funcionario)
                .WithMany(p => p.Contatos)
                .HasForeignKey(p => p.IdFuncionario);
        }
    }
}