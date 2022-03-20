using System.ComponentModel.DataAnnotations;

namespace MyBlog.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage ="Please fill name of service")]
        [Display(Name = "Name of service")]
        public override string Title { get; set; }

        [Display(Name = "Short description of service")]
        public override string Subtitle { get; set; }

        [Display(Name = "Full description of service")]
        public override string Text { get; set; }
    }
}
