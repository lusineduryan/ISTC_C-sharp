using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_LinkedinProfiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Profiles> profiles = SQLConnector.GetProfilesInfo();
            foreach (var item in profiles)
            {
                Console.WriteLine(item.Username + " " +  item.FullName);
            }

            SQLConnector.WriteOnTable(profiles);

            Console.ReadKey();
          }
    }
}
