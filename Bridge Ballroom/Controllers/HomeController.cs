using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bridge_Ballroom.App_Start;
using Bridge_Ballroom.Models;

namespace Bridge_Ballroom.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var name = TempData["UserName"] as string;
            var user = (from u in UsersList.ListOfUser where u.Name == name select u).First();
            @ViewBag.Name = user.Name;
            return View(user);
        }
    }
}