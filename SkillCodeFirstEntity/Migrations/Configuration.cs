namespace SkillCodeFirstEntity.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SkillCodeFirstEntity.Models.Siniflar.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;//Başta False geliyor. Değiştirmeyi unutmayın TRUE yapın ki VT ile bağlantı kurabilelim !
        }

        protected override void Seed(SkillCodeFirstEntity.Models.Siniflar.Context context)
        {
            
        }
    }
}
