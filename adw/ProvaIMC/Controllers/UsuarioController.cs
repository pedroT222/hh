namespace ProvaIMC.Controllers;
using Microsoft.AspNetCore.Mvc;
using ProvaIMC.Models;
using ProvaIMC.Data;


[ApiController]
[Route("usuario")]
public class UsuarioController:ControllerBase
{
    private readonly AppDataContext _context;
    public UsuarioController(AppDataContext context){
        _context = context;
    }


[HttpPost]
[Route("cadastrar")]
public IActionResult Cadastrar ([FromBody] Usuario usuario) 
{
    try 
        {
           _context.Add(usuario);
            _context.SaveChanges();
            return Ok(usuario);
        }
        catch (Exception e)
        {
            return BadRequest("erro");
        }
    }
}