using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ngTest.Repositories
{
    public interface IUsersRepository
    {
        bool CheckLoginValue(string username, string password);

    }
}