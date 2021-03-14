using CadastroCliente.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadastroCliente.Repository.Interface
{
    public interface IPersonRepository
    {
        Task<List<Person>> FindAllAsync();

        Task<Person> FindByIdAsync(int id);

        Task InsertAsync(Person person);
        Task RemoveAsync(Person person);
    }
}
