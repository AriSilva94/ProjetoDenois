using CadastroCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCliente.Data
{
    public class SeedingService
    {
        private CadastroClienteContext _context;

        public SeedingService(CadastroClienteContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Person.Any())
            {
                return; //BD has beem seeded
            }

            Person p1 = new Person(1, "Ariovaldo", "16997351101", "997351101");

            _context.Person.AddRange(p1);

            _context.SaveChanges();
        }
    }
}
