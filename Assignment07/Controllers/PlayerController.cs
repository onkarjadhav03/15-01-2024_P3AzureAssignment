using Assignment07.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment07.Controllers
{
    public class PlayerController : Controller
    {
        static List<Players> players = new List<Players>()
        {
            new Players(){PId = 1,PName="Rohit",Country="India",PType="All-rounder"}, 
            new Players(){PId = 2,PName="Virat",Country="India",PType="Batsman"}, 
            new Players(){PId = 3,PName="Steyn",Country="South Africa",PType="Bowler"}, 
            new Players(){PId = 4,PName="Gayle",Country="West Indies",PType="All-rounder"}, 
            new Players(){PId = 5,PName="Warner",Country="Austrilia",PType="Batsman"}, 
        };
        public IActionResult Index()
        {
            return View(players);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Players());
        }
        [HttpPost]
        public IActionResult Create(Players play)
        {
            if (ModelState.IsValid)
            {
                players.Add(play);
            }
            return View();
        }
    }
}
