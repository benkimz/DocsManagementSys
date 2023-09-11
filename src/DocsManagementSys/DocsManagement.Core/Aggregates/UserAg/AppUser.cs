using System.ComponentModel.DataAnnotations;

namespace DocsManagement.Core.Aggregates.UserAg
{
    public class AppUser
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(512)]
        public required string UserId { get; set; }

        public UserRole Role { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
