using CltinderApi.Models;

namespace CltinderApi.Services
{
    public class LikeService
    {
        private List<Like> likes = new List<Like>();

        public void Add(Like like)
        {
            if (likes.Count == 0)
            {
                like.Id = 1;
            }
            else
            {
                like.Id = likes.Max(l => l.Id) + 1;
            }

            likes.Add(like);
        }

        public List<Like> GetAll()
        {
            return likes;
        }
        public Like GetById(int id)
        {
            return likes.FirstOrDefault(l => l.Id == id);
        }

        public void Delete(int id)
        {
            var like = GetById(id);
            if (like != null)
            {
                likes.Remove(like);
            }
        }
    }
}