using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_LinkedinProfiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> allCompanies = CRUD.GetAllCompanies();
            foreach (var item in allCompanies)
            {
                Console.WriteLine(item);
            }

            //CRUD.RemoveSchool(9);

            //CRUD.AddPerson("lusineduryan", "Lusine Duryan", "Senior Financial Analyst", "Armenia", "YSU", "SCDM", 932);

            //CRUD.UpdateEducation(3383, "Yerevan State University");



            Console.ReadKey();
        }
    }
}
