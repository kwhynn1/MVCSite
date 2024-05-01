using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [StringLength(100)]

        [Display(Name = "Image URL")]
        public string ImageURL { get; set; }

        [StringLength(50)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [StringLength(100)]

        [Display(Name = "Product Description")]
        public string ProductDescription { get; set; }
       
        [Display(Name = "Product Quantity")]
        public int ProductQuantity { get; set; }

        [AllowedValues("Ladies", "Men","Boy","Girl", ErrorMessage = "Category Must Be Ladies, Men, Boy, Girl")]
        [Display(Name = "Product Category")]
        public string ProductCategory { get; set; }

        [Display(Name = "Product Price")]
        [Range(1, 100)]
        public double ProductPrice { get; set; }
      
    }
}