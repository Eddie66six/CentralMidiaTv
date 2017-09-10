using System.Data.Entity.Migrations;
using System.Linq;

namespace CentralMidiaTv.Aplicacao._2_Data
{
    public class ConfigMigration : DbMigrationsConfiguration<Contexto>
    {
        public ConfigMigration()
        {
            AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(Contexto context)
        {

        }
    }
}