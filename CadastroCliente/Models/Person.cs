using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCliente.Models
{
    public class Person
    {
        public Person()
        {}
        public Person(int id, string name, string telephone, string cell)
        {
            Id = id;
            Name = name;
            Telephone = telephone;
            Cell = cell;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }

        public string Cell { get; set; }
    }
}
