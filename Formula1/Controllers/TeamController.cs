using Formula1.Data;
using Formula1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1.Controllers
{
    public class TeamController
    {
        private Formula1Context formula1Context = new Formula1Context();

        public List<Team> GetAllTeams()
        {
            var team = formula1Context.Teams.Select(t => new Team
                                                {
                                                    TeamName = t.TeamName,
                                                    Country = t.Country,
                                                    FoundationYear = t.FoundationYear
                                                }).ToList();

            return team;
        }

        public Team GetTeamById(int id)
        {
            var team = formula1Context.Teams.Find(id);
            return team;
        }

        public List<Team> GetTeamsByCountry(string country)
        {
            var teams = formula1Context.Teams
                .Where(t => t.Country == country)
                .Select(t => new Team
                {
                    TeamName = t.TeamName,
                    Country = t.Country,
                    FoundationYear = t.FoundationYear
                })
                .ToList();

            return teams;
        }

        public Team GetOldestTeam()
        {
            var team = formula1Context.Teams.OrderBy(t => t.FoundationYear).First();
            return team;
        }
    }
}
