using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MHRS.Entities
{
    [Table("Users")  ]
    public class User
    {
        [Key]
        public Guid UserId { get; set; }


        [MaxLength(30)]
        public string? UserFullName { get; set; } = null;


        [Required]
        [MaxLength(30)]
        public string UserName { get; set; }
       
        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        public bool Locked { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [StringLength(50)]
        public string Role { get; set; } = "user";

    }

}
