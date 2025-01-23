using System.ComponentModel.DataAnnotations;

namespace Vivaldikafe1.Models
{
    public class User
    {
        [Key]
        public int KullaniciID { get; set; }
        [Required]
        [StringLength(10)]
        public string KullaniciAd { get; set; } = "";
        public string sifre { get; set; } = "";
        public string role { get; set; } = "User";
        public int Durum { get; set; } = 1;

    }
}
