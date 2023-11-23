using Microsoft.AspNetCore.Mvc;

namespace Wba.WebFoods.Web.Controllers
{
    public class StateController : Controller
    {
        public IActionResult Index()
        {
            //get the cookie
            ViewBag.Username = HttpContext
                .Request.Cookies["Username"];
            //get the session
            ViewBag.UsernameFromSession = HttpContext.
                Session.GetString("Username");
            ViewBag.LoggedIn = HttpContext
                .Session.GetInt32("LoggedIn");
            return View();
        }
        public IActionResult AddCookies()
        {
            //add a cookie
            CookieOptions cookieOptions = new CookieOptions
            {
                Expires = DateTime.Now.AddMinutes(2),
            };
            HttpContext.Response
                .Cookies.Append("Username", "blue@roblox.com",cookieOptions);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult RemoveCookies()
        {
            HttpContext.Response.Cookies.Delete("Username");
            return RedirectToAction(nameof(Index));
        }
        public IActionResult AddSession()
        {
            HttpContext.Session.SetInt32("LoggedIn", 1);
            HttpContext.Session.SetString("Username", "blue@roblox.com");
            return RedirectToAction(nameof(Index));
        }
        public IActionResult RemoveSession() 
        {
            HttpContext.Session.Clear();
            return RedirectToAction(nameof(Index));
        }
    }
}
