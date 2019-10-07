using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_University
{
    public class Dean
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Faculty { get; set; }

        public virtual ICollection<Lecturer> Lecturers { get; set; }
        public virtual Rector Rector { get; set; }
    }
}
