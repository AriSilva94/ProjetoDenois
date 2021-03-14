using CadastroCliente.Models;
using CadastroCliente.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CadastroCliente.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        public async Task<IActionResult> Index()
        {
            var listPerson = await _personService.FindAllAsync();

            return View(listPerson);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Telephone,Cell")] Person person)
        {
            if (ModelState.IsValid)
            {
                await _personService.InsertAsync(person);

                return RedirectToAction(nameof(Index));

            }
            return View(person);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                var person = await _personService.FindByIdAsync((int)id);

                return View(person);
            }

            return NotFound();
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _personService.RemoveAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}

