using System.Collections.Generic;

namespace VolenteerManagementCore.Models
{
    public class EFVolenteerRepository : IVolenteerRepository
    {
        private ApplicationDbContext context;

        public EFVolenteerRepository (ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Volenteer> Volenteers => context.Volenteers;
     }
}
