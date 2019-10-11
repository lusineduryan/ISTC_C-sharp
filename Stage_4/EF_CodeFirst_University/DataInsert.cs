using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_University
{
    public class DataInsert
    {
        public static void AddData()
        {
            using (UniversityContext context = new UniversityContext())
            {
                context.Students.Add(new Student { Id = 1, FirstName = "Gohar", LastName = "Avagyan", Birthday = new DateTime(1995, 11, 25), Email = "gohar.avagyan@daa.com" });
                context.Students.Add(new Student { Id = 2, FirstName = "Artyom", LastName = "Hakobyan", Birthday = new DateTime(1995, 12, 25), Email = "artyom.hakobyan@daa.com" });
                context.Students.Add(new Student { Id = 3, FirstName = "Harutyun", LastName = "Grigoryan", Birthday = new DateTime(1996, 10, 15), Email = "harutyun.grigoryan@daa.com" });
                context.Lecturers.Add(new Lecturer { Id = 4, FirstName = "Mane", LastName = "Hakobyan", Email = "mane.hakobyan@ysu.am", Module = "Financial Mathematics" });
                context.Lecturers.Add(new Lecturer { Id = 5, FirstName = "Karen", LastName = "Arakelyan", Email = "karen.arakelyan@ysu.am", Module = "Econometrics" });
                context.Deans.Add(new Dean { Id = 6, FirstName = "Narek", LastName = "Movsisyan", Faculty = "Mathematics" });
                context.Deans.Add(new Dean { Id = 7, FirstName = "Yeva", LastName = "Zakaryan", Faculty = "Sociology" });
                context.Rectors.Add(new Rector { Id = 8, FirstName = "Aram", LastName = "Matevosyan", University = "YSU" });
                context.SaveChanges();
            }
        }
    }
}