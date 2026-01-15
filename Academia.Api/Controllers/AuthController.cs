using Academia.Api.Data;
using Academia.Api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Academia.Api.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly AcademiaContext _context;

    public AuthController(AcademiaContext context)
    {
        _context = context;
    }

    [HttpPost("login")]
    public IActionResult Login(LoginDto dto)
    {
        var usuario = _context.Usuarios
            .FirstOrDefault(u => u.Email == dto.Email && u.Senha == dto.Senha);

        if (usuario == null)
            return Unauthorized("Usuário ou senha inválidos");

        return Ok(new
        {
            usuario.Id,
            usuario.Nome,
            usuario.Email,
            usuario.Tipo
        });
    }
}
