using Microsoft.AspNetCore.Mvc;
using Project.Data;
using Project.Data.Cart;
using Project.Data.Service;
using Project.Data.ViewModel;
using System.Collections.Immutable;

namespace Project.Controllers
{
    public class OrdersController : Controller
    {
        //variable declarations
        private readonly ShoppingCart _shoppingCart;
        private readonly IProductService _productservice;

        //sets services
        public OrdersController(ShoppingCart shoppingCart, IProductService productservice)
        {
            _shoppingCart = shoppingCart;
            _productservice = productservice;
        }

        //Shopping Cart Action, sets cart
        public IActionResult ShoppingCart()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var response = new ShoppingCartVM()
            {

                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()

            };

            return View(response);
        }

        //Add To cart Shopping Cart Action, increases item in cart
        public async Task<RedirectToActionResult> AddToShoppingCart(int ID)
        {

            var item = await _productservice.GetProductByIdAsync(ID);

            if (item != null) 
            {
                _shoppingCart.AddItemToCart(item);
               
            }

            return RedirectToAction(nameof(ShoppingCart));
        }

        //Subtracts item from cart
        public async Task<RedirectToActionResult> RemoveFromShoppingCart(int ID)
        {

            var item = await _productservice.GetProductByIdAsync(ID);

            if (item != null)
            {
                _shoppingCart.RemoveItemFromCart(item);

            }

            return RedirectToAction(nameof(ShoppingCart));
        }

    }
}
