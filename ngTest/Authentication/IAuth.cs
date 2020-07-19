using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Web;

namespace ngTest.Authentication
{
    public interface IAuth
    {
        string CreateJwt(string username);
    }
}