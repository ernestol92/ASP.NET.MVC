using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class MemberEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(150)]
        public string Email { get; set; } = null!;

        [Required]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public string Role { get; set; } = null!;

        [Required]
        [MaxLength(150)]
        public string Address { get; set; } = null!;

        [Required]
        public DateTime DateOfBirth { get; set; }
        // Navigation properties
        public ICollection<ProjectEntity> Projects { get; set; } = new List<ProjectEntity>();
    }
}
