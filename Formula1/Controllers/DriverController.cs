using Formula1.Data;
using Formula1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1.Controllers
{
    public class DriverController
    {
        private Formula1Context formula1Context = new Formula1Context();

        public List<Driver> GetAllDrivers()
        {
            var drivers = formula1Context.Drivers
            .Select(d => new Driver
            {
                FirstName = d.FirstName,
                LastName = d.LastName,
                BirthDate = d.BirthDate,
                Nationality = d.Nationality,
            }).ToList();
            return drivers;
        }

        public Driver GetDriverById(int id)
        {
            var drivers = formula1Context.Drivers
                .Find(id);
            return drivers;
        }

        public List<Driver> GetDriverByLastName(string lastName)
        {
            var drivers = formula1Context.Drivers.Where(d => d.LastName == lastName).ToList();
            return drivers;
        }

        public List<Driver> GetDriversByNationality(string nationality)
        {
            var drivers = formula1Context.Drivers.Where(d => d.Nationality == nationality).ToList();
            return drivers;
        }

        internal IEnumerable<object> GetDriversByLastName(string? lastName)
        {
            throw new NotImplementedException();
        }
    }
}
