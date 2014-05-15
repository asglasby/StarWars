using starWars54.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace starWars54.Controllers
{

    public class HomeController : Controller
    {


        public HomeController()
        {
            if (AllCharacters.Characters == null)
            {
                AllCharacters.Characters = new List<Character>(){
        new Jedi(1, "Mace Wendu", "short Bio", "Pic Url", "Purple", "Awesome", "The Best"),
        new Jedi(2, "Yoda", "short Bio", "Pic Url", "Purple", "Awesome", "The Best"),
        new Jedi(3, "Luke", "short Bio", "Pic Url", "Purple", "Awesome", "The Best"),
        new BountyHunter(-10,"Boba Fett", "bio", "pic", "Gun", 21.9, 99),
        new BountyHunter(20, "Jango Fett", "bio", "pic", "Gun", 21.9, 99),
        new BountyHunter(30, "Grevious", "bio", "pic", "Gun", 21.9, 99)
    };
                
            }
        }


        public ActionResult Index(string Search)
        {
            var index = 0;

            HomeVM model = new HomeVM();

            if (Search == null)
            {

                model.CharList = AllCharacters.Characters;
                model.Quote = "may the force be with you";
            }
            else
            {
                Search = Search.ToLower();
                model.Quote = "You Searched for" + Search;
                model.CharList = AllCharacters.Characters.Where(x =>
                    x.Name.Contains(Search) ||
                    x.Bio.Contains(Search) ||
                    x.GetType().Name.ToLower() == Search).ToList();

            }

            Random random = new Random();
            index = random.Next(AllCharacters.Characters.Count);
            model.Character = AllCharacters.Characters[index];



            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult JediDetails(int id)
        {
            Character character = AllCharacters.Characters.Find(x => x.Id == id);

            return View(character);
        }

        public ActionResult BHDetails(int id)
        {

            Character character = AllCharacters.Characters.Find(x => x.Id == id);

            return View(character);
        }
        [HttpGet]
        public ActionResult AddJedi()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddJedi(Jedi Jedi)
        {
            AllCharacters.Characters.Add(Jedi);
            return RedirectToAction("Index");
        }
    }
}