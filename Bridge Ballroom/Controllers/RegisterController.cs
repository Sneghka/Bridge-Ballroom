
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

using BusinessLayer;
using ModelsLayer;

namespace Bridge_Ballroom.Controllers
{
    public class RegisterController : Controller
    {
       
        public ActionResult Index()
        {
            @ViewBag.ErrorMessage = TempData["ErrorMessage"];
            @ViewBag.CurrentName = TempData["CurrentName"];
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Register(Register model)
        {
            /*if (users.IsUserExist(model.UserName))*/
            if (UsersList.IsUserExist(model.UserName))
            {
                TempData["ErrorMessage"] = "The same name already exists.";
                TempData["CurrentName"] = model.UserName;
                return RedirectToAction("Index", "Register");
            }
            var user = new User();
            user.Name = model.UserName;
            user.Password = model.Password;
            UsersList.ListOfUser.Add(user);
           
            return RedirectToAction("Index","Login");
        }
    }
}