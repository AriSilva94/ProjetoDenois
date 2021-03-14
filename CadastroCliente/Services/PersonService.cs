using CadastroCliente.Data;
using CadastroCliente.Models;
using CadastroCliente.Repository.Interface;
using CadastroCliente.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadastroCliente.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<List<Person>> FindAllAsync()
        {
            return await _personRepository.FindAllAsync();
        }

        public async Task<Person> FindByIdAsync(int id)
        {
            var person = await _personRepository.FindByIdAsync(id);

            return person;
        }

        public async Task InsertAsync(Person person)
        {
            await _personRepository.InsertAsync(person);
        }

        public async Task RemoveAsync(int id)
        {
            var person = await FindByIdAsync(id);

            await _personRepository.RemoveAsync(person);
        }
    }
}
