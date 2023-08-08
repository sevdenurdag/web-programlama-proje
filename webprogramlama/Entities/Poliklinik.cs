using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication12.Entities
{

    [Table("Poliklinikler")]
    public class Poliklinik
    {
        [Key]
        public Guid poliklinikId { get; set; }

        [Required]
        [StringLength(50)]
        public string poliklinikAdı { get; set; }




    }
}
