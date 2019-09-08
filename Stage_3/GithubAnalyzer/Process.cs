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
                profiles = JsonConvert.DeserializeObject<List<UserExtended>>(urls);
            }
            return profiles;
        }

        public static List<RepoInfo> GetRepoData()
        {
            WebClient source = new WebClient();
            List<UserInfo> users = GetWebData();
            List<RepoInfo> repos = new List<RepoInfo>();
            for (int i = 0; i < 9; i++)
            {
                string repoUrls = source.DownloadString(users[i].repos_url);
                repos = JsonConvert.DeserializeObject<List<RepoInfo>>(repoUrls);
            }
            return repos;
        }
    }
}
