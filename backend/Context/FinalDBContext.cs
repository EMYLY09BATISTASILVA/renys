using Microsoft.EntityFrameworkCore;
using backend.Entities; // Certifique-se de que está referenciando o namespace correto
using backend.Controllers;

namespace backend.Context
{
    public class FinalDBContext : DbContext
    {
        public FinalDBContext(DbContextOptions<FinalDBContext> options) : base(options)
        {
        }

        public DbSet<Cadastro> Cadastros { get; set; }
        public DbSet<RegistroDePartida> RegistroDePartidas { get; set; }
        
        // Outras configurações do contexto
    }
}




    