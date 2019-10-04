using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_LinkedinProfiles
{
    public class NewModel
    {
        public void Generate()
        {
            using (MonitoringEntities context = new MonitoringEntities())
            {
                var halfJoin = context.GithubLinkedinCrossTables.Join(context.GithubProfiles, x => x.GithubUserId, y => y.Id, (x, y) => new { Id = x.GithubUserId, Username = y.UserName }).Select(xy => xy.Username).ToList();
                var fullJoin = halfJoin.Join(context.LinkedinProfiles,)
            }
        }
    }
}
