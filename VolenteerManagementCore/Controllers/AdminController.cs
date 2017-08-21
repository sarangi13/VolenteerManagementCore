using Microsoft.AspNetCore.Mvc;
using VolenteerManagementCore.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace VolenteerManagementCore.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        IVolenteerRepository repository;

        public AdminController(IVolenteerRepository repo)
        {
            repository = repo;
        }

        public ViewResult Edit(int ID) =>
            View(repository.Volenteers
                .FirstOrDefault(v => v.ID == ID));

        [HttpPost]
        public IActionResult Edit (Volenteer volenteer)
        {
            if (ModelState.IsValid)
            {
                repository.SaveVolenteer(volenteer);
                return RedirectToAction("List", "Volenteer");
            }
            else
            {
                // Something went wrong
                return View(volenteer);
            }
        }

        public ViewResult Create() => View("Edit", new Volenteer());

        [HttpPost]
        public IActionResult Delete(int ID)
        {
            Volenteer deletedVolenteer = repository.DeleteVolenteer(ID);
            return RedirectToAction("List", "Volenteer");
        }
    }
}
