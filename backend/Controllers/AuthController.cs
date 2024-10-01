using Microsoft.AspNetCore.Mvc;
using backend.Context;
using backend.Entities;


namespace backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        private readonly FinalDBContext _context;

        public AutenticacaoController(FinalDBContext dbContext)
        {
            _context = dbContext;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] Cadastro cadastro)
        {
            var user = _context.Cadastros.FirstOrDefault(u => u.Nickname == cadastro.Nickname && u.SenhaCadastro == cadastro.SenhaCadastro);
            if (user == null)
            {
                return Unauthorized(); 
            }
          
            return Ok(new { Message = "Logado!", CadastroId = cadastro.Id });
        }
    }
}