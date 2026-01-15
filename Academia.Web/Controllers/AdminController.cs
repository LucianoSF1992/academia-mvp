using Microsoft.AspNetCore.Mvc;

namespace Academia.Web.Controllers;

public class AdminController : Controller
{
    public IActionResult Index()
    {
        return Content("Painel do Admin");
    }
}
