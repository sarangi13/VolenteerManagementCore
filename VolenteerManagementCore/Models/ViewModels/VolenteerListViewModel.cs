using System.Collections.Generic;
using VolenteerManagementCore.Models;

namespace VolenteerManagementCore.Models.ViewModels
{
    public class VolenteerListViewModel
    {
        public IEnumerable<Volenteer> Volenteers { get; set; }
        public PagingInfo Paginginfo { get; set; }
        public string CurrentStatus { get; set; }
    }
}
