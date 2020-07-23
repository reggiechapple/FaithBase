using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace FaithBase.Application.Models.Post
{
    public class PostInputModel
    {
        [Required(ErrorMessage = "Please enter title")]
        [Display(Name = "Title")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter summary")]
        [Display(Name = "Summary")]
        public string Summary { get; set; }

        [Required(ErrorMessage = "Please enter content")]
        [Display(Name = "Content")]
        public string Content { get; set; }

        [Display(Name = "Post Image")]
        public IFormFile PostImage { get; set; }
        
        [Display(Name = "Publish")]
        public bool IsPublished { get; set; }
    }
}