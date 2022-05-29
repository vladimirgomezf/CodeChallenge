using System;

namespace BugsWebAPI.Models
{
    public class BugModel
    {
        public int Id { get; set; }
        public ProjectModel ProjectId { get; set; }
        public UserModel UserId { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
