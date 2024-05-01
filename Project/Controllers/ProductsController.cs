using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Data.Service;
using Project.Models;

namespace Project.Controllers
{
    public class ProductsController : Controller
    {
        ///service declaration
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        //Index action, gets products
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetProducts();
            return View(data);
        }

        //returns a view
       public IActionResult Create() 
        { 
        
            return View();
        
        }

        // Details action, returns product details
        public async Task<IActionResult> Details(int id)
        {

            var productDetails = await _service.GetProductByIdAsync(id);

            if (productDetails == null) { return View("NotFound"); }

            return View(productDetails);
        }
        //creates product with the define variables in bind

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ImageURL,ProductName,ProductDescription,ProductQuantity,ProductCategory,ProductPrice")] Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            await _service.AddAsync(product);
            return RedirectToAction(nameof(Index));
        }

        // Edit action, updates product detials and returns a not found view for product is not present
        public async Task<IActionResult> Edit(int id)
        {

            var productDetails = await _service.GetProductByIdAsync(id);

            if (productDetails == null) { return View("NotFound"); }

            return View(productDetails);
        }

        //edit action
        [HttpPost]
        public async Task<IActionResult> Edit(int ID,[Bind("ID,ImageURL,ProductName,ProductDescription,ProductQuantity,ProductCategory,ProductPrice")] Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            await _service.UpdateAsync(ID,product);
            return RedirectToAction(nameof(Index));
        }

        //delete action method
        public async Task<IActionResult> Delete(int id)
        {

            var productDetails = await _service.GetProductByIdAsync(id);

            if (productDetails == null){return View("NotFound");}

            return View(productDetails);
        }

        //delete action, post
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmation(int ID)
        {
            var productDetails = await _service.GetProductByIdAsync(ID);
            if (productDetails == null) { return View("NotFound"); }

            await _service.DeleteAsync(ID);
            return RedirectToAction(nameof(Index));

        }

        //Display products with serach functions
        public async Task<IActionResult> Display(string searchString, String searchCategory)
        {

            var data = await _service.GetProducts();
            
            if (_service.GetProducts()== null)
            {
                return Problem("No Products in Database");
            }

            //Search

            if (!String.IsNullOrEmpty(searchString))
            {
                data = data.Where(s => s.ProductName!.Contains(searchString));

            }

            if (!String.IsNullOrEmpty(searchCategory))
            {
                data = data.Where(s => s.ProductCategory!.Contains(searchCategory));
            }

            return View(data);
        }

        //Get Product Deatails action
        public async Task<IActionResult> ProductDetails(int id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var product = await _service.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }



    }
}
