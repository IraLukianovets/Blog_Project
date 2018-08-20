using System.Collections.Generic;
using Bysunka.Database.Commands;
using Bysunka.Database.Entites;

namespace BlogProject.Services
{
    public class PostsService : BaseService
    {
        public bool Add(BlogPost blogPost)
        {
            if(blogPost != null)
            {
                var dbCommand = new AddBlogPostCommand(dbContext, blogPost);
                dbCommand.Execut();
                return true;
            }

            return false;
        }

        public List<BlogPost> Get()
        {
            var dbCommand = new GetAllBlogPostsCommand(dbContext);
            var posters = dbCommand.Execut();
            return posters;
        }

        public bool Edit(BlogPost blogPost)
        {
            if (blogPost != null)
            {
                var dbCommand = new EditBlogPostCommand(dbContext, blogPost);
                dbCommand.Execut();
                return true;
            }

            return false;
        }
    }
}