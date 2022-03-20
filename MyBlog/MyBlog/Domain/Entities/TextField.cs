using System.ComponentModel.DataAnnotations;

namespace MyBlog.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Name of page (title)")]
        public override string Title { get; set; } = "Information page";

        [Display(Name ="Content of page")]
        public override string Text { get; set; } = "The content is filled in by the administrator";
    }
}
