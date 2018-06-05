using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCommerce.Models
{
    public class Product
    {
        public int Id { get; set; } 
        [Required]
        [StringLength(200)]
        [Display(Name="Ürün Adı:")]
        public string Name { get; set; } 
        [Display(Name="Ürün Açıklaması:")]
        public string Description { get; set; }
        [StringLength(200)]
        [Display(Name="Ürün Fotoğrafı:")]
        public string Photo { get; set; }
        [Display(Name="Ürün Fiyatı:")]
        public decimal Price { get; set; }  
        [Display(Name="Stok:")]
        public int Stock { get; set; }

        [Display(Name="Kategori:")]
        public int CategoryId { get; set; } 
        [ForeignKey("CategoryId")]
        [Display(Name="Kategori:")]
        public Category Category { get; set; }

        public Product()
        {
            CreateDate = DateTime.Now;
        }
        [Display(Name="Oluşturulma Tarihi:")]
        public DateTime? CreateDate { get; set; }

        [Display(Name="Öne Çıkan Mı ?:")]
        public bool IsFeatured { get; set; }

        [Display(Name="Yayında Mı? :")]
        public bool IsPublished { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }

    }
}
