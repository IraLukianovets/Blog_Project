using System;
using System.Collections.Generic;
using Bysunka.Database.Entites;
using System.Linq;
using System.Web;
using BlogProject.Database;

namespace Bysunka.Database.Commands
{
    public class GetAllBlogPostsCommand
    {
        private AppDbContext context;

        public GetAllBlogPostsCommand(AppDbContext context)
        {
            this.context = context;
        }

        public List<BlogPost> Execut()
        {
            return context.Posts.OrderByDescending(post=>post.PublishedAt).ToList();
        }
    
     
    }
}