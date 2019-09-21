using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace GithubAnalyzer
{
    class ProcessTest
    {
        public static List<UserInfo> GetWebData()
        {
            List<UserInfo> users = new List<UserInfo>();
            for (int i = 0; i < 10; i++)
            {
                var model1 = JsonConvert.DeserializeObject<TotalInfo>(File.ReadAllText(Environment.CurrentDirectory + "//GithubData.json"));
                users.AddRange(model1.items);
            }
            return users;
        }

        public static List<UserExtended> GetUserData()
        {
            List<UserInfo> users = GetWebData();
            List<UserExtended> profiles = new List<UserExtended>();
            for (int i = 0; i < 10; i++)
            {
                profiles.AddRange(JsonConvert.DeserializeObject<List<UserExtended>>(File.ReadAllText(Environment.CurrentDirectory + "//ProfileData.json")));
            }
            return profiles;
        }


        public static List<RepoInfo> GetRepoData()
        {
            List<UserInfo> users = GetWebData();
            List<List<RepoInfo>> reposList = new List<List<RepoInfo>>();
            List<RepoInfo> repos = new List<RepoInfo>();
            for (int i = 0; i < 3; i++)
            {
                var otherModel = JsonConvert.DeserializeObject<List<List<RepoInfo>>>(File.ReadAllText(Environment.CurrentDirectory + "//RepoData.json"));
                reposList.AddRange(otherModel);
            }
            foreach (var item in reposList)
            {
                repos.AddRange(item);
            }
            return repos;
        }

        public static int CSharpReposCount(out List<string> groupedByLanguage)
        {
            List<RepoInfo> repos = GetRepoData();
            int count = repos.Count(s => s.language == "C#");
            groupedByLanguage = repos.GroupBy(s => s.language).Select(s => s.Key).ToList();
            return count;
        }

        public static int NewReposCount()
        {
            List<RepoInfo> repos = GetRepoData();
            return repos.Count(s => s.created_at.Year == 2019);
        }

        public static dynamic MostStarredProfiles()
        {
            List<RepoInfo> repos = GetRepoData();
            var res = repos.GroupBy(s => s.owner.login).Select(s => new { Stars = s.Sum(ss => ss.stargazers_count), User = s.Key }).ToList();
            var newRes = res.OrderByDescending(s => s.Stars).Take(20);
            return newRes;
        }
    }
}
