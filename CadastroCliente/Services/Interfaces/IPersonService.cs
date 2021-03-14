using CadastroCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCliente.Services.Interfaces
{
    public interface IPersonService
    {
        Task<List<Person>> FindAllAsync();
        Task<Person> FindByIdAsync(int id);

        Task InsertAsync(Person person);
        Task RemoveAsync(int id);
    }
}
