using System.ComponentModel.DataAnnotations;

namespace BlogProject.Models
{
    public class AddPostPageModel
    {
        [Required]
        public string Writer { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public bool IsPublished { get; set; }
    }
}