using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_University
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UniversityContext context = new UniversityContext())
            {
                context.Students.Add(new Student { FirstName = "Lusine", LastName = "Duryan"});
                context.SaveChanges();
                Console.WriteLine("record added");
                Console.ReadKey();
            }
        }
    }
}
