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
                DataInsert.AddData();

                Console.WriteLine("records added");
                Console.ReadKey();
            }
        }
    }
}
