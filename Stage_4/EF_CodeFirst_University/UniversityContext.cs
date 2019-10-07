using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF_CodeFirst_University
{
    class UniversityContext : DbContext
    {
        public UniversityContext() : base("name = UniversityContext") { }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Lecturer> Lecturers { get; set; }
        public virtual DbSet<Dean> Deans { get; set; }
        public virtual DbSet<Rector> Rectors { get; set; }
    }
}
