using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009TeamworkProjects
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                Team team = new Team();

                string[] input = Console.ReadLine().Split('-');
                string userName = input[0];
                string teamName = input[1];
                team.TeamName = teamName;
                team.CreatorName = userName;
                team.Members = new List<string>();

                if (teams.Any(a => a.TeamName == teamName))
                {
                    Console.WriteLine("Team {0} was already created!", teamName);
                }
                else if (teams.Any(a => a.CreatorName == userName))
                {
                    Console.WriteLine("{0} cannot create another team!", userName);
                }
                else
                {
                    Console.WriteLine("Team {0} has been created by {1}!", teamName, userName);
                    teams.Add(team);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of assignment")
                {
                    break;
                }
                else
                {
                    Team team = new Team();
                    string[] data = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    string userName = data[0];
                    string teamName = data[1];

                    if (!teams.Any(a => a.TeamName == teamName))
                    {
                        Console.WriteLine("Team {0} does not exist!", teamName);
                    }
                    else if (teams.Any(a => a.Members.Contains(userName) || a.CreatorName == userName))
                    {
                        Console.WriteLine("Member {0} cannot join team {1}!", userName, teamName);
                    }
                    else
                    {
                        team = teams.First(a => a.TeamName == teamName);
                        team.Members.Add(userName);
                    }
                }
            }


            List<string> teamsToRemove = new List<string>();

            foreach (var team in teams.OrderByDescending(a => a.Members.Count).ThenBy(d => d.TeamName))
            {
                if (team.Members.Count > 0)
                {
                    Console.WriteLine(team.TeamName);
                    Console.WriteLine("- {0}", team.CreatorName);

                    foreach (var member in team.Members.OrderBy(a => a))
                    {
                        Console.WriteLine("-- {0}", member);
                    }
                }
                else
                {
                    teamsToRemove.Add(team.TeamName);
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var item in teamsToRemove)
            {
                Console.WriteLine(item);
            }

        }
    }

    public class Team
    {
        public string TeamName { get; set; }

        public string CreatorName { get; set; }

        public List<string> Members { get; set; }
    }
}