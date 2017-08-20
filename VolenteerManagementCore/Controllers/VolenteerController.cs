using Microsoft.AspNetCore.Mvc;
using VolenteerManagementCore.Models;


namespace VolenteerManagementCore.Controllers
{
    public class VolenteerController : Controller
    {
        private IVolenteerRepository repository;

        public VolenteerController(IVolenteerRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Volenteers);
    }
}
