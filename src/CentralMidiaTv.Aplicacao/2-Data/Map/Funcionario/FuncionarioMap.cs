using System.Data.Entity.ModelConfiguration;

namespace CentralMidiaTv.Aplicacao._2_Data.Map.Funcionario
{
    public class FuncionarioMap : EntityTypeConfiguration<Dominio.Funcionario.Entidade.Funcionario>
    {
        public FuncionarioMap()
        {
            Property(p => p.Usuario).HasMaxLength(20);
            Property(p => p.Senha).HasMaxLength(20);

            HasOptional(p => p.FuncionarioCadastro)
                .WithMany(p => p.FuncionariosCadastrados)
                .HasForeignKey(p => p.IdFuncionarioCadastro);
            HasOptional(p => p.FuncionarioExclusao)
                .WithMany(p => p.FuncionariosExcluidos)
                .HasForeignKey(p => p.IdFuncionarioExclusao);
            HasOptional(p => p.GrupoLicenciamento)
                .WithMany(p => p.Funcionarios)
                .HasForeignKey(p => p.IdGrupoLicenciamento);
        }
    }
}