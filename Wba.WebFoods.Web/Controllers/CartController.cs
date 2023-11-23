using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Wba.WebFoods.Web.Data;
using Wba.WebFoods.Web.ViewModels;

namespace Wba.WebFoods.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly WebFoodsDbContext _webFoodsDbContext;

        public CartController(WebFoodsDbContext webFoodsDbContext)
        {
            _webFoodsDbContext = webFoodsDbContext;
        }

        public IActionResult Index()
        {
            //show shopping cart
            return View();
        }
        public IActionResult Add(int id)
        {
            //get the product
            var product = _webFoodsDbContext
                .Products
                .FirstOrDefault(p => p.Id == id);
            //check for null
            if(product == null)
            {
                Response.StatusCode = 404;
                return View("NotFound");
            }
            //create the viewmodel
            CartIndexViewModel cartIndexViewModel = new();
            //check if cartsession exists
            if(HttpContext.Session.Keys.Contains("cartItems"))
            {
                //get the cartitems from session
                var sessionData = HttpContext.Session.GetString("cartItems");
                cartIndexViewModel = JsonConvert.DeserializeObject
                    <CartIndexViewModel>(sessionData);

            }
            else//first product added
            {
                //init the list of items
                cartIndexViewModel.Items = new();
                cartIndexViewModel.Items.Add(
                new CartItemModel
                {
                    Id = product.Id,
                    Value = product.Name,
                    Price = product.Price,
                    Quantity = 1,
                });
            }
            //put in the session
            var serializedData = JsonConvert.SerializeObject(cartIndexViewModel);
            HttpContext.Session.SetString("cartItems", serializedData);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Remove(int id)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
