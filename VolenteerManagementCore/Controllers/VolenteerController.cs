using Microsoft.AspNetCore.Mvc;
using VolenteerManagementCore.Models;
using System.Linq;
using VolenteerManagementCore.Models.ViewModels;


namespace VolenteerManagementCore.Controllers
{
    public class VolenteerController : Controller
    {
        private IVolenteerRepository repository;
        public int PageSize = 5;

        public VolenteerController(IVolenteerRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(string status, int page = 1)
            => View(new VolenteerListViewModel
            {
                Volenteers = repository.Volenteers
                    .Where(v => status == null || v.ApprovalStatus == status)
                    .OrderBy(v => v.ID)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                Paginginfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = status == null ? repository.Volenteers.Count() : 
                        repository.Volenteers.Where(v => v.ApprovalStatus == status).Count()
                },
                CurrentStatus = status
            });
    }
}
