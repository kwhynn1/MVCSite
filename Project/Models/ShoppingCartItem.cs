using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ID { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartID { get; set; }
    }
}
