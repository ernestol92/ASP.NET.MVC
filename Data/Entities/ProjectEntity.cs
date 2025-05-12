using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class ProjectEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string ProjectName { get; set; } = null!;

        [MaxLength(100)]
        [Required]
        public string ClientName { get; set; } = null!;

        [MaxLength(1000)]
        [Required]
        public string ProjectDescription { get; set; } = null!;

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int Budget { get; set; }
        // Navigation properties

        [Required]
        public int StatusId { get; set; }
        [ForeignKey(nameof(StatusId))]
        public StatusEntity Status { get; set; } = null!;


        [Required]
        public int MemberId { get; set; }
        [ForeignKey(nameof(MemberId))]
        public MemberEntity Member { get; set; } = null!;

    }
}
