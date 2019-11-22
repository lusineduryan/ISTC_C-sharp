using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_LinkedinProfiles
{
    public class CRUD
    {
        public static List<string> GetAllCompanies()
        {
            List<string> companies = new List<string>();
            using (MonitoringEntities context = new MonitoringEntities())
            {
                companies = context.LinkedinProfiles.Select(x => x.Company).Distinct().ToList();
            }
            return companies;
        }

        public static void RemoveSchool(int ID)
        {
            using (MonitoringEntities context = new MonitoringEntities())
            {
                context.LinkedinEducations.Remove(context.LinkedinEducations.Single(x => x.Id == ID));
                context.SaveChanges();
            }
        }

        public static void AddPerson(string username, string fullName, string specialty, string location, string education, string company, int connectionCount)
        { 
            using (MonitoringEntities context = new MonitoringEntities())
            {
                context.LinkedinProfiles.Add(new LinkedinProfile { Username = username, FullName = fullName, Specialty = specialty, Location = location, Education = education, Company = company, ConnectionCount = connectionCount });
                context.SaveChanges();
            }
        }

        public static void UpdateEducation(int ID, string updatedEducation)
        {
            using (MonitoringEntities context = new MonitoringEntities())
            {
                context.LinkedinProfiles.FirstOrDefault(x => x.Id == ID).Education = updatedEducation;
                context.SaveChanges();
            }
        }

    }
}
