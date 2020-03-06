using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Teamwork_Projects
{
    class Team
    {
        public Team(string creator, string name)
        {
            this.Creator = creator;
            this.TeamName = name;

            this.Members = new List<string>();
        }
        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }

        public override string ToString()
        {
            List<string> sortedMembers = this.Members.OrderBy(a => a).ToList();
            
            string output = $"{this.TeamName}\n";
            output += $"- {this.Creator}\n";

            for (int i = 0; i < sortedMembers.Count; i++)
            {
                output += $"-- {sortedMembers[i]}\n";
            }

            return output.Trim();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 1; i <= num; i++)
            {
                string[] info = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
                string member = info[0];
                string teamName = info[1];

                if (!CheckIfExist(teams, teamName))
                {
                    if (!IsScam(teams, member))
                    {
                        Team team = new Team(member, teamName);

                        teams.Add(team);

                        Console.WriteLine($"Team {teamName} has been created by {member}!");

                    }
                    else
                    {
                        Console.WriteLine($"{member} cannot create another team!");
                    }

                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] info = command.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string member = info[0];
                string teamName = info[1];

                if (CheckIfExist(teams, teamName))
                {
                    if (!IsScam(teams, member))
                    {
                        Team team = FindTeam(teams, teamName);

                        team.Members.Add(member);
                    }
                    else
                    {
                        Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
            }

            List<string> invalidTeams = teams
                .Where(t => t.Members.Count <= 0)
                .OrderBy(t => t.TeamName)
                .Select(t=>t.TeamName)
                .ToList();

            teams.RemoveAll(t => t.Members.Count <= 0);

            List<Team> sortedTeams= teams.OrderByDescending(t => t.Members.Count).ThenBy(t => t.TeamName).ToList();

            foreach (Team team in sortedTeams)
            {
                Console.WriteLine(team.ToString());
            }

            Console.WriteLine("Teams to disband:");

            foreach (string team in invalidTeams)
            {
                Console.WriteLine(team);
            }
        }

        static Team FindTeam(List<Team> teams, string teamName)
        {
            Team existingTeam = null;

            foreach (Team team in teams)
            {
                if (team.TeamName == teamName)
                {
                    existingTeam = team;
                    break;
                }

            }

            return existingTeam;
        }
        public static bool CheckIfExist(List<Team> teams, string teamName)
        {
            foreach (Team team in teams)
            {
                if (team.TeamName == teamName)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsScam(List<Team> teams, string member)
        {
            foreach (Team team in teams)
            {
                if (team.Creator == member || team.Members.Contains(member))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
