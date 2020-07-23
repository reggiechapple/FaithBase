using System;
using System.ComponentModel.DataAnnotations;

namespace FaithBase.Domain.Entities
{
    public class Post : Entity
    {
        [Required(ErrorMessage = "Please enter title")]
        [Display(Name = "Title")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Slug not provided")]
        public string Slug { get; set; }

        [Required(ErrorMessage = "Please enter summary")]
        [Display(Name = "Summary")]
        public string Summary { get; set; }

        [Required(ErrorMessage = "Please enter content")]
        [Display(Name = "Content")]
        public string Content { get; set; }

        [Display(Name = "Post Image")]
        public string PostImage { get; set; }
        
        [Display(Name = "Publish")]
        public bool IsPublished { get; set; }

        public DateTime PublishedAt { get; set; }
    }
}