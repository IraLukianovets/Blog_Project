using BlogProject.Database;

namespace BlogProject.Services
{
    public class BaseService
    {
        protected AppDbContext dbContext;

        protected BaseService()
        {
            dbContext = new AppDbContext();
        }
    }
}