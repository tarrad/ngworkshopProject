using ngTest.Authentication;
using ngTest.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ngTest.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAuth _auth = new Auth();
        private readonly IUsersRepository _users = new UsersRepository();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> SignIn(string username, string password)
        {

            if (_users.CheckLoginValue(username, password))
            {
                string token = _auth.CreateJwt(username);
                return Json(new { response = token });
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            }
        }
    }
}