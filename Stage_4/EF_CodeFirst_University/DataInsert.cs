using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_University
{
    public class DataInsert
    {
        public static void AddStudentsData()
        {
            using (UniversityContext context = new UniversityContext())
            {
                context.Students.Add(new Student { FirstName = "Gohar", LastName = "Avagyan", Birthday = new DateTime(1995, 11, 25), Email = "gohar.avagyan@daa.com" });
                context.Students.Add(new Student { FirstName = "Artyom", LastName = "Hakobyan", Birthday = new DateTime(1995, 12, 25), Email = "artyom.hakobyan@daa.com" });
                context.Students.Add(new Student { FirstName = "Harutyun", LastName = "Grigoryan", Birthday = new DateTime(1996, 10, 15), Email = "harutyun.grigoryan@daa.com" });
                context.SaveChanges();
            }
        }

        public static void AddLecturersDate()
        {
            using (UniversityContext context = new UniversityContext())
            {
                context.Lecturers.Add(new Lecturer { FirstName = "Mane", LastName = "Hakobyan", Email = "mane.hakobyan@ysu.am", Module = "Financial Mathematics" });
                context.Lecturers.Add(new Lecturer { FirstName = "Karen", LastName = "Arakelyan", Email = "karen.arakelyan@ysu.am", Module = "Econometrics" });
                context.SaveChanges();
            }
        }

        public static void AddDeansData()
        {
            using (UniversityContext context = new UniversityContext())
            {
                context.Deans.Add(new Dean { FirstName = "Narek", LastName = "Movsisyan", Faculty = "Mathematics" });
                context.Deans.Add(new Dean { FirstName = "Yeva", LastName = "Zakaryan", Faculty = "Sociology" });
                context.SaveChanges();
            }
        }

        public static void AddRectorsData()
        {
            using (UniversityContext context = new UniversityContext())
            {
                context.Rectors.Add(new Rector { FirstName = "Aram", LastName = "Matevosyan", University = "YSU" });
                context.SaveChanges();
            }
        }
    }
}
