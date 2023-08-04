using Castle.Components.DictionaryAdapter;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MHRS.Entities
{

    [Table("doktorlar")]
    public class doktor
    {
        
        public Guid doktorId { get; set; }

        [Required]
        [MaxLength(20)]
        public string doktorAd { get; set; }

        [Required]
        [MaxLength(20)]
        public string doktorSoyad { get; set; }

        [Required]
        [MaxLength(30)]
        public string poliklinik { get; set; }



    }
}
