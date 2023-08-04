using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MHRS.Entities
{
    [Table("hastaneler")]
    public class hastane
    {
        [Key]
        public Guid hastaneId { get; set; }

        [Required]
        [MaxLength(20)]
        public string hastaneAd { get; set; }

    }
}
