namespace Mvc_Roles_Tutorial.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Mvc_Roles_Tutorial.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Mvc_Roles_Tutorial.Models.ApplicationDbContext";
        }

        protected override void Seed(Mvc_Roles_Tutorial.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.CustomCheck1.AddOrUpdate(

                new Models.CustomCheck1 { Field1 = "abc", Field2 = "abc2" },
                new Models.CustomCheck1 { Field1 = "def", Field2 = "def2" },
                new Models.CustomCheck1 { Field1 = "efg", Field2 = "efg2" },
                new Models.CustomCheck1 { Field1 = "mno", Field2 = "mno2" },
                new Models.CustomCheck1 { Field1 = "pol", Field2 = "pol2" }

                );

            context.Roles.AddOrUpdate(

                new Microsoft.AspNet.Identity.EntityFramework.IdentityRole { Id = "7", Name = "Boss Mode" },
                new Microsoft.AspNet.Identity.EntityFramework.IdentityRole { Id = "8", Name = "SUper Mode" },
                new Microsoft.AspNet.Identity.EntityFramework.IdentityRole { Id = "9", Name = "CTO Mode" },
                new Microsoft.AspNet.Identity.EntityFramework.IdentityRole { Id = "10", Name = "Shareholder Mode" }

                );


        }
    }
}
