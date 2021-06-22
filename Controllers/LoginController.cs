using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginEg.Models;
using Microsoft.AspNetCore.Http;

namespace LoginEg.Controllers
{
    public class LoginController : Controller
    {
        private readonly WBProjectContext _db;
        private readonly ISession session;
       
        public LoginController(WBProjectContext db,IHttpContextAccessor httpContextAccessor)
        {
            _db = db;
            session = httpContextAccessor.HttpContext.Session;
        }

        public IActionResult Login()
        {
            return View();
        }
        //New Comment Added
        [HttpPost]
        public IActionResult Login(Login l)
        {
           // using(var db=new WBProjectContext())
            //{
                 User obj = (from i in _db.Users
                              where i.EmailId == l.EmailId && i.Password == l.Password
                              select i).FirstOrDefault();
                if(obj!=null)
                {
                    string email = obj.EmailId;
                    HttpContext.Session.SetString("email", email);
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    return View();
                }
            //}
        }
    }
}
