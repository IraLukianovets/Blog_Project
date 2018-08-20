using Bysunka.Database.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogProject.Database;

namespace Bysunka.Database.Commands
{
    public class AddBlogPostCommand
    {
        private AppDbContext context;
        public BlogPost post;
        public AddBlogPostCommand(AppDbContext context, BlogPost post)
        {
            this.context = context;
            this.post = post;
        }

        public bool Execut()
        {
            if (post != null)
            {
                context.Posts.Add(post);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}