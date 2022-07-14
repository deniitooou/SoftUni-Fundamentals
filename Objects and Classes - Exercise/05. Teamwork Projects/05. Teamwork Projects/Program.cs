using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teamsToCreateCnt = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsToCreateCnt; i++)
            {
                string[] teamInfo = Console.ReadLine().Split("-");
                string creator = teamInfo[0];
                string teamName = teamInfo[1];

                if (isCreatorAlreadyExsist(teams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }

                else if (isTeamAlreadyExist(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }

                else
                {
                    Team team = new Team(teamName, creator);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] joinTeamInfo = input.Split("->");
                string member = joinTeamInfo[0];
                string teamToJoin = joinTeamInfo[1];

                if (!isTeamAlreadyExist(teams, teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }

                else if (isAlreadyMember(teams, member) || isCreatorAlreadyExsist(teams, member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamToJoin}!");
                }

                else
                {
                    Team team = GetTeam(teams, teamToJoin);
                    team.Members.Add(member);
                }

                input = Console.ReadLine();
            }

            List<Team> teamWithMember = teams
            .Where(x => x.Members.Count > 0)
            .OrderByDescending(x => x.Members.Count)
            .ThenBy(x => x.TeamName)
            .ToList();

            List<Team> notValidTeam = teams
            .Where(x => x.Members.Count == 0)
            .OrderBy(x => x.TeamName)
            .ToList();

            foreach (var team in teamWithMember)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine("- " + team.Creator);

                team.Members.Sort();

                Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(x => "-- " + x)));
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in notValidTeam)
            {
                Console.WriteLine(team.TeamName);
            }
        }

        static Team GetTeam(List<Team> teams, string teamToJoin)
        {
            Team searchedTeam = null;

            foreach (var team in teams)
            {

                if (team.TeamName == teamToJoin)
                {
                    searchedTeam = team;
                }
            }

            return searchedTeam;
        }

        static bool isAlreadyMember(List<Team> teams, string member)
        {
            bool isMember = false;

            foreach (var team in teams)
            {
                if (team.Members.Contains(member))
                {
                    isMember = true;
                }
            }

            return isMember;
        }

        static bool isTeamAlreadyExist(List<Team> teams, string teamName)
        {
            bool isExist = false;

            foreach (var team in teams)
            {
                if (team.TeamName == teamName)
                {
                    isExist = true;
                }
            }

            return isExist;
        }

        static bool isCreatorAlreadyExsist(List<Team> teams, string creator)
        {
            bool isExist = false;

            foreach (var team in teams)
            {
                if (team.Creator == creator)
                {
                    isExist = true;
                }
            }

            return isExist;
        }
    }

    class Team
    {
        public Team(string teamName, string creator)
        {
            this.TeamName = teamName;
            this.Creator = creator;
            this.Members = new List<string>();
        }

        public string TeamName { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }
}

