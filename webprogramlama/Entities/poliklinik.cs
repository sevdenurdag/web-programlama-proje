using System.ComponentModel.DataAnnotations;

namespace MHRS.Entities
{
    public class poliklinik
    {
        [Key]
        public Guid hastaneId { get; set; }

        [Required]
        [MaxLength(20)]
        public string hastaneAd { get; set; }
    }
}
