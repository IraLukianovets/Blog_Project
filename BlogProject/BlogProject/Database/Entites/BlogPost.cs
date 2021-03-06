﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bysunka.Database.Entites
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Writer { get; set; }
        public bool IsPublished { get; set; }
    }
}