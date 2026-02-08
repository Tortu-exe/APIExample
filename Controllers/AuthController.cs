using Microsoft.AspNetCore.Mvc;

namespace ProbarGiladassss.Controllers;

public class AuthController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}