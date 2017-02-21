using Bridge_Ballroom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Bridge_Ballroom.App_Start;

namespace Bridge_Ballroom.Controllers
{
    public class RegisterController : Controller
    {
       public static UsersList users = new UsersList();

        // GET: Register
        public ActionResult Index()
        {
            @ViewBag.ErrorMessage = TempData["ErrorMessage"];
            @ViewBag.CurrentName = TempData["CurrentName"];
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Register(RegisterModels model)
        {
            if (users.IsUserExist(model.UserName))
            {
                TempData["ErrorMessage"] = "The same name already exists.";
                TempData["CurrentName"] = model.UserName;
                return RedirectToAction("Index", "Register");
            }
            var user = new UserModels();
            user.Name = model.UserName;
            user.Password = model.Password;
            users.ListOfUser.Add(user);
           
            return RedirectToAction("Index","Login");
        }
    }
}