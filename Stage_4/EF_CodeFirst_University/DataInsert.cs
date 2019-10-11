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
                Student st1 = new Student { Id = 1, FirstName = "Gohar", LastName = "Avagyan", Birthday = new DateTime(1995, 11, 25), Email = "gohar.avagyan@daa.com" };
                Student st2 = new Student { Id = 2, FirstName = "Artyom", LastName = "Hakobyan", Birthday = new DateTime(1995, 12, 25), Email = "artyom.hakobyan@daa.com" };
                Student st3 = new Student { Id = 3, FirstName = "Harutyun", LastName = "Grigoryan", Birthday = new DateTime(1996, 10, 15), Email = "harutyun.grigoryan@daa.com" };
                context.Students.Add(st1);
                context.Students.Add(st2);
                context.Students.Add(st3);

                Lecturer lec1 = new Lecturer { Id = 4, FirstName = "Mane", LastName = "Hakobyan", Email = "mane.hakobyan@ysu.am", Module = "Financial Mathematics", Students = new List<Student> { st1, st2 } };
                Lecturer lec2 = new Lecturer { Id = 5, FirstName = "Karen", LastName = "Arakelyan", Email = "karen.arakelyan@ysu.am", Module = "Econometrics", Students = new List<Student> { st2, st3} };
                context.Lecturers.Add(lec1);
                context.Lecturers.Add(lec2);

                Dean dean1 = new Dean { Id = 6, FirstName = "Narek", LastName = "Movsisyan", Faculty = "Mathematics", Lecturers = new List<Lecturer> { lec1 } };
                Dean dean2 = new Dean { Id = 7, FirstName = "Yeva", LastName = "Zakaryan", Faculty = "Sociology", Lecturers = new List<Lecturer> { lec2} };
                context.Deans.Add(dean1);
                context.Deans.Add(dean2);

                Rector rec = new Rector { Id = 8, FirstName = "Aram", LastName = "Matevosyan", University = "YSU", Deans = new List<Dean> { dean1, dean2} };
                context.Rectors.Add(rec);
                context.SaveChanges();
            }
        }
    }
}