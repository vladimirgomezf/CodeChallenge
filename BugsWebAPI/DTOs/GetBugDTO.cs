using System;
using System.Runtime.InteropServices;

namespace BugsWebAPI.DTOs
{
    public class GetBugDTO
    {
        public int? UserId { get; set; } = 0;
        public int? ProjectId { get; set; } = 0;
        public DateTime? Start_Date { get; set; } = default;
        public DateTime? End_Date { get; set; } = default;

    }
}
