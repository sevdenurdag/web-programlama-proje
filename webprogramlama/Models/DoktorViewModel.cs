using System.ComponentModel.DataAnnotations;

namespace WebApplication12.Models
{
    public class DoktorViewModel
    {
        [Required(ErrorMessage = "Bu alan boş geçilemez.")]
        [StringLength(50, ErrorMessage = "İsim soy isim maximum 50 karakter olabilir.")]
        public string NameSurname { get; set; }

        
        [Required(ErrorMessage = "Bu alan boş geçilemez.")]
        [StringLength(50, ErrorMessage = "Poliklinik adı maximum 50 karakter olabilir.")]
        public string poliklinik { get; set; }
    }
}
