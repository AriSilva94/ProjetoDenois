using CadastroCliente.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroCliente.Data
{
    public class CadastroClienteContext : DbContext
    {
        public CadastroClienteContext(DbContextOptions<CadastroClienteContext> options) : base(options)
        {}

        public DbSet<Person> Person { get; set; }
    }
}
