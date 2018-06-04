using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCommerce.Models
{
    public class CartItem
    {
        public int Id { get; set; } 
        public int CartId { get; set; }
        [ForeignKey("CartId")]
        public Cart cart { get; set; }

        public int ProductId { get; set; }  
        [ForeignKey("ProductId")]
        public Product Product { get; set; } //navigasyon propertysi sepete eklenen ürüne ulaşır.
        public int Quantity { get; set; }
        [NotMapped]
        public decimal TotalPrice
        {
            get
            {
                return (Product.Price * Quantity);
            }
        }

    }
}
