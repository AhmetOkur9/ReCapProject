using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class ImageController : Controller
    {
        //ImageData _imageData
        public IActionResult Index()
        {
            return View();
        }
    }
}
