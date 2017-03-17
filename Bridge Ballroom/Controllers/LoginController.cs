using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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


        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginModels model)
        {
            var rnd = new Random();
            var game = new GameModels()
            {
                TotalScore = 13,
                PlayingUsers = "User1, User2, User3, User4",
                Points = 23,
                ContractName = "2Hearts",
                TricksNumber = 10,
                Date = new DateTime(2017, 01, 10),
                GameId = rnd.Next(100000, 900000).ToString()

            };


            var gameSet = new GamesSet();
            for (int i = 0; i < 16; i++)
            {
                gameSet.Games.Add(game);
            }
            gameSet.Status = "Done";
            game.TotalScore = 13;
            game.GameId = rnd.Next(1, 50000).ToString();


            var user = new UserModels()
            {
                Name = "User",
                Password = "1",
                UserId = rnd.Next(1000001,1000000000).ToString()
            };

            user.SetsList.Add(gameSet);
            UsersList.ListOfUser.Add(user);

           

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