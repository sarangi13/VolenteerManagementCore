using System.Collections.Generic;

namespace VolenteerManagementCore.Models
{
    public interface IVolenteerRepository
    {
        IEnumerable<Volenteer> Volenteers { get; }
    }
}
