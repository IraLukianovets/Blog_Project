using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bysunka.Database.Entites;

namespace BlogProject.Models
{
    public class HomePageModel
    {
        public List<BlogPost> Posts { get; set; }
    }
}