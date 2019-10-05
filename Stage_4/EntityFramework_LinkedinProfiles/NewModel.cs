using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_LinkedinProfiles
{
    public class NewModel
    {
        public static dynamic Generate()
        {
            using (MonitoringEntities context = new MonitoringEntities())
            {

                return context.GithubLinkedinCrossTables.Join(context.GithubProfiles, x => x.GithubUserId, y => y.Id, (x, y) => new { ID = y.Id, LinkedinUserId = x.LinkedinUserId, GithubUsername = y.UserName }).Join(context.LinkedinProfiles, x => x.LinkedinUserId, y => y.Id, (x, y) => new { Id = x.ID, GithubUsername = x.GithubUsername, LinkedinUsername = y.Username }).Select(x => new { x.Id, x.GithubUsername, x.LinkedinUsername }).ToList();
            }
        }
    }
}
