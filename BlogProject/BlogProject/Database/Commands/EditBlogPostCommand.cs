using Bysunka.Database.Entites;
using System.Linq;
using BlogProject.Database;

namespace Bysunka.Database.Commands
{
    public class EditBlogPostCommand
    {
        private AppDbContext context;
        public BlogPost post;

        public EditBlogPostCommand(AppDbContext context, BlogPost post)
        {
            this.context = context;
            this.post = post;
        }

        public bool Execut()
        {
            var existPost = context.Posts.FirstOrDefault(pst => pst.Id == post.Id);

            if (post != null && existPost != null)
            {
                existPost.IsPublished = post.IsPublished;
                existPost.PublishedAt = post.PublishedAt;
                existPost.Title = post.Title;
                existPost.Writer = post.Writer;
                existPost.Description = post.Description;
                context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}