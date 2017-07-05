namespace OdeTo.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeTo.Models.OdeToDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "OdeTo.Models.OdeToDb";
        }

        protected override void Seed(OdeTo.Models.OdeToDb context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,

                new Restaurant { Name = "Sabino s", City = "Baltimore", Country = "USA" },
                new Restaurant { Name = "G Lake", City = "Chicago", Country = "USA" },
                new Restaurant
                {
                    Name = "Smaka",
                    City = "Gothenburg",
                    Country = "SWE",
                    Reviews =
                        new List<RestaurantReview>
                        {
                            new RestaurantReview {Rating = 9, Body="Great Food!" , ReviewName="Scott"}
                        }
                });
        }
    }
}
