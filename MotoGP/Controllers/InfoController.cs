using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MotoGP.Models;

namespace MotoGP.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult ListRaces()
        {
            int banner = 1;
            ViewData["Banner"] = banner;
            return View();
        }

        public IActionResult ListTeams()
        {
            int banner = 2;
            ViewData["Banner"] = banner;
            return View();
        }

        public IActionResult ListRiders()
        {
            int banner = 3;
            ViewData["Banner"] = banner;
            return View();
        }

        public IActionResult BuildMap()
        {
            List<Race> races = new List<Race>();
            races.Add(new Race() { RaceID = 1, X = 517, Y = 19, Name = "Assen" });
            races.Add(new Race() { RaceID = 2, X = 859, Y = 249, Name = "Losail Circuit" });
            races.Add(new Race() { RaceID = 3, X = 194, Y = 428, Name = "Autódromo Termas de Río Hondo" });

            ViewData["Banner"] = 1;
            return View(races);
        }
    }
}
