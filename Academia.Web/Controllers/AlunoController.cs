using Microsoft.AspNetCore.Mvc;

namespace Academia.Web.Controllers;

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        return Content("Área do Aluno");
    }
}
