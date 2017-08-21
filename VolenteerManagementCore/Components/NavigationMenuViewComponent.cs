using Microsoft.AspNetCore.Mvc;
using System.Linq;
using VolenteerManagementCore.Models;

namespace VolenteerManagementCore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IVolenteerRepository repository;

        public NavigationMenuViewComponent(IVolenteerRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            return View(repository.Volenteers
                    .Select(v => v.ApprovalStatus)
                    .Distinct()
                    .OrderBy(v => v)
                );
        }
    }
}
