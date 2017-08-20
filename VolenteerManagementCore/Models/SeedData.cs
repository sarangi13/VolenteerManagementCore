using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace VolenteerManagementCore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            if (!context.Volenteers.Any())
            {
                StartingData startingData = new StartingData();
                Volenteer volenteers;
                Volenteer[] volenteersList = new Volenteer[30];
                for (int index = 0; index < 30; index = index + 1)
                {
                    volenteers = new Volenteer
                    {
                        FirstName = startingData.GetFirstName(index),
                        LastName = startingData.GetLastName(index),
                        UserName = startingData.GetUserName(index),
                        Password = startingData.GetPassword(index),
                        Center = startingData.GetCenter(index),
                        Skills = startingData.GetSkills(index),
                        Availalibity = startingData.GetAvailalibity(index),
                        Address = startingData.GetAddress(index),
                        Phone = startingData.GetPhone(index),
                        Email = startingData.GetEmail(index),
                        Education = startingData.GetEducation(index),
                        Lincense = startingData.GetLincense(index),
                        EmergencyContact = startingData.GetEmergencyContact(index),
                        EmergencyPhone = startingData.GetEmergencyPhone(index),
                        EmergencyEmail = startingData.GetEmergencyEmail(index),
                        EmergencyAddress = startingData.GetEmergencyAddress(index),
                        Drivers = startingData.GetDrivers(index),
                        Ssn = startingData.GetSsn(index),
                        ApprovalStatus = startingData.GetApprovalStatus(index)
                    };
                    volenteersList[index] = volenteers;
                }
                context.Volenteers.AddRange(volenteersList);
                context.SaveChanges();
            }
        }
    }
}
