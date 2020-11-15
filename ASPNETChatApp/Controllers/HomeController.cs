using Microsoft.AspNetCore.Mvc;

namespace ASPNETChatApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}