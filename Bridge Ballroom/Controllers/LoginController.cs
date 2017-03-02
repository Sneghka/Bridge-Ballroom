using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Bridge_Ballroom.App_Start;
using Bridge_Ballroom.Models;

namespace Bridge_Ballroom.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        /* [HttpPost]
         [AllowAnonymous]
         public ActionResult Login(LoginModels model)
         {
             Type type = typeof(RegisterController);
             FieldInfo info = type.GetField("users", BindingFlags.NonPublic | BindingFlags.Static);
             object value = info.GetValue(null);
             @ViewBag.Test = model.UserName;
             return View();
         }*/

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginModels model)
        {
            //var users = RegisterController.users;

            if (UsersList.IsUserExist(model.UserName))
            {
                @ViewBag.Name = model.UserName;
                return View();
            }

            @ViewBag.ErrorMessage = "User doesn't exist. Please register.";
            return View("Index");
        }
    }
}