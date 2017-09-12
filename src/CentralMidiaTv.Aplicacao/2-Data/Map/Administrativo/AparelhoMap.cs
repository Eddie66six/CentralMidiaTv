using System.Data.Entity.ModelConfiguration;

namespace CentralMidiaTv.Aplicacao._2_Data.Map.Administrativo
{
    public class AparelhoMap : EntityTypeConfiguration<Dominio.Administrativo.Entidade.Aparelho>
    {
        public AparelhoMap()
        {
            HasRequired(p => p.FuncionarioCadastro)
                .WithMany(p => p.AparelhosCadastrados)
                .HasForeignKey(p => p.IdFuncionarioCadastro);
        }
    }
}