using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CentralMidiaTv.Aplicacao._2_Data
{
    public class Contexto : DbContext
    {
        public Contexto(): base("connectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Dominio.Funcionario.Entidade.Funcionario> Funcionario { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region config geral
            //remove a pluralização padrão do Etity Framework que é em inglês
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //removido para nao excluir entidades relacionadas
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //Basicamente a mesma configuração, porém em relacionamenos N:N
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //configurando tipo string sql
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));
            //definindo chave primaria para quando nao for especificada no map
            modelBuilder.Properties()
                .Where(p => p.Name == "Id" + p.ReflectedType.Name)
                .Configure(p =>
                    p.HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                    .IsKey().HasColumnOrder(0));
            #endregion
            #region map
            //funcionario
            modelBuilder.Configurations.Add(new Map.FuncionarioMap());
            #endregion
        }
    }
}