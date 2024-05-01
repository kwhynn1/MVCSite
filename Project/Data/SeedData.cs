using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }
                context.Product.AddRange(
                   new Product 
                   { 
                       ImageURL = "https://dashikishirtafrican.com/wp-content/uploads/2018/10/Dashiki-Shirts-Store-011.jpg",
                       ProductName ="Blue Dashiki Shirt",
                       ProductDescription = "Dashiki Shirt",
                       ProductCategory ="Boy",
                       ProductQuantity =1,
                       ProductPrice =1
                   }, new Product
                   {
                       ImageURL = "https://dashikishirtafrican.com/wp-content/uploads/2018/10/Dashiki-Shirts-Store-011.jpg",
                       ProductName = "Blue Dashiki Shirt",
                       ProductDescription = "Dashiki Shirt",
                       ProductCategory = "Boy",
                       ProductQuantity = 1,
                       ProductPrice = 1
                   }, new Product
                   {
                       ImageURL = "https://dashikishirtafrican.com/wp-content/uploads/2018/10/Dashiki-Shirts-Store-011.jpg",
                       ProductName = "Blue Dashiki Shirt",
                       ProductDescription = "Dashiki Shirt",
                       ProductCategory = "Boy",
                       ProductQuantity = 1,
                       ProductPrice = 1
                   }, new Product
                   {
                       ImageURL = "https://dashikishirtafrican.com/wp-content/uploads/2018/10/Dashiki-Shirts-Store-011.jpg",
                       ProductName = "Blue Dashiki Shirt",
                       ProductDescription = "Dashiki Shirt",
                       ProductCategory = "Boy",
                       ProductQuantity = 1,
                       ProductPrice = 1
                   }, new Product
                   {
                       ImageURL = "https://dashikishirtafrican.com/wp-content/uploads/2018/10/Dashiki-Shirts-Store-011.jpg",
                       ProductName = "Blue Dashiki Shirt",
                       ProductDescription = "Dashiki Shirt",
                       ProductCategory = "Boy",
                       ProductQuantity = 1,
                       ProductPrice = 1
                   }, new Product
                   {
                       ImageURL = "https://dashikishirtafrican.com/wp-content/uploads/2018/10/Dashiki-Shirts-Store-011.jpg",
                       ProductName = "Blue Dashiki Shirt",
                       ProductDescription = "Dashiki Shirt",
                       ProductCategory = "Boy",
                       ProductQuantity = 1,
                       ProductPrice = 1
                   }, new Product
                   {
                       ImageURL = "https://dashikishirtafrican.com/wp-content/uploads/2018/10/Dashiki-Shirts-Store-011.jpg",
                       ProductName = "Blue Dashiki Shirt",
                       ProductDescription = "Dashiki Shirt",
                       ProductCategory = "Boy",
                       ProductQuantity = 1,
                       ProductPrice = 1
                   }, new Product
                   {
                       ImageURL = "https://dashikishirtafrican.com/wp-content/uploads/2018/10/Dashiki-Shirts-Store-011.jpg",
                       ProductName = "Blue Dashiki Shirt",
                       ProductDescription = "Dashiki Shirt",
                       ProductCategory = "Boy",
                       ProductQuantity = 1,
                       ProductPrice = 1
                   }, new Product
                   {
                       ImageURL = "https://dashikishirtafrican.com/wp-content/uploads/2018/10/Dashiki-Shirts-Store-011.jpg",
                       ProductName = "Blue Dashiki Shirt",
                       ProductDescription = "Dashiki Shirt",
                       ProductCategory = "Boy",
                       ProductQuantity = 1,
                       ProductPrice = 1
                   }, new Product
                   {
                       ImageURL = "https://dashikishirtafrican.com/wp-content/uploads/2018/10/Dashiki-Shirts-Store-011.jpg",
                       ProductName = "Blue Dashiki Shirt",
                       ProductDescription = "Dashiki Shirt",
                       ProductCategory = "Boy",
                       ProductQuantity = 1,
                       ProductPrice = 1
                   }, new Product
                   {
                       ImageURL = "https://dashikishirtafrican.com/wp-content/uploads/2018/10/Dashiki-Shirts-Store-011.jpg",
                       ProductName = "Blue Dashiki Shirt",
                       ProductDescription = "Dashiki Shirt",
                       ProductCategory = "Boy",
                       ProductQuantity = 1,
                       ProductPrice = 1
                   }, new Product
                   {
                       ImageURL = "https://dashikishirtafrican.com/wp-content/uploads/2018/10/Dashiki-Shirts-Store-011.jpg",
                       ProductName = "Blue Dashiki Shirt",
                       ProductDescription = "Dashiki Shirt",
                       ProductCategory = "Boy",
                       ProductQuantity = 1,
                       ProductPrice = 1
                   }, new Product
                   {
                       ImageURL = "https://dashikishirtafrican.com/wp-content/uploads/2018/10/Dashiki-Shirts-Store-011.jpg",
                       ProductName = "Blue Dashiki Shirt",
                       ProductDescription = "Dashiki Shirt",
                       ProductCategory = "Boy",
                       ProductQuantity = 1,
                       ProductPrice = 1
                   }, new Product
                   {
                       ImageURL = "https://dashikishirtafrican.com/wp-content/uploads/2018/10/Dashiki-Shirts-Store-011.jpg",
                       ProductName = "Blue Dashiki Shirt",
                       ProductDescription = "Dashiki Shirt",
                       ProductCategory = "Boy",
                       ProductQuantity = 1,
                       ProductPrice = 1
                   }, new Product
                   {
                       ImageURL = "https://dashikishirtafrican.com/wp-content/uploads/2018/10/Dashiki-Shirts-Store-011.jpg",
                       ProductName = "Blue Dashiki Shirt",
                       ProductDescription = "Dashiki Shirt",
                       ProductCategory = "Boy",
                       ProductQuantity = 1,
                       ProductPrice = 1
                   }, new Product
                   {
                       ImageURL = "https://dashikishirtafrican.com/wp-content/uploads/2018/10/Dashiki-Shirts-Store-011.jpg",
                       ProductName = "Blue Dashiki Shirt",
                       ProductDescription = "Dashiki Shirt",
                       ProductCategory = "Boy",
                       ProductQuantity = 1,
                       ProductPrice = 1
                   }, new Product
                   {
                       ImageURL = "https://dashikishirtafrican.com/wp-content/uploads/2018/10/Dashiki-Shirts-Store-011.jpg",
                       ProductName = "Blue Dashiki Shirt",
                       ProductDescription = "Dashiki Shirt",
                       ProductCategory = "Boy",
                       ProductQuantity = 1,
                       ProductPrice = 1
                   }, new Product
                   {
                       ImageURL = "https://dashikishirtafrican.com/wp-content/uploads/2018/10/Dashiki-Shirts-Store-011.jpg",
                       ProductName = "Blue Dashiki Shirt",
                       ProductDescription = "Dashiki Shirt",
                       ProductCategory = "Boy",
                       ProductQuantity = 1,
                       ProductPrice = 1
                   }

                );
                context.SaveChanges();
            }
        }
    }
}
