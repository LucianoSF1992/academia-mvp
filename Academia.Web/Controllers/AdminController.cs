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

    [HttpGet]
    public IActionResult NovoAluno()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> SalvarAluno(
        string Nome, string Email, int? Idade, string Objetivo)
    {
        var client = new HttpClient();

        var aluno = new
        {
            nome = Nome,
            email = Email,
            idade = Idade,
            objetivo = Objetivo
        };

        var json = System.Text.Json.JsonSerializer.Serialize(aluno);
        var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

        await client.PostAsync("http://localhost:5118/api/alunos", content);

        return RedirectToAction("Alunos");
    }

}
