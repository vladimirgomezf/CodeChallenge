using System;
using System.ComponentModel.DataAnnotations;

namespace BugsWebAPI.Models
{
    public class BugModel
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public UserModel User { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
