namespace WebApplicationDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplicationDemo.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplicationDemo.Models.ProductDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebApplicationDemo.Models.ProductDBContext";
        }

        protected override void Seed(WebApplicationDemo.Models.ProductDBContext context)
        {
            context.Products.AddOrUpdate(i => i.Productname,
        new Product
        {
            ReleaseDate = DateTime.Parse("1989-1-11"),
            Productname = "Romantic Comedy",
            Price = 23,
            Storage=9
        }
   );
        }
    }
}
