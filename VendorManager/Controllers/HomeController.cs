using Microsoft.AspNetCore.Mvc;

namespace VendorManager.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}