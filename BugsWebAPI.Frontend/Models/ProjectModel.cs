using System.ComponentModel.DataAnnotations;

namespace BugsWebAPI.Fontend.Models
{
    public class ProjectModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
