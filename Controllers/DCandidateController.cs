using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class DCandidateController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }
    }
}
