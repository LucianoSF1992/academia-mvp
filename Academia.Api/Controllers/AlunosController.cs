using Academia.Api.Data;
using Academia.Api.Dtos;
using Academia.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academia.Api.Controllers;

[ApiController]
[Route("api/alunos")]
public class AlunosController : ControllerBase
{
    private readonly AcademiaContext _context;

    public AlunosController(AcademiaContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var alunos = _context.Alunos
            .Select(a => new AlunoDto
            {
                Id = a.Id,
                Nome = a.Usuario.Nome,
                Email = a.Usuario.Email,
                Idade = a.Idade,
                Objetivo = a.Objetivo
            })
            .ToList();

        return Ok(alunos);
    }

    [HttpPost]
    public IActionResult Post(AlunoDto dto)
    {
        var usuario = new Usuario
        {
            Nome = dto.Nome,
            Email = dto.Email,
            Senha = "123", // senha padrão MVP
            Tipo = "Aluno"
        };

        var aluno = new Aluno
        {
            Usuario = usuario,
            Idade = dto.Idade,
            Objetivo = dto.Objetivo
        };

        _context.Alunos.Add(aluno);
        _context.SaveChanges();

        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var aluno = _context.Alunos.FirstOrDefault(a => a.Id == id);
        if (aluno == null) return NotFound();

        _context.Alunos.Remove(aluno);
        _context.SaveChanges();

        return NoContent();
    }
}
