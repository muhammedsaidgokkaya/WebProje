using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProje.Models
{
    public class Duyuru
    {
        [Key]
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Baslik_anasayfa { get; set; }
        public string Aciklama { get; set; }
        public string ResimYol { get; set; }
        [NotMapped]
        public IFormFile Resim { get; set; }
    }
}
