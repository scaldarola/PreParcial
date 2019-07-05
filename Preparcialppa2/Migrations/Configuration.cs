namespace Preparcialppa2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Preparcialppa2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Preparcialppa2.Data.VetDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Preparcialppa2.Data.VetDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Rooms.Add(new Room() { Name= "Room 1", Location= "Norte" });
        }
    }
}
