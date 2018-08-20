using System;
using System.Linq;
using System.Web.Mvc;
using BlogProject.Models;
using BlogProject.Services;
using Bysunka.Database.Entites;

namespace BlogProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly PostsService postsService;

        public HomeController()
        {
            postsService = new PostsService();
        }

        public ActionResult Index()
        {
            var model = new HomePageModel();
            model.Posts = postsService.Get()?.Where(post => post.IsPublished).ToList();
            return View(model);
        }

        public ActionResult AddPost()
        {
            var model = new AddPostPageModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddPost(BlogPost post)
        {
            if (ModelState.IsValid)
            {
                post.PublishedAt = DateTime.Now;
                postsService.Add(post);
                return RedirectToAction("Index", "Home");
            }

            var model = new AddPostPageModel();
            return View("AddPost", model);
        }
    }
}