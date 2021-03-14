using CadastroCliente.Data;
using CadastroCliente.Models;
using CadastroCliente.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadastroCliente.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly CadastroClienteContext _context;

        public PersonRepository(CadastroClienteContext context)
        {
            _context = context;
        }
        public async Task<List<Person>> FindAllAsync()
        {
            return await _context.Person.ToListAsync();
        }

        public async Task<Person> FindByIdAsync(int id)
        {
            return await _context.Person.SingleOrDefaultAsync(p => p.Id.Equals(id));
        }

        public async Task InsertAsync(Person person)
        {
            _context.Person.Add(person);

            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(Person person)
        {
            _context.Person.Remove(person);
            await _context.SaveChangesAsync();
        }
    }
}
