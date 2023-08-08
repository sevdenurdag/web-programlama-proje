using System.ComponentModel.DataAnnotations;

namespace WebApplication12.Models
{
    public class RandevuViewModel
    {
        [Required(ErrorMessage = "Bu alan boş geçilemez.")]
        [StringLength(50, ErrorMessage = "İsim soy isim maximum 50 karakter olabilir.")]

        public string hastaAdi { get; set; }


        [Required(ErrorMessage = "Bu alan boş geçilemez.")]
        [StringLength(50, ErrorMessage = "Poliklinik adı maximum 50 karakter olabilir.")]
        public string poliklinik { get; set; }


        [Required(ErrorMessage = "Bu alan boş geçilemez.")]
        [StringLength(50, ErrorMessage = "Doktor adı maximum 50 karakter olabilir.")]
        public string doktor { get; set;}


        [Required(ErrorMessage = "Bu alan boş geçilemez.")]
        public string gün { get; set; }
    }
}
