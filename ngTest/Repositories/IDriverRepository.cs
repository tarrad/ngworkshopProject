using ngTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ngTest.Repositories
{
    public interface IDriverRepository
    {
        List<Driver> GetDrivers();  
    }
}