using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace GithubAnalyzer
{
    public class Process
    {
        public static List<UserInfo> GetWebData()
        {
            WebClient source = new WebClient();
            string content = "";
            List<UserInfo> users = new List<UserInfo>();
            for (int i = 0; i < 10; i++)
            {
                content = source.DownloadString("https://api.github.com//search//users?q=location:armenia&page=" + i + "&per_page=100");
                var model1 = JsonConvert.DeserializeObject<TotalInfo>(content);
                users.AddRange(model1.items);
            }
            return users;
        }


        public static List<UserExtended> GetUserData()
        {
            WebClient source = new WebClient();
            List<UserInfo> users = GetWebData();
            List<UserExtended> profiles = new List<UserExtended>();
            for (int i = 0; i < 9; i++)
            {
                string urls = source.DownloadString(users[i].url);
                profiles.AddRange(JsonConvert.DeserializeObject<List<UserExtended>>(urls));
            }
            return profiles;
        }

        public static List<RepoInfo> GetRepoData()
        {
            WebClient source = new WebClient();
            List<UserInfo> users = GetWebData();
            List<List<RepoInfo>> reposList = new List<List<RepoInfo>>();
            List<RepoInfo> repos = new List<RepoInfo>();
            for (int i = 0; i < 9; i++)
            {
                string repoUrls = source.DownloadString(users[i].repos_url);
                reposList.AddRange(JsonConvert.DeserializeObject<List<List<RepoInfo>>>(repoUrls));
                foreach (var item in reposList)
                {
                    repos.AddRange(item);
                }
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

        public static object MostStarredProfiles()
        {
            List<RepoInfo> repos = GetRepoData();
            var res = repos.GroupBy(s => s.owner.login).Select(s => new { Stars = s.Sum(ss => ss.stargazers_count), User = s.Key }).ToList();
            var newRes = res.OrderByDescending(s => s.Stars).Take(20);
            return newRes;
        }
    }
}
