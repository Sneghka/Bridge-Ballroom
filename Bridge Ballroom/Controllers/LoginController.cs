using System.Web.Mvc;
using BusinessLayer;
using ModelsLayer;

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


        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(Login model)
        {

            if (UsersList.IsUserExist(model.UserName))
            {
                @ViewBag.Name = model.UserName;
                TempData["UserName"] = model.UserName;

                return RedirectToAction("Index", "Home");
            }

            @ViewBag.ErrorMessage = "User doesn't exist. Please register.";
            return View("Index");
        }
    }
}