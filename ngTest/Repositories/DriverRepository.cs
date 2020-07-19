using ngTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ngTest.Repositories
{
    public class DriverRepository : IDriverRepository
    {
        public List<Driver> GetDrivers()
        {


            try
            {
                List<Driver> drivers = new List<Driver>();
                string serverpath = HttpContext.Current.Server.MapPath("~/Storage/");
                string[] lines = System.IO.File.ReadAllLines(serverpath + @"\drivers.txt");

                foreach (var line in lines)
                {
                    var split = line.Split(':');
                    Driver d = new Driver
                    {
                        LicenseNumber = split[0],
                        Name = split[1],
                        Phone = split[2],
                        Address = split[5],
                        Email = split[6],
                    };

                    d.StartOfWork = new DateTime(Int32.Parse(split[3].Split('-')[2]), Int32.Parse(split[3].Split('-')[1]), Int32.Parse(split[3].Split('-')[1]));
                    d.LastEyesTest = new DateTime(Int32.Parse(split[4].Split('-')[2]), Int32.Parse(split[4].Split('-')[1]), Int32.Parse(split[4].Split('-')[1]));
                    drivers.Add(d);
                }
                return drivers;
            }
            catch
            {
                return new List<Driver>();
            }

        }
    }
}