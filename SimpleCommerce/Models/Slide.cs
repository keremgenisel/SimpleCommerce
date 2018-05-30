using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCommerce.Models
{
    public class Slide
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        [Display(Name="Slide Resim Adı:")]
        public string Name { get; set; }
        [StringLength(200)]
        [Display(Name ="Slide Resmi:")]
        public string Photo { get; set; }
        [StringLength(200)]
        [Display(Name ="Resim Url'si:")]
        public string Url { get; set; }
        [Display(Name="Posizyon")]
        public int Posetion { get; set; }
        [Display(Name ="Yayında mı ?:")]
        public bool IsPublished { get; set; }
    }
}
