using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;

namespace Project.Data.Cart
{
    public class ShoppingCart 
    { 

        public ApplicationDbContext _context { get; set; }

        public string ShoppingCartID { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

    
        public ShoppingCart(ApplicationDbContext context) 
        { 
                _context = context;
        }
        public static ShoppingCart GetShoppingCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<ApplicationDbContext>();

            string cartID = session.GetString("CartID") ?? Guid.NewGuid().ToString();
            session.SetString("CartID", cartID);

            return new ShoppingCart(context) { ShoppingCartID = cartID };
        }

        public void AddItemToCart(Product product)
        {
            var shoppingCartItem = _context.ShoppingCartItems.FirstOrDefault(n => n.Product.ID == product.ID && n.ShoppingCartID == ShoppingCartID);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem()
                {
                    ShoppingCartID = ShoppingCartID,
                    Product = product,
                    Amount = 1
                };

                _context.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _context.SaveChanges();
        }
        public void RemoveItemFromCart(Product product)
        {
            var shoppingCartItem = _context.ShoppingCartItems.FirstOrDefault(n => n.Product.ID == product.ID && n.ShoppingCartID == ShoppingCartID);

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                }
                else
                {
                    _context.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            _context.SaveChanges();
        }

        
        public List<ShoppingCartItem> GetShoppingCartItems() 
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _context.ShoppingCartItems.Where(n => n.ShoppingCartID == ShoppingCartID).Include(n => n.Product).ToList());
        }

        public double GetShoppingCartTotal() 
        { 
        
            var total = _context.ShoppingCartItems.Where(n => n.ShoppingCartID == ShoppingCartID).Select( n => n.Product.ProductPrice * n.Amount).Sum();

            return total;
        }

    }




}

