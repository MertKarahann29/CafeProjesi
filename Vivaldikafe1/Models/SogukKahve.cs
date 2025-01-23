using System.ComponentModel.DataAnnotations;

namespace Vivaldikafe1.Models
{
    public class SogukKahve
    {
        [Key]

        public int id { get; set; }
        public string Ad { get; set; } = "";
        public string Acıklama { get; set; } = "";
        public string Url { get; set; } = "";
        public int Ucret { get; set; } 


    }
}
