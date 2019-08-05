using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeknoLabs.DontBreakTheChain.Business;

namespace TeknoLabs.DontBreakTheChain.WebUI.Controllers
{
    public class HabitController : Controller
    {
        private IHabitService _habitService;

        public HabitController(IHabitService habitService)
        {
            _habitService = habitService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}