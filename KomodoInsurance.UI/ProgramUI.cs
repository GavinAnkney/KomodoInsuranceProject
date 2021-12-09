
using KomodoInsurance_Repositories;
using KomodoInsurance.POCOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.UI
{
    public class ProgramUI
    {
        private readonly DeveloperRepo _developerRepo = new DeveloperRepo();
        private readonly DevTeamRepo _devTeamRepo = new DevTeamRepo();
        private bool _isRunning = true;
        public void Run()
        {
            while (_isRunning)
            {
                RunMenu();
            }
        }

        private void RunMenu()
        {
            Console.WriteLine($"Welcome to Komodo Insurance Dev and Dev Team App! \n" +
                $"1. Create New Developer \n" +
                $"2. Create New Developer Team \n" +
                $"3. List of Developers \n" +
                $"4. List of Teams \n" +
                $"5. Add Developer To A Team \n" +
                $"6. Remove Developer From A Team \n" +
                $"7. Exit App");
            int menuNumber;
            if (int.TryParse(Console.ReadLine(), out menuNumber))
            {
                switch (menuNumber)
                {
                    case 1:
                        Developer developer = CreateNewDev();
                        _developerRepo.CreateNewDeveloper(developer);
                        Console.WriteLine("Added new developer! Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        DevTeam devTeam = CreateNewDevTeam();
                        _devTeamRepo.CreateDevTeam(devTeam);
                        Console.WriteLine("Added new team! Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        ListOfDevs();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        ListOfDevsTeams();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        _isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input, please enter number 1-7.");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter number 1-7.");
                Console.ReadKey();
                return;
            }
        }
        private Developer CreateNewDev()
        {
            Developer developer = new Developer();
            Console.WriteLine("What is the developers first name? Press any key to continue...");
            developer.FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name? Press enter when done...");
            developer.LastName = Console.ReadLine();
            Console.WriteLine("Do they have access to Pluralsight? (y/n) Press any key to continue...");
            string accessToPluralsightString = Console.ReadLine().ToLower();
            if (accessToPluralsightString == "y")
            {
                developer.HasAccessToPluralsight = true;
            }
            else
            {
                developer.HasAccessToPluralsight = false;
            }
            return developer;
        }
        private DevTeam CreateNewDevTeam()
        {
            DevTeam devTeam = new DevTeam();
            Console.WriteLine("What is your team name? Press any key to continue...");
            devTeam.TeamName = Console.ReadLine();
            return devTeam;
        }
        private void ListOfDevs()
        {
            Console.WriteLine("Available Developers:\n" +
                "Dev ID\tFirstName\tLastName\tHas Access to Pluralsight");
            foreach (var developer in _developerRepo.ListOfDevelopers())
            {
                Console.WriteLine($"{developer.DevId}\t{developer.FirstName}\t{developer.LastName}\t{developer.HasAccessToPluralsight}");
            }
        }
        private void ListOfDevsTeams()
        {
            Console.WriteLine("Current Dev Teams: \n" +
                "Team ID\tTeam Name\tDev Team Member");
            foreach (var devTeam in _devTeamRepo.GetDevTeams())
            {
                Console.WriteLine($"{devTeam.TeamId}\t{devTeam.TeamName}\t{devTeam.TeamMember}");
            }
        }
    }
}