using System.Collections.Generic;
using Bysunka.Database.Entites;

namespace BlogProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogProject.Database.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BlogProject.Database.AppDbContext context)
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

            var posts = new List<BlogPost>
            {
                new BlogPost
                {
                    Title = "Hello World",
                    Description = "At vero eos et accusamus et iusto odio dignissimos ducimus " +
                                  "qui blanditiis praesentium voluptatum deleniti atque corrupti " +
                                  "quos dolores et quas molestias excepturi sint occaecati cupiditate " +
                                  "non provident, similique sunt in culpa qui officia deserunt mollitia " +
                                  "animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis " +
                                  "est et expedita distinctio. Nam libero tempore, cum soluta nobis est " +
                                  "eligendi optio cumque nihil impedit quo minus id quod maxime placeat " +
                                  "facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. " +
                                  "Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus " +
                                  "saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae." +
                                  " Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis " +
                                  "voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat.",
                    IsPublished = true,
                    PublishedAt = DateTime.Now,
                    Writer = "Iruna"
                },
                new BlogPost
                {
                    Title = "Hello World",
                    Description = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis " +
                                  "praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias " +
                                  "excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia " +
                                  "deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est " +
                                  "et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil " +
                                  "impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis " +
                                  "dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus " +
                                  "saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum" +
                                  " hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut " +
                                  "perferendis doloribus asperiores repellat.",
                    IsPublished = true,
                    PublishedAt = DateTime.Now,
                    Writer = "Artem"
                }
            };

            foreach (var post in posts)
            {
                context.Posts.AddOrUpdate(post);
            }

            context.SaveChanges();
        }
    }
}
