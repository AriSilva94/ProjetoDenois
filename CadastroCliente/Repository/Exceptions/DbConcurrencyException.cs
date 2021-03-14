using System;

namespace CadastroCliente.Repository.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {

        public DbConcurrencyException(string message) : base(message)
        {

        }
    }
}
