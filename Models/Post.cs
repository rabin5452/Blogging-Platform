using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Webapp.Models
{
    public class Post
    {
        [Key]
        public Guid Id { get; set; }
        public string name { get; set; }
        [Required]
        [DisplayName("Title")]
        [MaxLength(100,ErrorMessage ="Lenght is high")]
        public string title { get; set; }
        [Required]
        [DisplayName("Description")]
        [MaxLength(1024,ErrorMessage ="lenght is high")]
        public string description { get; set; }
    }
}
