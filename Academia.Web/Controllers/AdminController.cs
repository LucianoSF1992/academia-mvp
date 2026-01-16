using Microsoft.AspNetCore.Mvc;

namespace Academia.Web.Controllers;

public class AdminController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Dashboard";
        return View();
    }

    public IActionResult Alunos()
    {
        ViewData["Title"] = "Alunos";
        return View();
    }

    public IActionResult Treinos()
    {
        ViewData["Title"] = "Treinos";
        return View();
    }
}
