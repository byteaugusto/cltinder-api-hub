using CltinderApi.Models;

namespace CltinderApi.Services
{
    public class MatchService
    {
        private List<Match> matches = new List<Match>();

        public void Add(Match match)
        {
            matches.Add(match);
        }

        public List<Match> GetAll()
        {
            return matches;
        }
    }
}