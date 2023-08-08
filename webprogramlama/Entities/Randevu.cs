using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication12.Entities
{

    [Table("Randevular")]

    public class Randevu
    {

        [Key]
        public Guid Id { get; set; }


        [Required]
        [StringLength(50)]
        public string hastaAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string poliklinik { get; set; }

        [Required]
        [StringLength(50)]
        public string doktor { get; set; }

        [Required]
        public string gün { get; set; }
    }
}
