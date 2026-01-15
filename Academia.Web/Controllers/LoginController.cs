using Academia.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

namespace Academia.Web.Controllers;

public class LoginController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public LoginController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(LoginViewModel model)
    {
        var client = _httpClientFactory.CreateClient();

        var json = JsonSerializer.Serialize(model);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await client.PostAsync(
            "http://localhost:5118/api/auth/login",
            content
        );

        if (!response.IsSuccessStatusCode)
        {
            ViewBag.Erro = "Login inválido";
            return View();
        }

        var result = await response.Content.ReadAsStringAsync();
        var usuario = JsonDocument.Parse(result).RootElement;

        HttpContext.Session.SetString("UsuarioTipo", usuario.GetProperty("tipo").GetString()!);
        HttpContext.Session.SetString("UsuarioNome", usuario.GetProperty("nome").GetString()!);

        if (usuario.GetProperty("tipo").GetString() == "Admin")
            return RedirectToAction("Index", "Admin");

        return RedirectToAction("Index", "Aluno");
    }
}
