using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ngTest.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        public bool CheckLoginValue(string username, string password)
        {

            string serverpath = HttpContext.Current.Server.MapPath("~/Storage/");
            string[] lines = System.IO.File.ReadAllLines(serverpath + @"\listOfUsers.txt");

            foreach (var line in lines)
            {
                var split = line.Split(':');
                if (split[0] == username)
                {
                    if (split[1] == password)
                    {

                        return true;
                    }
                    return false;
                }
            }
            return false;
        }


    }
}