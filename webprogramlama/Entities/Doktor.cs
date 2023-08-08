using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebApplication12.Entities
{
    [Table("Doktorlar")]
    public class Doktor
    {
       [Key]   
       public Guid Id { get; set; }

       [Required]
       [StringLength(50)]  
       public string NameSurname { get; set; }

       [Required]
       [StringLength(50)]
       public string poliklinik { get; set; }

       public int PoliklinikId{ get; internal set; }
    }
}
