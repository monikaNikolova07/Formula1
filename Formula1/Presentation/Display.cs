using Formula1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Formula1.Presentation
{
    public class Display
    {
        private DriverController DriverController { get; set; } = new DriverController();

        private TeamController TeamController { get; set; } = new TeamController();

        public string ShowMenu()
        {
            Console.WriteLine("1.GetTeams");
            Console.WriteLine("2.GetTeamById");
            Console.WriteLine("3.GetTeamsByCountry");
            Console.WriteLine("4.GetOldestTeam");
            Console.WriteLine("5.GetDrivers ");
            Console.WriteLine("6.GetDriverById");
            Console.WriteLine("7.GetDriverByName");
            Console.WriteLine("8.GetDriversByNationality");
            Console.WriteLine("9.End");

            string comand = Console.ReadLine();

            while (comand != "0")
            {
                try
                {
                    switch (comand)
                    {
                        case "1":
                            var getTeams = TeamController.GetAllTeams();

                            if (getTeams.Count == 0)
                            {
                                Console.WriteLine("Not teams yet");
                            }

                            foreach (var item in getTeams)
                            {
                                Console.WriteLine($"{item.TeamName} - {item.Country} - {item.FoundationYear}");
                            }

                            break;

                        case "2":
                            Console.WriteLine("Id: ");

                            int id = int.Parse(Console.ReadLine());

                            var teamById = TeamController.GetTeamById(id);

                            if (teamById == null)
                            {
                                Console.WriteLine("No team found");
                            }

                            Console.WriteLine($"{teamById.TeamName} - {teamById.Country} - {teamById.FoundationYear}");
                            break;

                        case "3":
                            Console.WriteLine("Country: ");
                            string country = Console.ReadLine();

                            var teamsByCountry = TeamController.GetTeamsByCountry(country);

                            if (teamsByCountry.Count == 0)
                            {
                                Console.WriteLine("There are no teams from this country");
                            }

                            foreach (var item in teamsByCountry)
                            {
                                Console.WriteLine($"{item.TeamName} - {item.Country} - {item.FoundationYear}");
                            }
                            break;

                        case "4":
                            var oldestTeam = TeamController.GetOldestTeam();

                            Console.WriteLine($"{oldestTeam.TeamName} {oldestTeam.Country}");
                            break;

                        case "5":
                            var drivers = DriverController.GetAllDrivers();

                            if (drivers.Count == 0)
                            {
                                Console.WriteLine("There are no drivers");
                            }

                            foreach (var item in drivers)
                            {
                                Console.WriteLine($"{item.FirstName} {item.LastName} - {item.Nationality} - {item.BirthDate}");
                            }
                            break;

                        case "6":
                            Console.WriteLine("Id: ");
                            int idDriver = int.Parse(Console.ReadLine());

                            var driverById = DriverController.GetDriverById(idDriver);

                            if (driverById == null)
                            {
                                Console.WriteLine("No driver found");
                            }

                            Console.WriteLine($"{driverById.FirstName} {driverById.LastName} - {driverById.Nationality} - {driverById.BirthDate}");
                            break;

                        case "7":


                        case "8":
                            Console.WriteLine("Nationality: ");
                            string nationality = Console.ReadLine();

                            var driversByNationality = DriverController.GetDriversByNationality(nationality);

                            if (driversByNationality.Count == 0)
                            {
                                Console.WriteLine("There are no drivers found");
                            }

                            foreach (var item in driversByNationality)
                            {
                                Console.WriteLine($"{item.FirstName} {item.LastName} - {item.Nationality} - {item.BirthDate}");
                            }
                            break;

                        case "9":
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                comand = Console.ReadLine();    
            }
        }
    }
}
