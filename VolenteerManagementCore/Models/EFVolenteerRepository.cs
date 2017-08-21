using System.Collections.Generic;
using System.Linq;

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

        public void SaveVolenteer(Volenteer volenteer)
        {
            if (volenteer.ID == 0)
            {
                context.Volenteers.Add(volenteer);
            }
            else
            {
                Volenteer dbEntry = context.Volenteers
                    .FirstOrDefault(v => v.ID == volenteer.ID);
                if (dbEntry != null)
                {
                    dbEntry.FirstName = volenteer.FirstName;
                    dbEntry.LastName = volenteer.LastName;
                    dbEntry.UserName = volenteer.UserName;
                    dbEntry.Password = volenteer.Password;
                    dbEntry.Center = volenteer.Center;
                    dbEntry.Skills = volenteer.Skills;
                    dbEntry.Availalibity = volenteer.Availalibity;
                    dbEntry.Address = volenteer.Address;
                    dbEntry.Phone = volenteer.Phone;
                    dbEntry.Email = volenteer.Email;
                    dbEntry.Education = volenteer.Education;
                    dbEntry.Lincense = volenteer.Lincense;
                    dbEntry.EmergencyContact = volenteer.EmergencyContact;
                    dbEntry.EmergencyPhone = volenteer.EmergencyPhone;
                    dbEntry.EmergencyEmail = volenteer.EmergencyEmail;
                    dbEntry.EmergencyAddress = volenteer.EmergencyAddress;
                    dbEntry.Drivers = volenteer.Drivers;
                    dbEntry.Ssn = volenteer.Ssn;
                    dbEntry.ApprovalStatus = volenteer.ApprovalStatus;
                }
            }
            context.SaveChanges();
        }

        public Volenteer DeleteVolenteer(int ID)
        {
            Volenteer dbEntry = context.Volenteers.FirstOrDefault(v => v.ID == ID);
            if (dbEntry != null)
            {
                context.Volenteers.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
     }
}
