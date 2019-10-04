select * from LinkedinProfile

select * from GithubProfile

select * from GithubLinkedinCrossTable

select GithubLinkedinCrossTable.Id, GithubUserId, LinkedinUserId, GithubProfile.UserName as GithubUsername, LinkedinProfile.Username as LinkedinUsername
from GithubLinkedinCrossTable 
join GithubProfile
on GithubLinkedinCrossTable.GithubUserId = GithubProfile.Id
join LinkedinProfile
on GithubLinkedinCrossTable.LinkedinUserId = LinkedinProfile.Id
