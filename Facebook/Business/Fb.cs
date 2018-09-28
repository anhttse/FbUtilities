using System.Threading.Tasks;

namespace Facebook.Business
{
    public class Fb
    {
        private readonly FacebookClient _fb;

        public Fb()
        {
            _fb = new FacebookClient();
        }

        public void SetToken(string token)
        {
            _fb.AccessToken = token;
        }

        public Task<Result> GetGroups()
        {
            return _fb.GetTaskAsync<Result>("/me/groups?fields=id,name,privacy,member_count");
        }

        public Task<FbUser> GetUser()
        {
            return _fb.GetTaskAsync<FbUser>("/me?fields=id,name");
        }
        public Task<object> Share(string linkToShare, string gId, string msg)
        {
            var obj = new { link = linkToShare, message = msg };
            return _fb.PostTaskAsync($"{gId}/feed", obj);
        }

        public Task<object> React(string id)
        {
            return null;
        }
    }
}
