using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotoGP.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult OrderTicket()
        {
            ViewData["Banner"] = 4;
            return View();
        }

        public IActionResult ConfirmOrder()
        {
            DateTime dateTime = DateTime.Today;
            ViewData["Banner"] = 4;
            ViewData["Message"] = $"Thank you for ordering tickets! Your booking is registered on {dateTime.ToString("dd/MM/yyyy")}. We will send out your tickets in the coming week.";
            return View();
        }
    }
}
